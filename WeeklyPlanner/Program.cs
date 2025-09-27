using System;

class MyClass
{
    enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    /// <summary>
    /// Method for selecting a day for a user 
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
    
        while (true)
        {
            Console.Write($"\nWrite a task for {selectDay} (press Tab to finish) -> ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true); 

            if (keyInfo.Key == ConsoleKey.Tab)
            {
                Console.WriteLine(); 
                break;
            }
            
            Console.Write(keyInfo.KeyChar); 
            string userTask = keyInfo.KeyChar + Console.ReadLine(); 

            if (string.IsNullOrEmpty(userTask))
            {
                Console.WriteLine("You didn't enter anything\nPlease repeat your entry ->");
                continue;
            }

            int currentLength = userTasks[(int)selectDay].Length;
            string[] newTasks = new string[checked(currentLength + 1)];

            if (currentLength > 0)
            {
                for (int i = 0; i < currentLength; i++)
                {
                    newTasks[i] = userTasks[(int)selectDay][i];
                }
            }
    
            newTasks[currentLength] = userTask;
            userTasks[(int)selectDay] = newTasks;
    
            Console.WriteLine($"\nYour task '{userTask}' added to {selectDay}!");
        }
    }

    /// <summary>
    /// method for removing tasks from the day
    /// </summary>
    static void RemoveTaskToDay(string[][] userTasks, DayOfWeek selectDay)
    {
        if (userTasks[(int)selectDay] == null || userTasks[(int)selectDay].Length == 0)
        {
            ShowTasksForDay(userTasks, selectDay);
            return;
        }

        while (true)
        {
            ShowTasksForDay(userTasks, selectDay);

            if (userTasks[(int)selectDay].Length == 0)
            {
                Console.WriteLine($"\nNo more tasks to remove for {selectDay}!");
                return;
            }

            Console.Write($"\nEnter the number of the task to remove (1 - {userTasks[(int)selectDay].Length}, press Tab to finish) -> ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Tab)
            {
                Console.WriteLine();
                return;
            }

            Console.Write(keyInfo.KeyChar);
            string input = keyInfo.KeyChar + Console.ReadLine();
            if (!int.TryParse(input, out int taskNumber) || taskNumber < 1 ||
                taskNumber > userTasks[(int)selectDay].Length)
            {
                Console.WriteLine($"Invalid number! Enter a number between 1 and {userTasks[(int)selectDay].Length} or press Tab.");
                continue;
            }

            int index = taskNumber - 1;
            int currentLength = userTasks[(int)selectDay].Length;
            string[] newTasks = new string[checked(currentLength - 1)];

            for (int i = 0, j = 0; i < currentLength; i++)
            {
                if (i != index)
                {
                    newTasks[j] = userTasks[(int)selectDay][i];
                    j++;
                }
            }

            userTasks[(int)selectDay] = newTasks;
            Console.WriteLine($"\nTask {taskNumber} removed from {selectDay}!");
            Console.Write($"\nRemove another task for {selectDay}? (Enter to continue, Tab to finish) -> ");

            keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Tab)
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine();
        }
    }
    
    /// <summary>
    /// method for displaying the schedule for the week
    /// </summary>
    static void ShowWeeklySchedule()
    {}

    /// <summary>
    ///  method for displaying the schedule for the day
    /// </summary>
    static void ShowTasksForDay(string[][] userTasks, DayOfWeek selectDay)
    {
        if (userTasks[(int)selectDay] == null || userTasks[(int)selectDay].Length == 0)
        {
            Console.WriteLine($"There are no tasks for {selectDay}!"); return;
        }

        Console.WriteLine($"\nTasks for {selectDay}:");
        for (int i = 0; i < userTasks[(int)selectDay].Length; i++)
        {
            Console.WriteLine($"{i + 1}. {userTasks[(int)selectDay][i]}");
        }
    }
    
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