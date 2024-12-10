#include <dummy.h>

#include <ESP8266WiFi.h>
#include <WiFiUdp.h>

const char* ssid = "Mike";          // Nome da rede Wi-Fi
const char* password = "12345678";  // Senha da rede Wi-Fi

// Configuração do servidor UDP (para envio)
const char* serverIP = "192.168.93.199";  // IP do servidor que irá receber a mensagem (PODE MUDAR DIARIAMENTE!!!)
const int serverPort = 12345;            // Porta do servidor

// Configuração do cliente UDP (para receber mensagens)
const int localPort = 12346;  // Porta onde o ESP8266 irá escutar as mensagens

// Definir pino do LED
const int ledPin = 2;  // Pino onde o LED está conectado (por exemplo, D1 = GPIO5)
const int Pin = A0;    // Pino do potenciômetro (use A0 para ADC no ESP8266)

WiFiUDP udp;

void setup(void) {
  Serial.begin(115200);

  // Teste
  pinMode(ledPin, OUTPUT);
  pinMode(Pin, INPUT);

  // Conectar à rede Wi-Fi
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print("*");
  }

  Serial.println("");
  Serial.println("Conexão Wi-Fi bem-sucedida");
  Serial.print("Endereço IP do ESP8266: ");
  Serial.println(WiFi.localIP());

  // Iniciar o cliente UDP para receber mensagens na porta local
  udp.begin(localPort);
  Serial.print("Aguardando mensagens UDP na porta ");
  Serial.println(localPort);
}

void loop() {
  Serial.print("Olá");
  // Enviar a mensagem via UDP para o servidor
  String mensagem = "Olá, esta é uma mensagem enviada via UDP com ESP8266: '" + Serial.readString() + "'";

  udp.beginPacket(serverIP, serverPort);  // Inicia o pacote UDP para o servidor
  udp.write(mensagem.c_str());            // Envia a mensagem
  udp.endPacket();                        // Finaliza o envio

  Serial.println("Mensagem enviada!");

  // Verificar se há dados recebidos via UDP
  int packetSize = udp.parsePacket();
  if (packetSize) {
    Serial.print("Recebido pacote de ");
    Serial.print(udp.remoteIP());   // IP do remetente
    Serial.print(":");
    Serial.println(udp.remotePort());  // Porta do remetente

    // Ler os dados recebidos
    char incomingPacket[255];  // Buffer para armazenar a mensagem recebida
    int len = udp.read(incomingPacket, 255);
    if (len > 0) {
      incomingPacket[len] = 0;  // Adicionar o terminador de string
    }
    
    // Exibir a mensagem recebida
    Serial.print("Mensagem recebida: ");
    Serial.println(incomingPacket);

    // Ativar ou desativar o LED com base na mensagem recebida
    if (strcmp(incomingPacket, "LIGAR") == 0) {
      digitalWrite(ledPin, HIGH);  // Liga o LED
      Serial.println("LED ligado");
    } 
    else if (strcmp(incomingPacket, "DESLIGAR") == 0) {
      digitalWrite(ledPin, LOW);   // Desliga o LED
      Serial.println("LED desligado");
    } 
    else {
      Serial.println("Comando desconhecido");
    }

    // Ler o valor do potenciômetro
    int potenciometroValor = analogRead(Pin);  // Leitura do potenciômetro
    Serial.print("Valor do potenciômetro: ");
    Serial.println(potenciometroValor);  // Valor entre 0 e 1023
  }

  delay(5000);  // Enviar uma mensagem a cada 5 segundos
}
