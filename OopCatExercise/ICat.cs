using System;
namespace OopCatExercise
{
	public interface ICat
	{
        public bool IsAsleep { get; }
        public string Setting { get; }
        public int AverageHeight { get; }

        public string Eat();
        public void GoToSleep();
        public void WakeUp();
    }
}
