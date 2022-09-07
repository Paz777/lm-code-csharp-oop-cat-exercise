using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
        public Boolean IsAsleep { get; private set; }

        public abstract string Eat();
    }
}
