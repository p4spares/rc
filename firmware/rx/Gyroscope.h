#ifndef GYROSCOPE_H
#define GYROSCOPE_H

#include "Receiver.h"

class RunSettings;
class Receiver;

struct GyroscopeData
{
  int16_t X;
  int16_t Y;
  int16_t Z;
};

class Gyroscope
{
  private:
    RunSettings *_settings; // hardware and other settings    
    Receiver *_receiver; // our receiver    
    int _address; // device I2C address (cached from settings)
    
  public:
    Gyroscope(RunSettings *settings, Receiver *receiver);
    void initialize();
    void read(GyroscopeData *data);
  
};

#endif
