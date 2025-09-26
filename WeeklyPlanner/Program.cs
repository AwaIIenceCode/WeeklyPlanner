using System;

class MyClass
{
    enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    /// <summary>
    /// Method for filling in daily tasks by the user 
    /// </summary>
    static void ChoiceDayOfWeek()
    {
        Console.Write("Write the day of the week you need to record the task -> ");

        string userDayChoice = Console.ReadLine();

        while (true)
        {
            if (Enum.TryParse(userDayChoice, true, out DayOfWeek dayForTask))
            {
                AddTaskToDay();
                break;
            }

            else { Console.WriteLine("There is no such day of the week"); continue; }
        }
      
    }
    
    
    /// <summary>
    /// method for adding tasks for the day
    /// </summary>
    static void AddTaskToDay()
    {}
    
    /// <summary>
    /// method for removing tasks from the day
    /// </summary>
    static void RemoveTaskToDay()
    {}
    
    /// <summary>
    /// method for displaying the schedule for the week
    /// </summary>
    static void ShowWeeklySchedule()
    {}

    static void Main()
    {
        Console.WriteLine("Welcome to your weekly planner!" +
                          "\tIn this planner, you can write down the day of the week on which you need to add or remove tasks." +
                          "\nYou can also print out your full schedule for the week.");

        const byte sizeColumn = 7;
        byte sizeLine;

        string[][] userTasks = new string[sizeColumn][];

        ChoiceDayOfWeek();

        while (true)
        {
            Console.WriteLine("\nPress \"1\" - for add task" +
                              "\nPress \"2\" - for remove task" +
                              "\nPress \"3\" - for showing task" +
                              "\nWrite \"Exit\" for exit the program");

            Console.Write("\nEnter your choice ->");
            string userChoice = Console.ReadLine()?.ToLower();

            switch (userChoice)
            {
                case "1":
                {
                    ChoiceDayOfWeek();
                    break;
                }

                case "2":
                {
                    RemoveTaskToDay();
                    break;
                }

                case "3":
                {
                    ShowWeeklySchedule();
                    break;
                }
                
                case "exit":
                {
                    return;
                }

                default:
                    Console.WriteLine("Try again..."); break;
            }
        }
    }
}