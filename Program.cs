using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           ///Threee Basic Arrays///////
           int[] array = new int[10]{0,1,2,3,4,5,6,7,8,9};
           string[] names = new string[4]{"Tim", "Martin", "Nikki", "Sara"};
           bool[] space = new bool[10]{true,false,true,false,true,false,true,false,true,false};

           ////////// Mutilplication Table/////////////
           int[] multiplication = new int[10]{1,2,3,4,5,6,7,8,9,10}; 
           int[,] mul_store = new int[10,10]; // 2D Array of 10x10
           for (var i= 0; i< multiplication.Length; i++) // First Take multiplication[0] 
           {
               foreach(int num in multiplication) // and multiple with all multiplication indexes
               {
                   mul_store[i,num-1] = num*(i+1); // Store multiplied value and go to next index in first array
                   Console.WriteLine(mul_store[i,num-1]); // After reaching 10 grab multiplcation[2] and repeat procedure
               }
           } 

           ///////////User Info Dictionary/////////////
           Dictionary<string,string> user = new Dictionary<string,string>();

           //User1 Info
           user.Add("Name1","Tim");
           user.Add("Fav_Sport1","BasketBall");
           user.Add("Num_Pets1","2");
           user.Add("Like_Ice_Cream1","true");

           //User2 Info
           user.Add("Name2","Martin");
           user.Add("Fav_Sport2","VolleyBall");
           user.Add("Num_Pets2","5");
           user.Add("Like_Ice_Cream2","true");

           //User3 Info
           user.Add("Name3","Nikki");
           user.Add("Fav_Sport3","Cricket");
           user.Add("Num_Pets3","1");
           user.Add("Like_Ice_Cream3","false");

           //User4 Info
           user.Add("Name4","Sara");
           user.Add("Fav_Sport4","Chess");
           user.Add("Num_Pets4","1");
           user.Add("Like_Ice_Cream4","true");

           // Creating a List To add all the above Information
           List<string> userList = new List<string>();
           foreach (KeyValuePair<string,string> entry in user)  // Dictionaries Concept
            {
                userList.Add(entry.Value); //Adding to list
            }
            
            // Iterating Through List
            foreach (string info in userList)
            {
                Console.WriteLine(info + ",");
            }
        }
    }
}
