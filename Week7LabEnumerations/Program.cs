using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabEnumerations
{
    /*
Create an enumeration inside of the Program class that represents ice cream flavors(enum IceCreamFlavors) DONE
Add some flavors to your enumeration.At least five flavors. DONE
In your Main() method, ask the user what flavor ice cream they want DONE
Input the user's response into a variable of type IceCreamFlavors DONE
Create either if statements or a switch statement that compares the user's response to each member of the enumeration. DONE
Write different messages to the screen based on the comparason DONE
*/

    class Program
    {
        public enum IceCreamFlavors
        {
            chocolate, vanilla, strawberry, pecan, coffee
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What flavor of ice cream do you want?");
            Console.WriteLine("Choose from chocolate, vanilla, strawberry, pecan, and coffee.");

            IceCreamFlavors flavor;

            try
            { 

            flavor = (IceCreamFlavors)Enum.Parse(typeof(IceCreamFlavors), Console.ReadLine());

                switch (flavor)
                {
                    case IceCreamFlavors.chocolate:
                    case IceCreamFlavors.vanilla:
                        Console.WriteLine($"Ah, {flavor} is a classic! Good choice.");
                        break;

                    case IceCreamFlavors.strawberry:
                        Console.WriteLine($"Mmm, {flavor} is great on a hot day.");
                        break;

                    case IceCreamFlavors.pecan:
                        Console.WriteLine($"That {flavor} ice cream is mighty crunchy!");
                        break;

                    case IceCreamFlavors.coffee:
                        Console.WriteLine("You must have a paper to finish tonight.");
                        break;

                    /*default:
                        Console.WriteLine("Sorry, we're all out of that flavor.");
                        break;
                        I guess default doesn't work with enums? or did I just type something wrong? 
                        I added the try/catch blocks instead*/
                }
            }

            catch
            {
                Console.WriteLine("Sorry, that's not a choice. Get out of my shop!");
            }
            Console.ReadLine();
        }
    }
}
