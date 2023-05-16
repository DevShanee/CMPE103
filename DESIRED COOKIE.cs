//MADLANGBAYAN, SHANE S.
//BSCPE 1-1
//WELCOME TO DESIRED COOKIE AND CAFE

using System;
namespace desiredCookieAndCafe 
{
    class Program 
	{
        static void Main()
        {
            int quantity = 1;
            double total = 0;
            Console.WriteLine("Welcome to Desired Cookie and Cafe");
            Console.WriteLine("************** MENU **************");
            Console.WriteLine("C1. Chocolate Crinkle and French Vanilla          Php 210");
            Console.WriteLine("C2. White Raspberry Crinkle and Spanish Latte     Php 235");
            Console.WriteLine("C3. Strawberry Cream and Iced Americano           Php 250");
            Console.WriteLine("C4. Bavarian and Iced Latte                       Php 245");
            Console.WriteLine("C5. Tiramisu and Caramel Macchito                 Php 240");

            Console.WriteLine("Select your Order");

            string userInput = Console.ReadLine();

            if (userInput == "C1") {
                Console.WriteLine("Chocolate Crinkle and French Vanilla                 Php 210");

                Console.WriteLine("How many orders would you like? ");
                quantity = Convert.ToInt32(Console.ReadLine());
                total = quantity * 210;
                Console.WriteLine("Your total amount is Php " + total);

                Console.WriteLine("THANK YOU FOR ORDERING, PLEASE COME AGAIN! ");
            }
            if (userInput == "C2") {
                Console.WriteLine("White Raspberry Crinkle and Spanish Latte            Php 235");

                Console.WriteLine("How many orders would you like? ");
                quantity = Convert.ToInt32(Console.ReadLine());
                total = quantity * 235;
                Console.WriteLine("Your total amount is Php " + total);

                Console.WriteLine("THANK YOU FOR ORDERING, PLEASE COME AGAIN! ");
            } 
            if (userInput == "C3") {
                Console.WriteLine("Strawberry Cream Crinkle and Iced Americano          Php 250");

                Console.WriteLine("How many orders would you like? ");
                quantity = Convert.ToInt32(Console.ReadLine());
                total = quantity * 250;
                Console.WriteLine("Your total amount is " + total);

                Console.WriteLine("THANK YOU FOR ORDERING, PLEASE COME AGAIN! ");
            } 
            if (userInput == "C4") {
                Console.WriteLine("Bavarian Crinkle and Iced Latte                      Php 245");

                Console.WriteLine("How many orders would you like? ");
                quantity = Convert.ToInt32(Console.ReadLine());
                total = quantity * 245;
                Console.WriteLine("Your total amount is " + total);

                Console.WriteLine("THANK YOU FOR ORDERING, PLEASE COME AGAIN! ");
            }
            if (userInput == "C5") {
                Console.WriteLine("Tiramisu and Caramel Macchiato                       Php 240");

                Console.WriteLine("How many orders would you like? ");
                quantity = Convert.ToInt32(Console.ReadLine());
                total = quantity * 245;
                Console.WriteLine("Your total amount is " + total);

                Console.WriteLine("THANK YOU FOR ORDERING, PLEASE COME AGAIN! "); 
            }    
        }
    }

}