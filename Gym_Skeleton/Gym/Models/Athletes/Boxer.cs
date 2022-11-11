﻿using Gym.Models.Athletes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Boxer : Athlete
    {
        public Boxer(string fullName, string motivation, int numberOfMedals) 
            : base(fullName, motivation, numberOfMedals, 60)
        {
        }

        public override void Exercise()
        {
            if (this.Stamina > 100)
            {
                this.Stamina = 100;
                throw new ArgumentException("Stamina cannot exceed 100 points.");
            }
            this.Stamina += 15;

        }
    }
}
