﻿using System;
namespace OopCatExercise
{
    public class DomesticCat
    {
        public Boolean IsAsleep { get; private set; }
        public string Setting = "domestic";
        public int AverageHeight = 23;

        public DomesticCat()
        {
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
    }
}
