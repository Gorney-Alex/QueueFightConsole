﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFightGame
{
    internal interface IUnit
    {
        string Name { get; }
        float Health { get; set; }
        float Protection { get; }
        float Damage { get; }
        float Cost { get; }
        Team Team { get; set; }

        void Attack(IUnit target);
    }

    internal interface IWall
    {
        string Name { get; }
        float Health { get; set; }
        float Protection { get; }
    }
}
