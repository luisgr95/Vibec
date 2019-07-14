#include "I2Cdev.h"
#include "MPU6050.h"
#include "Wire.h"

// La dirección del MPU6050 puede ser 0x68 o 0x69, dependiendo 
// del estado de AD0. Si no se especifica, 0x68 estará implicito
MPU6050 sensor = 0x68;
MPU6050 sensor2 = 0x69;

// Valores RAW (sin procesar) del acelerometro y giroscopio en los ejes x,y,z
int ax, ay, az;
int gx, gy, gz;

int ax2, ay2, az2;
int gx2, gy2, gz2;


void setup() {
  Serial.begin(9600);    //Iniciando puerto serial
  Wire.begin();           //Iniciando I2C  
  sensor.initialize();    //Iniciando el sensor
  sensor2.initialize();
}

void loop() {
  // Leer las aceleraciones y velocidades angulares
  sensor.getAcceleration(&ax, &ay, &az);
  sensor.getRotation(&gx, &gy, &gz);
  
  sensor.getAcceleration(&ax2, &ay2, &az2);
  sensor2.getRotation(&gx2, &gy2, &gz2);

  //Mostrar las lecturas separadas por un [tab]
  Serial.print(gx); Serial.print("/");
  Serial.print(gy); Serial.print("/");
  Serial.print(gz); Serial.print("/");
  Serial.print(gx2); Serial.print("/");
  Serial.print(gy2); Serial.print("/");
  Serial.println(gz2);

  delay(100);
}
