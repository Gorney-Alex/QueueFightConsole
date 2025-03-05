﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFightGame
{
    internal class WeakFighter : BaseUnit, ICanBeHealed
    {
        public WeakFighter() : base("WeakFighter", 100f, 0.8f, 25) { }
    }
}
