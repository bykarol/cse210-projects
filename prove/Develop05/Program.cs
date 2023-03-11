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
    string goalName;
    string goalDescription;
    int goalPoints;
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
                  SimpleGoal sGoal1 = new SimpleGoal(goalName, goalDescription, goalPoints);
                  Console.WriteLine("Simple Goal");

                  sGoal1.DisplayGoal(goals);
                  break;
                case 2:
                  Console.WriteLine("Eternal Goal");
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
          Console.WriteLine("Display here List of Goals");
          Console.WriteLine("The goals are:");
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
        default:
          Console.WriteLine("Invalid option");
          break;
      }


    } while (mainMenuOp != 6);
    Console.WriteLine("Come back soon!!");

  }
}