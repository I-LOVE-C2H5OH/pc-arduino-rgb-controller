#include "strip.h"
#include <EEPROM.h>

#define PIN 6 // On Trinket or Gemma, suggest changing this to 1

#define NUMPIXELS 44

Strip* strips[4]; // количество лент ставим 3

unsigned long timeWork = 0;

String inString = "";

void setup() {
  // These lines are specifically to support the Adafruit Trinket 5V 16 MHz.
  // Any other board, you can remove this part (but no harm leaving it):
#if defined(__AVR_ATtiny85__) && (F_CPU == 16000000)
  clock_prescale_set(clock_div_1);
#endif
  Serial.begin(9600);
  strips[0] = new Strip(PIN, NUMPIXELS);
  strips[1] = new Strip(5, NUMPIXELS);
  strips[0]->setState(Strip::LightMode::rainbow);
  strips[1]->setState(Strip::LightMode::rainbow);
  Strip::RGB newColor;
  newColor.Red = 170;
  newColor.Blue = 255;
  newColor.Green = 50;
  strips[0]->setColor(newColor);
}

void loop() {
  auto ftime = millis() - timeWork;

  timeWork = millis();

  // Глобальный цикл по всем не нулевым лентам.
  for (auto const& strip : strips)
  {
     if (Serial.available() > 0)
      {
        break;
      }
    if(strip)
    {
      strip->update(ftime);
    }
  }

  //Принимаемые данные:

    while (Serial.available() > 0) {
    int inChar = Serial.read();
    if (inChar) {
      // convert the incoming byte to a char and add it to the string:
      inString += (char)inChar;
    }
    // if you get a newline, print the string, then the string's value:
    if (inChar == '\n') 
    {
      bool allReady = false;
      uint16_t readCommand[7];
      uint16_t currentCommand = 0;
      String tmpStr = "";
      for(int i = 0; i < inString.length(); i++)
      {
        if(inString[i] != ',')
        {
          tmpStr+=inString[i];
        }
        else
        {
          readCommand[currentCommand] = tmpStr.toInt();
          currentCommand++;
          if(currentCommand == 6)
          {
            allReady = true;
          }
          tmpStr="";
        }
      }
      inString = "";
      if(!allReady) {continue;}
      // 0,1,255,0,0,255,0
      uint16_t readline(readCommand[0]);
      uint16_t readmode(readCommand[1]);
      uint16_t readred = readCommand[2];
      uint16_t readgreen = readCommand[3];
      uint16_t readblue = readCommand[4];
      uint16_t readbrightness = readCommand[5];
      uint16_t readbreathing = readCommand[6];
      bool isBreathing = false;
      Strip::LightMode lightMode = Strip::LightMode::staticLight;
      switch(readmode)
      {
        case 0:
        lightMode = Strip::LightMode::staticLight;
        break;
        case 1:
        lightMode = Strip::LightMode::filling;
        break;
        case 2:
        lightMode = Strip::LightMode::rainbow;
        break;
      }
      Strip::RGB newColor;
      newColor.Red = readred;
      newColor.Blue = readblue;
      newColor.Green = readgreen;
      if(auto const& strip = strips[readline])
      {
        strip->setBrightness(readbrightness);
        strip->setBreathing(isBreathing);
        strip->setColor(newColor);
        strip->setState(lightMode);
      }
      Serial.println("ok");
    }
  }
}

  void save()
  {
    //Save new configuration to EEPROM
    // 0 - stripCount os not null
    byte notzeroStrips = 0;
    for (auto const& strip : strips)
    {
      if(strip)
      {

      }
    }
  }
