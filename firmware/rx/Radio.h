#ifndef RADIO_H
#define RADIO_H

#include <RF24.h>
#include <nRF24L01.h>
#include "RCPacket.h"
#include "RunSettings.h"
#include "Transceiver.h"

class Radio
{
  private:
    RunSettings *_settings;
    Transceiver *_transceiver;
    RF24 *_rf24;
  public:
    Radio(RunSettings *settings, Transceiver *transceiver);
    virtual void startListen();
    virtual bool hasMessage();
    virtual void readMessage(byte *msg);
};

#endif
