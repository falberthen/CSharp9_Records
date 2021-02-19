using System;

namespace CSharp9_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            // A new Record has been awaken
            var jediKnight = new Jedi { FirstName = "Anakin", LastName = "Skywalker" };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"{0}", jediKnight);

            // But their inner values can make them different With-expressions
            var sith = jediKnight with { FirstName = "Darth", LastName = "Vader" };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"{0}", sith);

            Console.ForegroundColor = ConsoleColor.White;

            // And become very unlike 
            Console.WriteLine(@"{0} is {1}: {2}", jediKnight.FirstName, sith.LastName, jediKnight.Equals(sith));

            // But still the same kind
            Console.WriteLine(@"They are Force Wielders: {0}", (jediKnight is ForceWielder) && (sith is ForceWielder));
            
            Console.Write(@"{0} {1} is the ", sith.FirstName, sith.LastName);
            // By just changing the name, at the end they are the same!
            sith = jediKnight with { FirstName = "Anakin", LastName = "Skywalker" };
            
            if(jediKnight == sith) // Records implement IEquatable<T> 
                Console.Write(@"{0}", jediKnight);

            Console.ReadLine();        
        }
    }
}
