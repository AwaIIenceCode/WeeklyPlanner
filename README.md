# Weekly Planner

A console-based task planner built in C# to manage weekly tasks using enums and jagged arrays. This project is my final pre-OOP work, showcasing my skills in procedural programming before diving into object-oriented programming.

## 📖 About

Weekly Planner lets you:
- Add tasks for any day of the week (Monday–Sunday).
- Remove tasks by selecting their number.
- View your full weekly schedule or tasks for a specific day.
- Exit the program with a simple command.

Built as a learning project to master enums, jagged arrays, and user input handling in C#. It's a stepping stone to OOP, with clean code principles (like SRP from SOLID) in mind.

## 🚀 Features
- **Task Management**: Add or remove tasks for any day using a simple console interface.
- **Enum-Based Days**: Uses `DayOfWeek` enum for robust day selection.
- **Jagged Arrays**: Stores tasks efficiently in a `string[][]` structure.
- **User-Friendly UX**: Tab to exit, clear prompts, and input validation.
- **Clean Code**: Modular methods with single responsibilities (e.g., `ShowTasksForDay`, `AddTaskToDay`).

## 🛠️ How It Works
1. Run the program and see the welcome message.
2. Choose an action from the menu:
   - `1`: Add tasks for a chosen day (multiple tasks possible until Tab is pressed).
   - `2`: Remove tasks from a chosen day (select by number, multiple removals until Tab is pressed).
   - `3`: View the weekly schedule (shows tasks for all days).
   - `Exit`: Quit the program.
3. Follow prompts to manage tasks with intuitive inputs (e.g., Tab to finish adding/removing).

## 📋 Example Usage
Welcome to your weekly planner!
In this planner, you can write down the day of the week on which you need to add or remove tasks.
You can also print out your full schedule for the week.

Press "1" - for add task
Press "2" - for remove task
Press "3" - for showing task
Write "Exit" for exit the program

Enter your choice -> 1

Write the day of the week you need to record the task -> Monday

Write a task for Monday (press Tab to finish) -> Code

Your task 'Code' added to Monday!

Write a task for Monday (press Tab to finish) -> Debug

Your task 'Debug' added to Monday!

Write a task for Monday (press Tab to finish) -> [Tab pressed to finish]

Enter your choice -> 1

Write the day of the week you need to record the task -> Tuesday

Write a task for Tuesday (press Tab to finish) -> Visit mom

Your task 'Visit mom' added to Tuesday!

Write a task for Tuesday (press Tab to finish) -> [Tab pressed to finish]

Enter your choice -> 3

Tasks for Monday:

1. Code
2. Debug

Tasks for Tuesday:
1.Visit mom

Tasks for Wednesday:
1.Feed spider

(If no tasks in a day, it skips that day. If no tasks at all, shows "No tasks scheduled for the week!")

## 💻 Installation
1. Clone the repository:
   ```bash git clone https://github.com/AwaIIenceCode/WeeklyPlanner.git```
2. Open in your favorite IDE (e.g., Rider, Visual Studio).
3. Run the program in a C# environment (.NET Core or later).

##Work example
<img width="966" height="687" alt="image" src="https://github.com/user-attachments/assets/db15a789-e9e8-40c1-925d-5923e4045a64" />
