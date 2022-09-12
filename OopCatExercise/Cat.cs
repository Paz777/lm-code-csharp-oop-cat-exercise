using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        public bool IsAsleep { get; private set; }

        public abstract string Eat();
    }
}
