﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicSurvivalProbability
{
    public enum SocialClass
    {
        First,
        Second,
        Third
    }

    public enum Gender
    {
        female,
        male
    }

    public class Passenger
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public SocialClass Class { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double Fair { get; set; }
        public int SurvivalProbability { get; set; }
    }
}
