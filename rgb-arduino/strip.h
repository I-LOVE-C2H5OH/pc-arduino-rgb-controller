#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
 #include <avr/power.h> // Required for 16 MHz Adafruit Trinket
#endif

class Strip
{
public:

  enum class LightMode
  {
    staticLight,
    filling,
    rainbow
  };

  struct RGB
  {
    uint16_t Red = 0;
    uint16_t Green = 0;
    uint16_t Blue = 0;
  };

  Strip(uint16_t controlPin, uint16_t ledCount)
  :m_ledCount(ledCount), m_controlPin(controlPin), m_pixelColor(0)
  {
    m_pixels = new  Adafruit_NeoPixel(m_ledCount, m_controlPin, NEO_GRB + NEO_KHZ800);
    m_pixelColor = m_pixels->Color(0, 0, 0);
    // END of Trinket-specific code.
    m_pixels->clear(); 
    m_pixels->begin();
    m_pixels->show();
    m_pixels->begin(); // INITIALIZE NeoPixel strip object (REQUIRED)
  }

  uint16_t getLedCount()
  {
    return m_ledCount;
  }

  uint16_t getControlPin()
  {
    return m_controlPin;
  }

  void update(unsigned long ftime)
  {
    m_time += ftime;
    m_timeBreathing += ftime;
    switch(m_lightMode)
    {
      case LightMode::staticLight:
      break;
      case LightMode::filling:
      filling(100, m_pixelColor);
      break;
      case LightMode::rainbow:
      rainbow(10);
      break;
    }
    if(m_isBreathing)
    {
      breathing(100);
    }
    m_pixels->show();
  }

  void setState(LightMode mode)
  {
    m_lightMode = mode;
  }

  void setColor(RGB color)
  {
    m_pixelColor = m_pixels->Color(color.Red, color.Green, color.Blue);
    m_counter = 0;
  }

  void setBrightness(uint8_t bright)
  {
    m_pixels->setBrightness(bright);
  }

  void setBreathing(bool breathing)
  {
    m_isBreathing = breathing;
  }

private:
  void filling(uint8_t wait, uint32_t newColor)
  {
    if(m_time > wait)
    {
      m_time = 0;
      m_pixels->setPixelColor(m_counter, newColor);
      if(m_counter > m_ledCount)
      {
        return;
      }
      m_counter++;
    }
  }

  void rainbow(uint8_t wait) {
    uint16_t i, j;
    if(m_time > wait)
    {
        for (i = 0; i < m_pixels->numPixels(); i++) {
          m_pixels->setPixelColor(i, Wheel((i + m_counter) & 255));
        }
      m_counter++;
      m_time = 0;
    }
  }

  // Input a value 0 to 255 to get a color value.
  // The colours are a transition r - g - b - back to r.
  uint32_t Wheel(byte WheelPos) {
    WheelPos = 255 - WheelPos;
    if (WheelPos < 85) {
      return m_pixels->Color(255 - WheelPos * 3, 0, WheelPos * 3);
    }
    if (WheelPos < 170) {
      WheelPos -= 85;
      return m_pixels->Color(0, WheelPos * 3, 255 - WheelPos * 3);
    }
    WheelPos -= 170;
    return m_pixels->Color(WheelPos * 3, 255 - WheelPos * 3, 0);
  }

  void breathing(uint16_t wait) {
    if(m_timeBreathing > wait)
    {
      static int dir = 1;
      static float bright = 0;
      bright += dir;    // 5 - множитель скорости изменения

      if (bright > 255) {
        bright = 255;
        dir = -1;
      }
      if (bright < 0) {
        bright = 0;
        dir = 1;
      }
      m_timeBreathing = 0;
      m_pixels->setBrightness(bright);
    }
}
  
  LightMode m_lightMode = LightMode::filling;

  Adafruit_NeoPixel* m_pixels;
  unsigned long m_time = 0;
  unsigned long m_timeBreathing = 0;

  // текущая позиция
  byte m_counter = 0;
  uint32_t m_pixelColor = 0;
  uint16_t m_controlPin = 0;
  uint16_t m_ledCount = 0;

  bool m_isBreathing = false;
};

