#include "Radio.h"


Radio::Radio(RunSettings *settings, Transceiver *transceiver)
{
  _rf24 = NULL;  
  _settings = settings;
  _transceiver = transceiver;
}

void Radio::startListen()
{
  _rf24 = new RF24(_settings->Hardware.RF24.CEPin, _settings->Hardware.RF24.CSPin);
  _rf24->begin();
  _rf24->openReadingPipe(0, _settings->Hardware.RF24.Address);   //Setting the address at which we will receive the data
  _rf24->setPALevel(
    _settings->Hardware.RF24.Power == Min
      ? RF24_PA_MIN : RF24_PA_MAX);       //You can set this as minimum or maximum depending on the distance between the transmitter and receiver.
  _rf24->startListening();              //This sets the module as receiver
}

bool Radio::hasMessage()
{
//  Serial.println("hasMessage()");
   return false;
}

void Radio::readMessage(byte *msg)
{
}
