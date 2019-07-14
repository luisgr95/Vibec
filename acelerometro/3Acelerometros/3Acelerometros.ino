//EL IMANOL ES UN CRACK
#include "I2Cdev.h"
#include "MPU6050.h"
#include "Wire.h"
 
MPU6050 sensor;

const int MPU_ADDR = 0x68;
const int MPU_ADDR2 = 0x69;
int gx, gy, gz;

int16_t accelerometer_x, accelerometer_y, accelerometer_z;
int16_t accelerometer_x2, accelerometer_y2, accelerometer_z2;

int16_t gyro_x, gyro_y, gyro_z; 
int16_t gyro_x2, gyro_y2, gyro_z2;

int16_t temperature; 
char tmp_str[7]; 
char* convert_int16_to_str(int16_t i) { 
  sprintf(tmp_str, "%6d", i);
  return tmp_str;
}
void setup() {
  Serial.begin(9600);
  Wire.begin();
  sensor.initialize();
  
  Wire.beginTransmission(MPU_ADDR); 
  Wire.write(0x6B); 
  Wire.write(0); 
  Wire.endTransmission(true);
  //delay(5);
    Wire.beginTransmission(MPU_ADDR2); 
  Wire.write(0x6B); 
  Wire.write(0); 
  Wire.endTransmission(true);
  //delay(5);
}
void loop() {
  Wire.beginTransmission(MPU_ADDR);
  Wire.write(0x3B); 
  Wire.endTransmission(false);
  Wire.requestFrom(MPU_ADDR, 7*2, true); 
  
  // "Wire.read()<<8 | Wire.read();" means two registers are read and stored in the same variable
  accelerometer_x = Wire.read()<<6 | Wire.read(); 
  accelerometer_y = Wire.read()<<6 | Wire.read(); 
  accelerometer_z = Wire.read()<<6 | Wire.read(); 
  Serial.print(" x1-->");Serial.print(convert_int16_to_str(accelerometer_x));
  Serial.print(" ,y1-->");Serial.print(convert_int16_to_str(accelerometer_y));
  Serial.print(" ,z1-->");Serial.print(convert_int16_to_str(accelerometer_z));
  Serial.print(" / ");
      //delay(2);

       Wire.beginTransmission(MPU_ADDR2);
  Wire.write(0x3B); 
  Wire.endTransmission(false);
  Wire.requestFrom(MPU_ADDR2, 7*2, true); 
  
  // "Wire.read()<<8 | Wire.read();" means two registers are read and stored in the same variable
  accelerometer_x2 = Wire.read()<<6 | Wire.read(); 
  accelerometer_y2 = Wire.read()<<6 | Wire.read(); 
  accelerometer_z2 = Wire.read()<<6 | Wire.read(); 
  Serial.print("x2-->");Serial.print(convert_int16_to_str(accelerometer_x2));
  Serial.print(" ,y2-->");Serial.print(convert_int16_to_str(accelerometer_y2));
  Serial.print(" ,z2-->");Serial.print(convert_int16_to_str(accelerometer_z2));
  Serial.print(" / ");
  //sensor.getAcceleration(&ax, &ay, &az);
  sensor.getRotation(&gx, &gy, &gz);
  Serial.print(" / x3--> "); Serial.print(gx); Serial.print("\t");
  Serial.print(" ,y3--> "); Serial.print(gy); Serial.print("\t");
  Serial.print(" ,z3--> "); Serial.println(gz);
    
  delay(1000);
}
