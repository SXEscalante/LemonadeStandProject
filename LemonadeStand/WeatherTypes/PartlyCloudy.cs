﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.WeatherTypes
{
    internal class PartlyCloudy : WeatherType
    {
        public PartlyCloudy()
        {
            this.typeOfWeather = "partly cloudy";
            this.weatherLemonadeDesireModifier = 1.2;
            this.weatherSpawnModifier = 1.4;
            this.tempModifier = 1;
        }

        public override void WeatherEffect()
        {
            Console.WriteLine("There's a nice shade out today, what a perfect day to be outside");
        }

    }
}
