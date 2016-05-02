using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namesoace creation
namespace Calculator
{
    class MyCalculator
    {
        int operand1=0;
        int operand2=0;
        int choice=0;
        int result1=0;
        int result2=0;

        public int userInput()
        {
            Console.Write("Enter first number Dinesh: ");
            string firstNumber=Console.ReadLine();
            Console.Write("Enter Second number : ");
            string SecondNumber = Console.ReadLine();

            operand1 = int.Parse(firstNumber);
            operand2 = int.Parse(SecondNumber);

            return 1;
        }
        //Receive the user choice of what to do with the numbers
        public int userChoice()
        {
            Console.WriteLine("\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\n");
            Console.Write("Please Enter Your Choice : ");

            string choiceNumber = Console.ReadLine();
            choice = int.Parse(choiceNumber);

            if (choice == 1)
            {
                Addition();
                userChoice();
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                Subtraction();
                userChoice();
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                Multiplication();
                userChoice();
                Console.ReadLine();
            }
            else if (choice == 4)
            {
                Division();
                userChoice();
                Console.ReadLine();
            }
            else if (choice == 5)
            {
                System.Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine("Invalid Choice, Exiting the code");
                Console.WriteLine("Press any key........");
                System.Environment.Exit(-1);
            }
            return 1;
        }
       
            public int Addition()
            {
                 try
                {
                    result1 = operand1 + operand2;
                    Console.WriteLine("The sum is " + result1);
                    //result1 = 0;                    
                }
        
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                 return result1;
            }

        public int Subtraction()
        {
            try
            {
                result1 = operand1 - operand2;
                Console.WriteLine("The difference is " + result1);
                //result1 = 0;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            return result1;
        }

        public int Multiplication()
        {
            try
            {
                result1 = operand1 * operand2;
                Console.WriteLine("The product is " + result1);
               // result1 = 0;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            return result1;
        }

        public int Division()
        {
            try
            {
                result1 = operand1 / operand2;
                result2 = operand1 % operand2;
                Console.WriteLine("The quotient is " + result1);
                Console.WriteLine("The reminder is " + result2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
            }
            return result1;
        }
    }
}
