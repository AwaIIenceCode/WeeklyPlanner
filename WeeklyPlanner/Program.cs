using System;

class MyClass
{
    enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    /// <summary>
    /// Method for filling in daily tasks by the user 
    /// </summary>
    static void ChoiceDayOfWeek(string[][] userTasks)
    {
        Console.Write("Write the day of the week you need to record the task -> ");
        
        string userDayChoice = Console.ReadLine();
        
        if (Enum.TryParse(userDayChoice, true, out DayOfWeek dayForTask));
        {
            switch (userDayChoice)
            {
                case "0":
                    userTasks[0][];
                    break;
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    break;
            }
        }
        
        else { Console.WriteLine("There is no such day of the week"); }
    }
    
    
    /// <summary>
    /// method for adding tasks for the day
    /// </summary>
    static void AddTaskToDay()
    {}
    
    /// <summary>
    /// method for removing tasks from the day
    /// </summary>
    static void DeleteTaskToDay()
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

        ChoiceDayOfWeek(userTasks);
    }
}