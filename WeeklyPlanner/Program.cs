using System;

class MyClass
{
    enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    /// <summary>
    /// Method for filling in daily tasks by the user 
    /// </summary>
    static DayOfWeek ChoiceDayOfWeek(string[][] userTasks)
    {
        Console.Write("Write the day of the week you need to record the task -> ");

        string userDayChoice = Console.ReadLine();
        DayOfWeek dayForTask;
        
        while (true)
        {
            if (Enum.TryParse(userDayChoice, true, out dayForTask))
            {
                return dayForTask;
            }

            else
            {
                Console.WriteLine("There is no such day of the week");
                Console.Write("Please repeat your entry ->");
                userDayChoice = Console.ReadLine();
                continue;
            }
        }
    }


    /// <summary>
    /// method for adding tasks for the day
    /// </summary> 
     static void AddTaskToDay(string[][] userTasks, DayOfWeek selectDay)
    {
        if (userTasks[(int)selectDay] == null) { userTasks[(int)selectDay] = new string[0]; }
        
        Console.Write($"Write a task for {selectDay} -> ");
        string userTask = Console.ReadLine();

        while (string.IsNullOrEmpty(userTask))
        {
            Console.Write("You didn't enter anything\nPlease repeat your entry ->");
            Console.ReadLine();
            continue;
        }

        int currentLength = userTasks[(int)selectDay].Length;
        string[] newTasks = new string[currentLength + 1];

        for (byte i = 0; i < currentLength; i++)
        {
            newTasks[i] = userTasks[(int)selectDay][i];
        }
        
        newTasks[currentLength] = userTask;
        userTasks[(int)selectDay] = newTasks;
        
        Console.WriteLine($"\nYour task {userTask} added to {selectDay}!");
    }
    
    /// <summary>
    /// method for removing tasks from the day
    /// </summary>
    static void RemoveTaskToDay(string[][] userTasks, DayOfWeek selectDay)
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

        string[][] userTasks = new string[sizeColumn][];

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
                    DayOfWeek selectDay = ChoiceDayOfWeek(userTasks);
                    AddTaskToDay(userTasks, selectDay);
                    break;
                }

                case "2":
                {
                    DayOfWeek selectDay = ChoiceDayOfWeek(userTasks);
                    RemoveTaskToDay(userTasks, selectDay);
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