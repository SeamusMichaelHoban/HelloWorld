using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello World!");


            ////Part One greeting statement
            string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";

            ////Part Two set intial Spartacus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderfemale = 'F';

            ////Part three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine(5 <= 2);

            ////Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + '.');
            //Console.WriteLine("I am " + ageOne + " years old, and it's  " + isGodLikeOne + " that I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + "pounds, and I am around " + heightOne + "inches tall.");
            //Console.WriteLine("My father is {0} years old, and it is {1} that he is a godlike.", ageThree, isGodLikeOne);
            //Console.WriteLine("I am {0} years old, and it is {1} that I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);


            ////Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwolength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwolength);

            //Part 11: Conditonal exaples
            //string cityOne = "Vesuvius";
            //string cityTwo = "Nola";
            //string cityThree = "Nuceria";
            //int cityOneDistance, cityTwoDistance, cityThreeDistance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to {0}?", cityOne);
            //cityOneDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to" + cityTwo + "?");
            //cityTwoDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //cityThreeDistance = int.Parse(Console.ReadLine());

            //if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityOne);
            //}
            //if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to " + cityTwo);
            //}
            //if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityThree);

            //    Console.WriteLine("What is your rank?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age?");
            //    int age = int.Parse(Console.ReadLine());

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you are staying home.");
            //    }
            //}

            //            Console.WriteLine("What is your rank soldier?");
            //            string rank = Console.ReadLine().ToLower();

            //            Console.WriteLine("What is your age soldier?");
            //            int age = int.Parse(Console.ReadLine());

            //            Console.WriteLine("What is your job soldier?");
            //            string job = Console.ReadLine().ToLower();

            //            if ((rank == "officer") || (age <= 26))
            //            {
            //                Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //            }
            //            else if ((job == "cook") && (age >= 26))
            //            {
            //                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sorry, you are staying home.");
            //            }
            //        switch (job)
            //        {
            //            case "infantry":
            //                Console.WriteLine("You will carry a sword.");
            //                break;

            //            case "arhcer":
            //                Console.WriteLine("You will carry a bow and arrow.");
            //                break;

            //            case "supply":
            //                Console.WriteLine("You will carry pots and pans.");
            //                break;

            //            case "SPECIALIST":
            //                Console.WriteLine("You will operate the catapult.");
            //                break;

            //            default:
            //                Console.WriteLine("You will ride horseback.");
            //                break;
            //        }
            //Part twelve array examples

            string[] foodList = new string[5];
            //Console.WriteLine(foodList[0]);
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " +
            //    foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);
            //Console.WriteLine(foodList.Length);

            //string[] elaments = messageTwo.Split(' ');
            //Console.WriteLine(elaments[0]); // prints "I"
            //Console.WriteLine(elaments[1]); // prints "am"
            //Console.WriteLine(elaments[2]); // prints "Spartacus"

            //List<string> foodList = new List<string>();
            //foodList.Add("Milk");
            //foodList.Add("Fruit");
            //foodList.Add("Meat");
            //foodList.Add("Wine");
            //foodList.Add("Bread");
            // .Lenth method for Lists
            //foodList.Add("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.Remove("Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);
            //foodList.Insert(1, "Pepsi");
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4], foodList[5]);
            //foodList.RemoveAt(1);
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            // Part thirteen while loop example

            string action = " ";
            //while (action != "exit")
            //{

            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine().ToLower();
            //}
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");

            //Part fourteen for-loop examples
            //for (int i=0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

         

            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine("Enter a value for " + foodList[i]);
            //    foodAmount[i] = int.Parse(Console.ReadLine());
            //}

            int size = 5;    //Equals the max number of columns and rows
            int i, j;
            for (i = 0; i <= size; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();







        }

    }
}           
