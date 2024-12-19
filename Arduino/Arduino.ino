#include "DHT.h"
#include "MQUnifiedsensor.h"

#define PINO_SOLO A0
#define PINO_DHT 2
#define PINO_MQ2 A1
#define PINO_LUZ A2

#define PINO_LED1 4
#define PINO_LED2 5
#define PINO_LED3 6
#define PINO_LED4 7

DHT dht(PINO_DHT, DHT11);
MQUnifiedsensor MQ2("Arduino UNO", 5, 10, PINO_MQ2, "MQ-2");

#define SPTR_SIZE 20
char *sPtr [SPTR_SIZE];

int separate (String str, char **p, int size)
{
    int  n;
    char s[100];

    strcpy (s, str.c_str ());

    *p++ = strtok (s, ";");
    for (n = 1; NULL != (*p++ = strtok (NULL, ";")); n++)
      {
        if (size == n)
            {
              break;
            }
      }

    return n;
}

void splitStringBySemicolon(String str) {
  int startIndex = 0;
  int semicolonIndex;
  
  // Loop through the string and split by semicolon
  while ((semicolonIndex = str.indexOf(';', startIndex)) != -1) {
    String part = str.substring(startIndex, semicolonIndex);  // Extract the part between startIndex and semicolonIndex
    Serial.println(part);  // Process or print the part

String command = part;
  if (command.startsWith("L1")) 
      {
        digitalWrite(PINO_LED1, HIGH);
      } 
      else if (command.startsWith("D1")) 
      {
        digitalWrite(PINO_LED1, LOW);
      } 
      else if (command.startsWith("L2")) 
      {
        digitalWrite(PINO_LED2, HIGH);
      } 
      else if (command.startsWith("D2")) 
      {
        digitalWrite(PINO_LED2, LOW);
      } 
      else if (command.startsWith("L3")) 
      {
        digitalWrite(PINO_LED3, HIGH);
      } 
      else if (command.startsWith("D3")) 
      {
        digitalWrite(PINO_LED3, LOW);
      }
      else if (command.startsWith("L4"))
      {
        digitalWrite(PINO_LED4, HIGH);
      }
      else if (command.startsWith("D4"))
      {
        digitalWrite(PINO_LED4, LOW);
      }
    
    startIndex = semicolonIndex + 1;  // Move the startIndex to the next part
  }

  // Handle the last part after the last semicolon
  String lastPart = str.substring(startIndex);
  if (lastPart.length() > 0) {
    Serial.println(lastPart);  // Process or print the last part

String command = lastPart;

    if (command.startsWith("L1")) 
      {
        digitalWrite(PINO_LED1, HIGH);
      } 
      else if (command.startsWith("D1")) 
      {
        digitalWrite(PINO_LED1, LOW);
      } 
      else if (command.startsWith("L2")) 
      {
        digitalWrite(PINO_LED2, HIGH);
      } 
      else if (command.startsWith("D2")) 
      {
        digitalWrite(PINO_LED2, LOW);
      } 
      else if (command.startsWith("L3")) 
      {
        digitalWrite(PINO_LED3, HIGH);
      } 
      else if (command.startsWith("D3")) 
      {
        digitalWrite(PINO_LED3, LOW);
      }
      else if (command.startsWith("L4"))
      {
        digitalWrite(PINO_LED4, HIGH);
      }
      else if (command.startsWith("D4"))
      {
        digitalWrite(PINO_LED4, LOW);
      }
  }
}

void setup()
{
	Serial.begin(115200); 

  delay(5000);
  Serial.println("Mike");
  delay(500);
  Serial.println("12345678");
  delay(500);
  Serial.println("192.168.93.199");
  delay(500);
  Serial.println("12345");
  delay(5000);

	dht.begin();   

	pinMode(A0, INPUT);
	pinMode(A1, INPUT);

	MQ2.setRegressionMethod("Exponential");
	MQ2.setA(107.3);
	MQ2.setB(-2.92);
	MQ2.setR0(1);
	MQ2.init(); 
}

void loop()
{
	float humidadeSolo = analogRead(PINO_SOLO);

	float humidadeAr = dht.readHumidity();
	float temperaturaAr = dht.readTemperature();
  
	MQ2.update();
	float qualidadeAr = MQ2.readSensor();

  float luminosidade = analogRead(PINO_LUZ);

	Serial.println(String(humidadeSolo) + "," + String(humidadeAr) + "," + String(temperaturaAr) + "," + String(qualidadeAr) + "," + String(luminosidade) + ";");
  
	if (Serial.available() > 0) 
	{
    String packet = Serial.readString();
    packet.trim();
      splitStringBySemicolon(packet);  // Split the string by ';'
   
    int N = separate (packet, sPtr, SPTR_SIZE);
    for (int n = 0; n < N; n++)
    {
      String command = sPtr[n];

      Serial.println(command);
    }
  }
	
	delay(1000);
}