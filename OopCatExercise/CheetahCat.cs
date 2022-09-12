using System;
namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(200, "wild") { }

        public override string Eat()
            => "Zzzzzzz";
    }
}

