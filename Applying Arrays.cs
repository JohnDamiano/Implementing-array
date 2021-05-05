using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
		
        
     Console.WriteLine("Team Task Manager");
     Console.WriteLine("");
     
     string Member1name = "John A. Nhel Damiano";
     string Project = "Team Task Management System";
     string Assignment = "Debugger";
     string Username = "JND20";
     string password = "Damiano";
     string possition = "Team leader";
            
     int i = 0;
     for (; i < 2; i++)
     {
     	
     Console.Write("Enter Username:");
     string usernameInput = Console.ReadLine();

     Console.Write("Enter Password:");
     string passwordInput = Console.ReadLine();

     Console.WriteLine();
     if (usernameInput == Username && passwordInput == password)
     {
     	
     Console.WriteLine("Member's INFORMATION");
     Console.WriteLine("Name:" + Member1name);
     Console.WriteLine("Project:" + Project);
     Console.WriteLine("Task: " + Assignment);
     Console.WriteLine("Possition:" + possition);
     break;
     
      }
      else
      {
      Console.WriteLine("Wrong User name or password Try again!");
      Console.WriteLine("");
      }
      }
      if (i == 2)
      {
      Console.WriteLine("Application will exit...");
      Environment.Exit(0);
           
      }	
     var Task =new string[3];
   	 var members =new string[3];
     	
   	 Console.WriteLine("");
     Console.WriteLine("");
     Console.WriteLine("Add member:");
     
     members[0] = Console.ReadLine();
     members[1] = Console.ReadLine();
     members[2] = Console.ReadLine();
     
     Console.WriteLine("");
     Console.WriteLine("");
     Console.WriteLine("Add Task:");
     
     Task[0] = Console.ReadLine();
     Task[1] = Console.ReadLine();
     Task[2] = Console.ReadLine();
   
     
     
     Console.WriteLine("");
     
     Console.WriteLine("Assigned Task:");
     Console.WriteLine("");
     Console.WriteLine(Task[0]+"--"+members[0]);
     Console.WriteLine(Task[1]+"--"+members[1]);
     Console.WriteLine(Task[2]+"--"+members[2]);
           
           
           
           
           
        }
    }
}
