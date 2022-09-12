using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        public bool IsAsleep { get; private set; }
        public string Setting { get; private set; }
        public int AverageHeight { get; private set; }

        public Cat(int averageheight, string setting)
        {
            AverageHeight = averageheight;
            Setting = setting;
        }

        public abstract string Eat();

        public void GoToSleep()
            => IsAsleep = true;

        public void WakeUp()
            => IsAsleep = false;
    }
}
