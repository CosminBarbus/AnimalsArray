using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsArray
{
    class Program
    {
        
        
// Code review: 
// 1. This is procedural programming and not OOP. Expectation is to have a class that encapsulates the animal behaviour of making a sound
// 2. Do not mix naming methods in English and Romanian
// 3. Code cannot be reuse. In case I want to reuse the logic into a web application it means that I should re-write the whole application. Use file per class.
        public void Add(Dictionary<string, string> Animals)
        {
            Animals.Add("Pisica", "Miau");
            Animals.Add("Caine", "Ham");
            Animals.Add("Leu", "Raww");

        }

        public void Afisare(Dictionary<string, string> Animals)
        {

            foreach(var animal in Animals )
            {
                Console.WriteLine(animal.Key + " " + animal.Value);
            }
        }
        static void Main(string[] args)
        {
            // 1. initialization of objects should be placed inside of an constructor
            // 2. breaks the encapsulation OOP principle
            Dictionary<string, string> AnimalArray = new Dictionary<string, string>();
            Program anim = new Program();
            anim.Add(AnimalArray);
            anim.Afisare(AnimalArray);
        }
    }
}
