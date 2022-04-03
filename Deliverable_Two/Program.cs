using System;


namespace DeliverableTwo
{
    class DeliverableTwo
    {
        static void Main(string[] args)
        {
            decimal numPeople = 0.00m;
            string response;
            int waterCount = 0;
            int coffeeCount = 0;


            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! " +
                "We only charge extra for coffee. How many people are in your group?" +
                " Please, parties of 6 or lower.");
            numPeople = int.Parse(Console.ReadLine());

            if (numPeople > 6)
            {
                Console.WriteLine("Get out.");
                return;
            }

            Console.WriteLine("A table for " + numPeople + "! Please follow me and take" +
                "a seat. Let's get everyone started with some drinks. We've got water or coffee. \n");

            for (int i = 1; i <= numPeople; i++)
            {

                Console.WriteLine("Alright, person number" + i + ", water or coffee?");

                response = Console.ReadLine().ToLower(); // so reults won't be case sensistive.

                if (response == "water")
                {
                    Console.WriteLine("Water, good choice.");
                    ++waterCount;
                }
                else if (response == "coffee")
                {
                    Console.WriteLine("Coffee, okay!");
                    ++coffeeCount;
                }
                else
                    Console.WriteLine("We don't serve that and you won't be getting a drink.");
            }

            Console.WriteLine("Okay, so that's " + waterCount + " coffees and " + coffeeCount + " waters. I'll be right back. Feel free to grab your food!");
            Console.WriteLine("Here's your bill! Total price: $" + (numPeople * 9.99m + coffeeCount * 2));

        }
    }
}