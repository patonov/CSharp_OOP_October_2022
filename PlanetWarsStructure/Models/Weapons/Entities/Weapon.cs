﻿using PlanetWars.Models.Weapons.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetWars.Models.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private int destructionLevel;
        private double price;

        public Weapon(int destructionLevel, double price)
        {
            this.DestructionLevel = destructionLevel;
            this.Price = price;
        }

        public double Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }

        public int DestructionLevel
        {
            get => this.destructionLevel;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Destruction level cannot be zero or negative.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Destruction level cannot exceed 10 power points.");
                }
                this.destructionLevel = value;
            }
        }
    }
}
