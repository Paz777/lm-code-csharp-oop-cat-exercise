using System;
namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base (23, "domestic") { }

        public override string Eat()
            => new Random().Next(2) == 1 ? "Purrrrrrr" : "Purrrrrrr It will do I suppose";
    }
}

