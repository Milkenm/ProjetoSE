// ----------- LIBRARIA SENSOR TEMPERATURA ----------------------
#include "DHT.h"


#define DHTPIN 2     // Pino digital conectado ao sensor DHT
#define DHTTYPE DHT11   // Sensor DHT11

DHT dht(DHTPIN, DHTTYPE);

// ----------- PINO SENSOR HUMIDADE SOLO ----------------------
#define SOIL_MOISTURE_PIN A0  // Pino analógico A0


// ----------- PINO SENSOR QUALIDADE DO AR ----------------------
#include "MQUnifiedsensor.h"  // Incluindo a biblioteca do MQUnifiedSensor

/************************Hardware Related Macros************************************/
#define         Board                   ("Arduino UNO")
#define         Pin                     (A1)  //Analog input A1 of your arduino
/***********************Software Related Macros************************************/
#define         Type                    ("MQ-2") //MQ4
#define         Voltage_Resolution      (5)
#define         ADC_Bit_Resolution      (10) // For arduino UNO/MEGA/NANO
#define         RatioMQ4CleanAir        (4.4) //RS / R0 = 60 ppm 
/*****************************Globals***********************************************/
//Declare Sensor
MQUnifiedsensor MQ2(Board, Voltage_Resolution, ADC_Bit_Resolution, Pin, Type);

void setup() {
  Serial.begin(115200);  // Inicializa a comunicação serial
   dht.begin();          // Inicializa o sensor DHT
   pinMode(A0, INPUT);
   pinMode(A1, INPUT);

   MQ2.setRegressionMethod("Exponential");  // Método exponencial para calcular a concentração de gases
   MQ2.setA(107.3); MQ2.setB(-2.92);     // Configura a equação para calcular a concentração do gás
   MQ2.setR0(1);  // Valor de R0 obtido na calibração do sensor
  
   MQ2.init(); 
}

void loop() {
  // ----------- LEITURA SENSOR HUMIDADE SOLO ----------------------

  float HumidadeSolo = analogRead(SOIL_MOISTURE_PIN);

  // ----------- LEITURA SENSOR TEMPERATURA ----------------------

  float HumidadeAr = dht.readHumidity();
  float TemperaturaAr = dht.readTemperature();

  // ----------- LEITURA SENSOR QUALIDADE DO AR ----------------------
  
  MQ2.update();
  float QualidadeAr = MQ2.readSensor();


  Serial.println(String(HumidadeSolo) + "," + String(HumidadeAr) + "," + String(TemperaturaAr) + "," + String(QualidadeAr) + ";");
  

  delay(5000);
}