using System;
using MechanicalKeyboardClass;
using KeyboardClass;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a new Keyboard");
        Console.WriteLine("Press 2 to view all of the Keyboards added");

        Console.WriteLine("How many keyboards do you want to add? ");
        var numberOfKeyboards = int.Parse(Console.ReadLine());

        var keyboardList = new List<MechanicalKeyboard>();
        for (int i = 0; i < numberOfKeyboards; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var MechanicalKeyboard = new MechanicalKeyboard();

            Console.WriteLine("Enter the type of switches the keyboard has.");
            MechanicalKeyboard.Switches = Console.ReadLine();

            Console.WriteLine("Enter the amount of heys the keyboard has.");
            MechanicalKeyboard.KeyAmount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Does the keyboard have RGBBacklight");
            MechanicalKeyboard.RGBBacklight = Console.ReadLine();


            Console.WriteLine("Press 1 to add a new Keyboard");
            Console.WriteLine("Press 2 to view all of the Keyboards added");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {

                }
                if (userInput == "2")
                {
                    Console.WriteLine(MechanicalKeyboard.Switches);
                    Console.WriteLine(MechanicalKeyboard.KeyAmount);
                    Console.WriteLine(MechanicalKeyboard.RGBBacklight);
    
                }
            }
            Console.WriteLine("Type exit to close the program");
        }
        
    }
}
       