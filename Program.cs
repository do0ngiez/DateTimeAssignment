using System;

namespace TimeCalculator{
    class Program{
        static void Main(string[] args){
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now; 
            Console.WriteLine("Current date and time: " + currentDateTime);

            // ASk input user for number of hours
            Console.WriteLine("Enter a number of hours: "); 

            // Read user input
            string userInput = Console.ReadLine();
            
            // Parse user input to int
            if (int.TryParse(userInput, out int hours)){
                // Calculate the new date and time by adding the specified number of hours
                DateTime newDateTime = currentDateTime.AddHours(hours);

                // Output the calculated future date and time
                Console.WriteLine($"The time after {hours} hour(s) will be: {newDateTime}");
            }
            else{
                Console.WriteLine("Invalid input. Enter a valid number.");
            }
        }
    }
}
