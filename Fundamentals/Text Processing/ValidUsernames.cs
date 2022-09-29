using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] user = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            
          bool IsValid = true;
 
 
            for (int i = 0; i < user.Length; i++)
            {
                string currentUser = user[i];                
 
                if(currentUser.Length < 3 || currentUser.Length > 16)
                {
                    IsValid = false;
                    continue;
                }
                else if(currentUser.Length >=3 && currentUser.Length <=16)
                {
                    foreach(char c in currentUser)
                    {
                        if(c == '_' || c == '-' || char.IsDigit(c) || char.IsLetter(c))
                        {
                            IsValid = true;                           
                        }
                        else
                        {
                            IsValid = false;
                            break;
                        }
                    }                   
 
                }
                if (IsValid)
                {
                    string validUser = user[i];
                    Console.WriteLine(validUser);
                }
 
            }                       
 
        }
    }
}
