using System;
namespace desiredCookieAndCafe
{

    class Program
    {
        static void Main(string[] args)
        {
            int quantity, userInput, total;
            bool orderingSystem = true;

            while (orderingSystem)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Desired Cookie and Cafe");
                Console.WriteLine("************** MENU **************");
                Console.WriteLine("1. Chocolate Crinkle and French Vanilla          Php 210");
                Console.WriteLine("2. White Raspberry Crinkle and Spanish Latte     Php 235");
                Console.WriteLine("3. Strawberry Cream and Iced Americano           Php 250");
                Console.WriteLine("4. Bavarian and Iced Latte                       Php 245");
                Console.WriteLine("5. Tiramisu and Caramel Macchiato                Php 240");
                Console.WriteLine();
                Console.Write("Select your Order: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {

                    var oneInput = new List<string>()
                    { "************************************",
                        "Chocolate Crinkle and French Vanilla",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    chocoCrinklesBill();
                }
                else if (userInput == 2)
                {
                    var oneInput = new List<string>()
                    { "************************************",
                        "White Raspberry Crinkle and Spanish Latte",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    raspberryLatteBill();


                }

                else if (userInput == 3)
                {
                    var oneInput = new List<string>()
                    { "************************************",
                        "Strawberry Cream Crinkle and Iced Americano",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    strawberryCreamIcedAmericanoBill();
                }
                else if (userInput == 4)
                {
                    var oneInput = new List<string>()
                    { "************************************",
                        "Bavarian Crinkle and Iced Latte",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    barvarianIcedteabBill();
                }
                else if (userInput == 5)
                {
                    var oneInput = new List<string>()
                    { "************************************",
                        "Tiramisu and Caramel Macchiato",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    tiramisuMacchiatoBill();

                }



            }


        }
        static void chocoCrinklesBill()
        {

            Console.Write("Type the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total = quantity * 210;
            Console.WriteLine();
            Console.WriteLine("Your total amount is Php " + total + ".00");
            Console.WriteLine();

        }
        static void raspberryLatteBill()
        {

            Console.Write("Type the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total = quantity * 235;
            Console.WriteLine();
            Console.WriteLine("Your total amount is Php " + total + ".00");
            Console.WriteLine();

        }
        static void strawberryCreamIcedAmericanoBill()
        {

            Console.Write("Type the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total = quantity * 250;
            Console.WriteLine();
            Console.WriteLine("Your total amount is Php " + total + ".00");
            Console.WriteLine();

        }
        static void barvarianIcedteabBill()
        {

            Console.Write("Type the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total = quantity * 245;
            Console.WriteLine();
            Console.WriteLine("Your total amount is Php " + total + ".00");
            Console.WriteLine();

        }

        static void tiramisuMacchiatoBill()
        {

            Console.Write("Type the quantity of your order: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int total = quantity * 240;
            Console.WriteLine();
            Console.WriteLine("Your total amount is Php " + total + ".00");
            Console.WriteLine();

        }



    }
}


