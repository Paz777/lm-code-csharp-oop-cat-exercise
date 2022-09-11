using System;
namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public Boolean IsAsleep { get; private set; }
        public string Setting = "domestic";
        public int AverageHeight = 23;

        public DomesticCat() { }

        public void GoToSleep()
            => IsAsleep = true;

        public void WakeUp()
            => IsAsleep = false;

        public override string Eat()
            => new Random().Next(2) == 1 ? "Purrrrrrr" : "Purrrrrrr  It will do I suppose";
    }
}

