#include "Gyroscope.h"

float X_out, Y_out, Z_out;  // Outputs
int ADXL345 = 0x53; // The ADXL345 sensor I2C address

Gyroscope::Gyroscope(RunSettings *settings, Receiver *receiver)
{
  _settings = settings;
  _receiver = receiver;
}

void Gyroscope::initialize()
{
  _address = _settings->Hardware.Gyroscope.I2CAddress;
  
  TwoWire *i2c = _receiver->getI2C();
  //i2c->begin(); // Initiate the Wire library
  // Set ADXL345 in measuring mode
  i2c->beginTransmission(_address); // Start communicating with the device 
  i2c->write(0x2D); // Access/ talk to POWER_CTL Register - 0x2D
  // Enable measurement
  i2c->write(8); // (8dec -> 0000 1000 binary) Bit D3 High for measuring enable 
  i2c->endTransmission();
  delay(10);
}

byte buff[6];

void Gyroscope::read(GyroscopeData *data)
{
  TwoWire *i2c = &Wire;
  
  // === Read acceleromter data === //
  i2c->beginTransmission(_address);
  i2c->write(0x32); // Start with register 0x32 (ACCEL_XOUT_H)
  i2c->endTransmission(false);
  i2c->requestFrom(_address, 6, true); // Read 6 registers total, each axis value is stored in 2 registers

  for(int i=0; i<6; i++)
    buff[i] = i2c->read();
  
  data->X = *((int16_t *)(&buff[0]));
  data->Y = *((int16_t *)(&buff[2])); 
  data->Z = *((int16_t *)(&buff[4]));
  
}
