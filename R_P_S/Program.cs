using System;
using System.Runtime.InteropServices;

namespace Rock_Paper_Scissors
{
   class Program
   {

      static int UserChoice()
      {
         int U_choice;
         Console.Write("Your choice: ");
         U_choice = Convert.ToInt32(Console.ReadLine());

         while(U_choice > 3 || U_choice < 1)
         {
            Console.WriteLine("\nEnter a valid value.");
            Console.Write("Your choice: ");
            U_choice = Convert.ToInt32(Console.ReadLine());
         }
         
         return U_choice;
      }

      static int ComputerChoice()
      {
         int C_choice;
         Random random = new Random();
         C_choice = random.Next(1, 4);

         return C_choice;
      }

      static void Menu()
      {
         Console.WriteLine("\n1. Rock \n2. Paper \n3. Scissors ");
         // UserChoice();
         // ComputerChoice();
      }
      static void StartGame()
      {
         Menu();
         int userChoice = UserChoice();
         int computerChoice = ComputerChoice();

         if(userChoice == 1)
         {
            if(computerChoice == 1)
            {
               Console.WriteLine("Your choice: Rock. \nComputer choice: Rock.");
               Console.WriteLine("Conclusion: Draw.");
            }
            else if(computerChoice == 2)
            {
               Console.WriteLine("\nResults: \nYour choice: Rock. \nComputer choice: Paper.");
               Console.WriteLine("Conclusion: Computer wins.");
            }
            else
            {
               Console.WriteLine("\nResults: \nYour choice: Rock. \nComputer choice: Scissors.");
               Console.WriteLine("Conclusion: You win.");
            }
         }
         else if(userChoice == 2)
         {
            if(computerChoice == 1)
            {
               Console.WriteLine("\nResults: \nYour choice: Paper. \nComputer choice: Rock.");
               Console.WriteLine("Conclusion: You win.");
            }
            else if(computerChoice == 2)
            {
               Console.WriteLine("\nResults: \nYour choice: Paper. \nComputer choice: Paper.");
               Console.WriteLine("Conclusion: Draw.");
            }
            else
            {
               Console.WriteLine("\nResults: \nYour choice: Paper. \nComputer choice: Scissors.");
               Console.WriteLine("Conclusion: Computer wins.");
            }
         }
         else if(userChoice == 3)
         {
            if(computerChoice == 3)
            {
               Console.WriteLine("\nResults: \nYour choice: Scissors. \nComputer choice: Rock.");
               Console.WriteLine("Conclusion: Computer wins.");
            }
            else if(computerChoice == 2)
            {
               Console.WriteLine("\nResults: \nYour choice: Scissors. \nComputer choice: Paper.");
               Console.WriteLine("Conclusion: You win.");
            }
            else
            {
               Console.WriteLine("\nResults: \nYour choice: Scissors. \nComputer choice: Scissors.");
               Console.WriteLine("Conclusion: Draw.");
            }
         }
         else
         {
            Console.WriteLine("An error occured. Please, restart");
         }
      }
      static void Main(string[] args)
      {
         int option;

         do
         {
            StartGame();
            
            Console.WriteLine("\n1 for again. 0 for exit.");
            Console.Write("Option: ");
            option = Convert.ToInt32(Console.ReadLine());
         }while(option == 1);
      }
   }
}