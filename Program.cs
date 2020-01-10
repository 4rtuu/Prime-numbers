// Your best buddies ✌
// 🔗 https://www.google.com
// 🔗 https://docs.microsoft.com
// 🔗 https://www.w3schools.com

// Using namespaces explenation
// 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces
using System;

// Namespace explenation
// 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/
namespace Primes
{
    // class explenation
    // 🔗 https://www.w3schools.com/cs/cs_classes.asp
    // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes
    class Program
    {
        // Normaly this method would be in its own class even namespace if necessary
        // and if this class is in another folder or
        // even project (reference is made to the project that use this class and its derivatives (eg. methods, constants, etc.))
        // and using is provided for the class (eg. using MadeUpFolderName.MadeUpNameSpace.MadeUpClass)
        
        // Method explenation
        // 🔗 https://www.w3schools.com/cs/cs_methods.asp
        // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        private static void IteratePrimes(int max)
        {
            // Console class
            // 🔗 https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8
            
            // In dept of Console class methods
            // 🔗 https://www.geeksforgeeks.org/console-class-in-c-sharp/
            Console.WriteLine();
            
            // Loop explenation
            // 🔗 https://www.geeksforgeeks.org/loops-in-c-sharp/
            
            // for, while and foreach loops are generally used ignore all others
            // google (c# for/while/foreach loop for more in dept explenation)
            for (int num = 2; num <= max; num++)
            {
                // Types and variables explenation
                // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables
                bool check = true;
                
                // View line 36 - 37 for explenation on loops
                for (int i = 2; i < num/2; i++)
                {
                    
                    // Conditions and If Statements
                    // 🔗 https://www.w3schools.com/cs/cs_conditions.asp
                    // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
                    
                    // Operators
                    // 🔗 https://www.geeksforgeeks.org/c-sharp-operators/
                    // 🔗 https://www.tutorialspoint.com/csharp/csharp_operators.htm
                    
                    // Modulo Operator - dont bother that much on this, this is very specific for specific cases
                    // 🔗 https://www.dotnetperls.com/modulo
                    if (num % i == 0)
                    {
                        // if this condition passes (true)
                        // set check bool variable to false
                        
                        // Variables & Operators with Example
                        // 🔗 https://www.guru99.com/c-sharp-variables-operator.html
                        check = false;
                        
                        // Break vs Continue
                        // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/break
                        // 🔗 https://www.w3schools.com/cs/cs_break.asp
                        break;
                    }
                }
                
                // Boolean logical operators
                // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
                
                // fail this condition if check bool false and the number is not 4
                // && is "AND"
                // || is "OR"
                // eg. if check variable is true AND num variable is not 4
                if (check == true && num != 4)
                {
                    // If statement passed as true
                    // eg. check is true AND num is not(line 55 for operator explenation) number 4
                    // write the number into the console
                    Console.WriteLine(num);
                }
            }
        }
        
        // Main method explenation and use
        // 🔗 https://www.completecsharptutorial.com/basic/main-method.php
        // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/
        static void Main(string[] args)
        {
            // see line 43 for Types and variables explenation
            bool whileTrue = true;
            
            // see line 36 on explenation of loops
            while (whileTrue)
            {
                // see line 32 on explenation of Console class
                Console.WriteLine("Please provide a number:");

                // see line 51 on explenation of Conditions and If Statements
                // Logical negation operator !
                // 🔗 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-negation-operator-
                // Helper methods explenation (don't bother so much on this, generaly read through and forget)
                // 🔗 https://social.msdn.microsoft.com/Forums/sqlserver/en-US/7b24548c-953e-4aeb-bf9e-3d7a22015ed6/what-exactly-is-a-c-helper-method?forum=smallbasic
                if (!int.TryParse(Console.ReadLine(), out int max))
                {
                    // see line 32 on explenation of Console class
                    Console.WriteLine("Your input is not a valid number.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    
                    // see line 66 on explenation of Variables & Operators with Example
                    whileTrue = false;
                    
                    // see line 70 on explenation of Break vs Continue
                    // break loop
                    break;
                }
                
                // Defining/Calling methods
                // 🔗 https://www.tutorialspoint.com/csharp/csharp_methods.htm
                IteratePrimes(max);
            }
        }
    }
}
