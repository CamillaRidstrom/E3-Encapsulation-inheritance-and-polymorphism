using System.ComponentModel;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace E3_Encapsulation_inheritance_and_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3.1 Inkapsling: Klar (även om den skulle kunna utvecklas en hel del bättre)

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
                //new TextInputError(), //Kan ej ha flera objekt av samma klass i listan?

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
            //Console.WriteLine(dog.Stats());

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

            //3.4 Mer polymorfism: Klar

            //Some different animals
            var dog = new Dog("Nisse", "Golden", 7, 3);
            var wolfman2 = new Wolfman("Ulf Nilsson", "Dark gray", 9, true);
            var bird = new Bird("Jack", "Green", 4, 2);
            var pelican = new Pelican("Pelle", "White", 4, 3, 3);

            var dog1 = new Dog("Fido", "Brown", 5, 3);
            var dog2 = new Dog("Ludde", "White", 7, 5);
            var dog3 = new Dog("Aro", "Black", 9, 1);
            var horse1 = new Horse("Kalle", "Brown", 10, 2);


            List<Animal> animals = new List<Animal>();
            {
                animals.Add(dog);
                animals.Add(wolfman2);
                animals.Add(bird);
                animals.Add(pelican);
                animals.Add(dog1);
                animals.Add(dog2);
                animals.Add(dog3);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                if (animal is IPerson)
                {
                    IPerson iperson = (IPerson)animal;  //Type-casta
                    iperson.Talk();
                }

            }

            List<Dog> dogs = new List<Dog>();
            {
                dogs.Add(dog1);
                dogs.Add(dog2);
                dogs.Add(dog3);
                //dogs.Add(horse1);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Fråga "9" - svar: Det skulle resultera i fel, eftersom de är olika egendefinerade typer tror jag..
            // 
            // Fråga "10" - svar: En lista av en överordnad basklass eller överordnat interface
            // 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // 11 Skriv ut samtliga Animal Stats () genom foreach loop. Redan gjort i steg 5. Eller?

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Fråga "13" - svar: För varje instans av ett djur som finns i listan animals,   
            // anropas just den subklassens metod för att skriva ut egenskaper (Stats)
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    //Dog hund = (Dog)animal;  //Type-casta, typomvandla
                    Dog hund = animal as Dog;  //Annat sätt att casta
                    Console.WriteLine(hund.Stats());
                    Console.WriteLine(hund.ToiletBreak());
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Fråga "16" - svar: Ja se ovan. Men förstår på nästa fråga att jag ju inte kommer åt den direkt utan att typomvandla.    
                // Fråga "17" - svar: Eftersom basklassen Animal inte har definierat metoden som obligatorisk eller ja den har den inte alls. 
                // Annars hämtar den ju den mest specialiserade metoden för den subklassen, men inte om det 'r en helt egen metod. 
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                // 18 Hitta en sätt att skriva ut din nya metod för dog genom en foreach på Animal.
                // Redan gjort här ovan.

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                /*
                 
                Kommentar: 
                !? Jag har inte riktigt fått till detta med Exceptions i 3.1 på rätt sätt ser jag.. 
                !? Och jag har även varningar om fel i defaultvärden som jag är osäker på hur jag bäst löser? 
                
                Dumt att jag inte började med denna övning tidigare.
                Tänkte att jag behövde kunna mer grunder för att hitta rätt syntax inann jag startade.  
                Alla mina commits är ju efter deadline tyvärr. 
                Men nu har jag lite mer konkret erfarenhet tack vare bra delövningar.
                
                Tycker ändå att det går framåt. 
                Sen tar det ju tid och mycket mer kodande att förstå mer på djupet hur allt hänger ihop.
                Hög tid att börja med Övning 4 idag onsdag! 

                Mvh / Camilla
          
                */
            }
        }

    }
}