using System;

class Program
{
  static void Main(string[] args)
  {
    int points = 0;
    string scoreMsg = (points == 1) ? $"You have {points} point" : $"You have {points} points";
    Console.WriteLine($"{scoreMsg}");
    int mainMenuOp = 0;
    int goalMenuOp = 0;
    Prompt prompts = new Prompt();
    string goalName;
    string goalDescription;
    int goalPoints;
    List<string> userIn = new List<string>();
    List<Goal> goalsList = new List<Goal>();
    do
    {
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Create New Goal");
      Console.WriteLine("2. List Goals");
      Console.WriteLine("3. Save Goals");
      Console.WriteLine("4. Load Goals");
      Console.WriteLine("5. Record Event");
      Console.WriteLine("6 Quit");
      Console.Write("Select a choice from the menu: ");
      mainMenuOp = int.Parse(Console.ReadLine());
      Console.Clear(); // TODO PENDIENTE DE ELIMINAR ESTE CONSOLELOG LUEGO DE LAS PRUEBAS


      switch (mainMenuOp)
      {
        case 1:
          Console.WriteLine($"{scoreMsg}");
          do
          {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Go to the Main Menu");
            Console.Write("What is the type of goal would you like to create?: ");
            goalMenuOp = int.Parse(Console.ReadLine());
            Console.Clear(); // TODO PENDIENTE DE ELIMINAR ESTE CONSOLELOG LUEGO DE LAS PRUEBAS
            if (goalMenuOp != 4)
            {
              switch (goalMenuOp)
              {
                case 1:
                  userIn = prompts.DisplayPrompt();
                  goalName = userIn[0];
                  goalDescription = userIn[1];
                  goalPoints = int.Parse(userIn[2]);
                  SimpleGoal sgoal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                  goalsList.Add(sgoal1);
                  break;
                case 2:
                  userIn = prompts.DisplayPrompt();
                  goalName = userIn[0];
                  goalDescription = userIn[1];
                  goalPoints = int.Parse(userIn[2]);
                  EternalGoal egoal1 = new EternalGoal(goalName, goalDescription, goalPoints);
                  goalsList.Add(egoal1);
                  break;
                case 3:
                  Console.WriteLine("Checklist Goal");
                  break;
                default:
                  Console.WriteLine("Invalid option");
                  break;
              }
            }
          } while (goalMenuOp != 4);
          break;
        case 2:
          Console.WriteLine("The goals are:");
          int i = 1;
          foreach (Goal goal in goalsList)
          {
            Console.Write($"{i}. ");
            goal.DisplayGoal();
            i++;
          }
          break;
        case 3:
          Console.WriteLine("Save Goals into a file");
          Console.Write("What is the filename for the goal file?: ");
          string filename = Console.ReadLine();
          break;
        case 4:
          Console.WriteLine("Load Goals");
          Console.Write("What is the filename of the goal file?: ");
          break;
        case 5:
          Console.WriteLine("Record Event");
          break;
      }


    } while (mainMenuOp != 6);
    Console.WriteLine("Come back soon!!");

  }
}