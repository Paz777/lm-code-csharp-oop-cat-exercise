using System;
namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat() : base(1100, "wild") { }

        public override string Eat()
            => "Roar!!!!";
    }
}

