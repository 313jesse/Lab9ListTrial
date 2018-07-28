using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab9._0
{
    class Program
    {
        //private static object indexof;

        static void Main(string[] args)
        {

            string userChoice;
            Console.WriteLine("Welcome to our C# class!");
            while (true)

            {
                List<string> students = new List<string>
                {
                    "Jesse","Chris","Jacob","Zac","Demarko","Samantha","Christopher", "William","Drew","William","Kristen","Bj","Patrick","Terrell","Terri"                     
                 };   
                                                                                                                                                                                                                 
                List<string> food = new List<string> { "Pizza", "Pad Thai", "Chinese", "Jimmy Johns", "Subway", "Pizza", "Pizza", "Meatloaf", "Cheese sticks", "Cupcakes", "Pasta", "Italian", "Tacos", "Apples", "Pizza", "Pizza" };

               List<string> homeTown = new List<string> { "Royal Oak", "Dearborn", "Detroit", "Chicago", "New York", "Madison Heights", "Livonia", "Dearborn", "Charlevoix", "Rochester", "Troy", "West Bloomfield", "Warren", "Grand Blanc", "Beverly Hills", "Grand Haven" };

                List<string> favoriteColor = new List<string> { "Red", "Cyan", "blue", "green", "yellow", "orange", "purple", "pink", "red", "yellow", "blue", "orange" };

              
                Console.WriteLine("Would you like to [L]Learn about a student or [A] Add another student? (L/A)");
               string learnAdd = Console.ReadLine();

                if (learnAdd.ToLower() == "l")
                {
                 Console.WriteLine("Which student would you like to learn about? (Please type their name)");
                string studentSelect = GetValidInput(@"^([A-Z]{1})([a-z]{2,})$", "",
               "Please enter a name in the proper format; example \"Name\" ");
                int x = students.IndexOf(studentSelect);

                    // offer available information about the student

            Console.WriteLine(studentSelect + " is from " + homeTown[x] + " and likes to eat " + food[x]); 
                }
                if (learnAdd.ToLower() == "a")
                {
                    Console.WriteLine("Thanks for choosing to Add another student");
                    Console.WriteLine("Please enter the name of the new student");

                    string newStudent = GetValidName(@"^([A-Z]{1})([a-z]{2,})$", "",
              "Please enter a name in the proper format; example \"Name\" ");
                    string nS = Console.ReadLine();
                    students.Add(nS);
                    Console.WriteLine(students.Count -1);
                    
                   
                        
                    //List<string> students = new List<string>
                    //code to add new student to list
                }
            
               

                //  int x = (Array.IndexOf(students, studentSelect));

                //  Console.WriteLine(studentSelect + " is from " + hometown[x] + " and likes to eat " + food[x]);

                //:::::::::::::prints array of students

                //////////Console.WriteLine("Would you like to see a list of the students in class? (y/n)?");
                //////////string displayList = Console.ReadLine();
                //////////if (displayList.ToLower() == "y")
                //////////{
                //////////    Console.WriteLine("Here's a list of the current students:");
                //////////    foreach (string s in students)
                //////////    {
                //////////        Console.WriteLine(s + " ");
                //////////    }
                //////////}
                //////////else
                //////////{
                //////////    Console.WriteLine("Ok then.");
                //////////    break;
                //////////}



                Console.WriteLine("do you want to do more? \"(y/n)\"?");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "n")
                {
                    Console.WriteLine("OK, Thanks for playing!");
                    break; // exit the while loop
                }
            }

        }
        public static string GetValidInput(string pattern, string userMessage = "Please enter a valid input:", string errorMessage = "Error in input!")
        {
            Console.WriteLine(userMessage);
            string userInput = Console.ReadLine();


            while (!Regex.IsMatch(userInput, pattern))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine(errorMessage);
                userInput = Console.ReadLine(); //loops back through the original prompt until valid input
            }
            

            return userInput;
        }
        public static string GetValidName(string name, string userMessage = "Please enter a valid name:", string errorMessage = "Error in input!")
        {
            Console.WriteLine(userMessage);
            string newStudent = Console.ReadLine();


            while (!Regex.IsMatch(newStudent, name))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine(errorMessage);
                newStudent = Console.ReadLine(); //loops back through the original prompt until valid input
            }


            return newStudent;
        }







    }
}

