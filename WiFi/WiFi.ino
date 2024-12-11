#include <dummy.h>
#include <ESP8266WiFi.h>
#include <WiFiUdp.h>

WiFiUDP udp;
char ssid[32];
char password[32];
char serverIP[16];
int serverPort;
const int localPort = 12346;

const int ledPin = 2;
const int Pin = A0;

void configurar() {
	Serial.println("Insere Wi-Fi SSID:");
	while (!Serial.available()) {}
	Serial.readBytesUntil('\n', ssid, sizeof(ssid));
	ssid[strcspn(ssid, "\r\n")] = 0;

	Serial.println("Insere Wi-Fi Password:");
	while (!Serial.available()) {}
	Serial.readBytesUntil('\n', password, sizeof(password));
	password[strcspn(password, "\r\n")] = 0;

	Serial.println("Insere Server IP:");
	while (!Serial.available()) {}
	Serial.readBytesUntil('\n', serverIP, sizeof(serverIP));
	serverIP[strcspn(serverIP, "\r\n")] = 0;

	Serial.println("Insere Server Port:");
	while (!Serial.available()) {}
	String portString = Serial.readStringUntil('\n');
	serverPort = portString.toInt();

	Serial.println("Configuração recebida:");
	Serial.print("SSID: "); Serial.println(ssid);
	Serial.print("Password: "); Serial.println(password);
	Serial.print("Server IP: "); Serial.println(serverIP);
	Serial.print("Server Port: "); Serial.println(serverPort);
}

void setup(void)
{
	Serial.begin(115200);

	configurar();

	WiFi.begin(ssid, password);
	while (WiFi.status() != WL_CONNECTED)
	{
		delay(100);
		Serial.print("*");
	}
	Serial.println("");
	Serial.println("Conexão Wi-Fi bem-sucedida");

	udp.begin(localPort);
}

void loop()
{
	// Envia pacotes
	if (Serial.available() > 0)
	{
		udp.beginPacket(serverIP, serverPort);
		udp.write(Serial.readString().c_str());
		udp.endPacket();
	}

	// Recebe pacotes
	int packetSize = udp.parsePacket();
	if (packetSize)
	{
		char incomingPacket[255];
		int len = udp.read(incomingPacket, 255);
		if (len > 0)
		{
			incomingPacket[len] = 0;
		}
		Serial.println(incomingPacket);
	}

	delay(250);
}
