﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }
}
