using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TeamTaskManager
{

    public class Program 
    {
        public static void Main()
        {
			
		Console.WriteLine("Team Task Manager");
     string Member1name = "John A. nhel Damiano";
     string Project = "Team Task Management System";
     string Assignment = "Debugger";
     string password = "Damiano";
     string possition = "Team leader";
    
    Console.Write("Enter Your Password:");
    String Passwordinput = Console.ReadLine();
    if (Passwordinput  ==  password)
    {
    	Console.WriteLine("Name:"+Member1name);

        Console.WriteLine("Project:"+Project);

        Console.WriteLine("Possition:"+possition);
    	Console.WriteLine("Assignment:"+Assignment);
    
    	
    	
    	}
    else
    {
    	
       Console.WriteLine("Wrong password try again! ");
      
    }
   {
   	 string[]Task={"Encoder: ","Finance: ","Editor: "};
   	 string[] members =new string[3];
     	
   	 Console.WriteLine("");
     Console.WriteLine("");
     Console.WriteLine("Add member:");
     
     members[0] = Console.ReadLine();
     members[1] = Console.ReadLine();
     members[2] = Console.ReadLine();
     
     Console.WriteLine("");
     
     Console.WriteLine("Assigned Task:");
     Console.WriteLine("");
     Console.WriteLine(Task[0]+members[0]);
     Console.WriteLine(Task[1]+members[1]);
     Console.WriteLine(Task[2]+members[2]);
     
     }
     
   
     
     
     
     
     
        } 
    }
}