
#include "Receiver.h"
#include <Wire.h>  // Wire library - used for I2C communication

RunSettings RXSettings;
Receiver Receiver(&RXSettings);

void setup() {

  Serial.begin(115200);
  RXSettings.initialize();

  for(int i=0; i<6; i++)
  {
    RXSettings.Settings.Servos[i].Zero = 90; // middle of 180 degrees
    RXSettings.Settings.Servos[i].MinValue = 0;
    RXSettings.Settings.Servos[i].MaxValue = 180;
    RXSettings.Settings.Servos[i].Mode = NORMAL;
    RXSettings.Settings.Servos[i].Inverted = 0;


    switch(i)
    {
      case 0:
      strcpy(RXSettings.Settings.Servos[i].Name, "A");
      RXSettings.Settings.Servos[i].Binding = JOYLEFT_X;
      RXSettings.Settings.Servos[i].Sink = SERVO_0;
      break;
      
      case 1:
      strcpy(RXSettings.Settings.Servos[i].Name, "B");
      RXSettings.Settings.Servos[i].Binding = JOYLEFT_Y;
      RXSettings.Settings.Servos[i].Sink = SERVO_1;
      break;
      
      case 2:
      strcpy(RXSettings.Settings.Servos[i].Name, "C");
      RXSettings.Settings.Servos[i].Binding = JOYRIGHT_X;
      RXSettings.Settings.Servos[i].Sink = SERVO_2;
      break;
      
      case 3:
      strcpy(RXSettings.Settings.Servos[i].Name, "D");
      RXSettings.Settings.Servos[i].Binding = JOYRIGHT_Y;
      RXSettings.Settings.Servos[i].Sink = SERVO_3;
      break;
      
      case 4:
      strcpy(RXSettings.Settings.Servos[i].Name, "E");
      RXSettings.Settings.Servos[i].Binding = DISABLED;
      RXSettings.Settings.Servos[i].Sink = ESC;
      break;
      
      case 5:
      strcpy(RXSettings.Settings.Servos[i].Name, "F");
      RXSettings.Settings.Servos[i].Binding = DISABLED;
      RXSettings.Settings.Servos[i].Sink = ESC;
      break;
    }
  }

  RXSettings.save();
  
  Receiver.initialize();

  // start the listen mode
/*
  // setup servo's pins
  servoA.attach(PA0);
  servoA.attach(PA1);
  servoA.attach(PA2);
  servoA.attach(PA3);
    
  radio.startListen();
  */
}

void loop()
{  
  //Serial.println(sizeof(ChannelSettings));
  
  // try process incoming rc messages
    switch(Receiver.processMessage())
    {
      case PROCESSED:
        break;
      case FAILSAFE:
        Receiver.failSafe();
        break;
      case AUTOLEVEL:
        Receiver.autoLevel();
        break;
    }
    
}
