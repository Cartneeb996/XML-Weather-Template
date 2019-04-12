using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow,
            windSpeed, windDirection, precipitation, visibility, sunSet, sunRise;
        public int condVal = 0;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = sunRise = sunSet = "";
        }
    }
}
