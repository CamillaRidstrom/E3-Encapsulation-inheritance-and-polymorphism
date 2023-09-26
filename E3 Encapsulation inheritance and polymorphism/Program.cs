namespace E3_Encapsulation_inheritance_and_polymorphism
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            //3.1 Inkapsling: Klar (även om den skulle kunna utvecklas)

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Svar ang privata och publika: 
            // Nej inte fälten, eller jag kommer åt den publika propertyn Age men inte det privata fältet age från klassen Person.
            // Jag kommer åt privata fält inne i klassen.  
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            try
            {
                var person1 = new Person("Sven", "Svensson", 33, 1.8, 90);
                Console.WriteLine("person1 is: " + person1.Age + " years.\n");
                var personHandler = new PersonHandler();

                Person person2 = personHandler.CreatePerson(45, "Jenny", "Andersson", 1.7, 70);
                personHandler.SetAge(person1, 41);
                Console.WriteLine("person1 is now: " + person1.Age + " years.\n");
                Console.WriteLine("person2 is: " + person2.Age + " years.\n");
            }
            catch (ArgumentException) 
            {
                Console.WriteLine("Error: Invalid property value"); // Det här är nog fel..
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //3.2 Polymorfism: Klar

            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new NoValueError(),
                //new TextInputError(), //Kan ej ha flera av samma klass?

            };

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //3.3 Arv: Klar

            //Fick mycket hjälp 
            //Dels genom att fråga Jonathan om hur man kommer åt arv uppåt = :base(name, color, power, wingSpan)
            //Dels genom att fråga Dimitris hur man i en subklass kombinerar basklass och interface = subklass: basklass, interface

            IPerson wolfman = new Wolfman("Zeke Karlsson", "Gray", 7, false);
            wolfman.Talk();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Svar: Nya attribut för fåglar bör läggas i klassen Birds
            // ..som jag skrivit i properties och i konstruktor samt blir till att ändra sen i konstruktorn för varje subklass också
            // Svar: Nya attribut för djur bör läggas i klassen Animal
            // ..som jag skrivit blir det en property och sen måste det läggas till i varje subklass konstruktor, samt subklassens subbklass. 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //Ej del av uppgiften men test för uppgift 3.3 Arv:
            /*
            Horse horse = new Horse("Kalle", "Brown", 10, 2);
            horse.DoSound();

            var dog = new Dog("Nisse", "Golden", 7, 3);
            dog.DoSound();

            var hedgehog = new Hedgehog("Kotten", "Black", 3, 100);
            hedgehog.DoSound();

            var worm = new Worm("Max", "Light brown", 1, true);
            worm.DoSound();

            var bird = new Bird("Jack", "Green", 4, 2);
            bird.DoSound();

            var wolf = new Wolf("Zeke", "Gray", 8, true);
            wolf.DoSound();

            var pelican = new Pelican("Pelle", "White", 4, 3, 3);
            pelican.DoSound();

            var flamingo = new Flamingo("Filip", "Pink", 3, 2, 15);
            flamingo.DoSound();

            var svan = new Swan("Gunde", "White", 4, 3, true);
            svan.DoSound();

            var wolfman = new Wolfman("Zeke Karlsson", "Gray", 7, false);
            wolfman.DoSound();
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //3.4 Mer polymorfism: Ej klar - pyttelite påbörjad
        }
    }
}