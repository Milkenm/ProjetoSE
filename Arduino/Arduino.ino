#include "DHT.h"
#include "MQUnifiedsensor.h"

#define PINO_SOLO A0
#define PINO_DHT 2
#define PINO_MQ2 A1

#define PINO_LED1 4
#define PINO_LED2 5
#define PINO_LED3 6

DHT dht(PINO_DHT, DHT11);
MQUnifiedsensor MQ2("Arduino UNO", 5, 10, PINO_MQ2, "MQ-2");

void setup()
{
	Serial.begin(115200); 
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

	Serial.println(String(humidadeSolo) + "," + String(humidadeAr) + "," + String(temperaturaAr) + "," + String(qualidadeAr) + ";");
  
	if (Serial.available()) 
	{
		if (strcmp(incomingPacket, "L1") == 0) 
		{
			digitalWrite(PINO_LED1, HIGH);
		} 
		else if (strcmp(incomingPacket, "D1") == 0) 
		{
			digitalWrite(PINO_LED1, LOW);
		} 
		else if (strcmp(incomingPacket, "L2") == 0) 
		{
			digitalWrite(PINO_LED2, HIGH);
		} 
		else if (strcmp(incomingPacket, "D2") == 0) 
		{
			digitalWrite(PINO_LED2, LOW);
		} 
		else if (strcmp(incomingPacket, "L3") == 0) 
		{
			digitalWrite(PINO_LED3, HIGH);
		} 
		else if (strcmp(incomingPacket, "D3") == 0) 
		{
			digitalWrite(PINO_LED3, LOW);
		} 
		else 
		{
			Serial.println("Comando desconhecido");
		}
	}

	delay(5000);
}