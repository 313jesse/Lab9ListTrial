using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab9._0
{
    class Program
    {
        //private static object indexof;

        static void Main(string[] args)
        {
            List<string> students = new List<string> { "Jesse", "Chris", "Jacob", "Zac", "Demarko", "Samantha", "Christopher", "William", "Drew", "William", "Kristen", "Bj", "Patrick", "Terrell", "Terri" };

            List<string> food = new List<string> { "Pizza", "Pad Thai", "Chinese", "Jimmy Johns", "Subway", "Pizza", "Pizza", "Meatloaf", "Cheese sticks", "Cupcakes", "Pasta", "Italian", "Tacos", "Apples", "Pizza" };

            List<string> homeTown = new List<string> { "Royal Oak", "Dearborn", "Detroit", "Chicago", "New York", "Madison Heights", "Livonia", "Dearborn", "Charlevoix", "Rochester", "Troy", "West Bloomfield", "Warren", "Grand Blanc", "Beverly Hills" };

            List<string> favoriteColor = new List<string> { "Red", "Cyan", "blue", "green", "yellow", "orange", "purple", "pink", "red", "yellow", "blue", "orange", "blue", "blue", "red" };

            string userChoice;
            Console.WriteLine("Welcome to our C# class!");
            while (true)

            {
                Console.WriteLine("Would you like to Learn about a student or Add another student? (Learn/Add)");
                string learnAdd = Console.ReadLine();

                if (learnAdd.ToLower() == "learn")
                {
                    Console.WriteLine("Which student would you like to learn about? (Please type their name)");
                    string studentSelect = GetValidInput(@"^([A-Z]{1})([a-z]{2,})$", "",
                   "Please enter a name in the proper format; example \"Name\" ");
                    int x = students.IndexOf(studentSelect);

                    // check to make sure x is not -1

                   // while (true)
                    {
                        Console.WriteLine("What information would you like to know about " + studentSelect + "?");
                        Console.WriteLine("HINT: you can type things such as \"favorite food\" , \"favorite color\" , \"hometown\" or \"all\".");
                        string userSelection = Console.ReadLine();

                        if (userSelection.ToLower() == "favorite food")
                        {
                            // check the length of all lists contains x
                            Console.WriteLine(studentSelect + "likes to eat " + food[x]);
                            while (false) ; // exit the while loop
                        }
                        if (userSelection.ToLower() == "favorite color")
                        {
                            // check the length of all lists contains x
                            Console.WriteLine(studentSelect + " likes the color " + favoriteColor[x]);
                            while (false) ; // exit the while loop
                        }
                        if (userSelection.ToLower() == "hometown")
                        {
                            // check the length of all lists contains x
                            Console.WriteLine(studentSelect + " is from " + homeTown[x]);
                            while (false) ; // exit the while loop
                        }
                        if (userSelection.ToLower() == "all")
                        {
                            // check the length of all lists contains x
                            Console.WriteLine(studentSelect + " is from " + homeTown[x] + " and likes to eat " + food[x] + " and likes the color " + favoriteColor[x] + ".");
                            while (false) ;
                        }
                    }
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

                }
                else if (learnAdd.ToLower() == "add")
                {
                    Console.WriteLine("Thanks for choosing to Add another student");
                    Console.WriteLine("Please enter the name of the new student");

                    //string newStudent = GetValidName(@"^([A-Z]{1})([a-z]{1,})$", "",
                    //"Please enter a name in the proper format; example \"Name\" ");

                    // add student name
                    string studentName = Console.ReadLine();
                    while (isEmptyString(studentName))
                    {
                        Console.WriteLine("Please enter a name in the proper format; example \"Name\" ");
                        studentName = Console.ReadLine();
                    }
                    students.Add(studentName);

                    // add student town
                    Console.WriteLine("Please enter the hometown of the new student:");
                    string studentTown = Console.ReadLine();
                    while (isEmptyString(studentTown))
                    {
                        Console.WriteLine("Please enter a name in the proper format; example \"Hometown\" ");
                        studentTown = Console.ReadLine();
                    }
                    homeTown.Add(studentTown);


                    // add student food
                    Console.WriteLine("Please enter the favorite food of the new student:");
                    string studentFood = Console.ReadLine();
                    while (isEmptyString(studentFood))
                    {
                        Console.WriteLine("Please enter a name in the proper format; example \"Favorite Food\" ");
                        studentFood = Console.ReadLine();
                    }
                    food.Add(studentFood);


                    // add student favorite color
                    Console.WriteLine("Please enter the favorite color of the new student:");
                    string studentColor = Console.ReadLine();
                    while (isEmptyString(studentColor))
                    {
                        Console.WriteLine("Please enter a name in the proper format; example \"Favorite Food\" ");
                        studentColor = Console.ReadLine();
                    }
                    favoriteColor.Add(studentColor);
                }
                else
                {
                    while (false) ;
                }
                Console.WriteLine("do you want to do more? \"(y/n)\"?");
                userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "n")
                {
                    Console.WriteLine("OK, Thanks for playing!");
                    break; // exit the while loop
                }
            }



        }

        public static bool isEmptyString(string str)
        {
            if (str.Replace(" ","") == "")
                return true;
            return false;
        }

        public static string UserInputs(string name, string userMessage = "Please enter some info:", string errorMessage = "Error in input!")
        {
            Console.WriteLine(userMessage);
            ///
            string inputInfo = Console.ReadLine();


            while (!Regex.IsMatch(inputInfo, name))
            //escape sequence; so that you can do and "@" or print "quotes" ( \n \t \'' \\ )
            //the @ first turns off all escape sequences
            {
                Console.WriteLine(errorMessage);
                inputInfo = Console.ReadLine(); //loops back through the original prompt until valid input
            }


            return inputInfo;
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
                ///
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

