// Introduction to .NET Core
// 🔗 https://medium.com/net-core/introduction-to-net-core-adbf1962d57d

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

// 1. project starts at main method line 97
// 2. the main method starts out by setting bool whileTrue variable/parameter to "true"
// 3. a while loop is initiated with signature of parameter whileTrue as "true" (basically making an infinite loop)
// 4. in this loop a console class method WriteLine is initiated with output "Please provide a number:"
//      eg. console prints out the message
// 5. afterwards an if statement is in place to check whether a user provided input is convertable to integer
//      Console.ReadLine returns a string but any string is convertable to int if it contains only numbers with no other symbols
//      in other case conversion would fail and:

// 6. if statement signature is false/failed and thus starts doing all the embedded stuff within
// 7. writes both messages "Your input is not a valid number." and "Press any key to exit."
// 8. expects an input of any key to terminate the app
// 9. meanwhile sets the bool whileTrue parameter to "false"
//      this bool parameter as "false" will stop the loop because it does not meet the criteria of being "true"
//      any if statement or loop with a value of boolean with expect value of "true" by default
//      alternatively it is possible to declare it manually eg. whileTrue == false or whileTrue == true
//      eg. while(whileTrue == false) {} the loop will only work if the bool parameter is "false"
//      at the moment of initialization
// 10. and breaks out of the loop or in this case just freezes and expects user input to close the app

// 6. if statement signature is true/passed the statement embedded stuff is skipped
// 7. the method IteratePrimes is initiated with its signature of "max"
//      where "max" is expected as int primitive type see line 27 methods IteratePrimes signature
//      and in this case the "max" variable is passed as returned output as integer of user inserted input string, see 5. as reference
//                  IteratePrimes(int arg) initialization
// 8. first off this method on initialization writes a new empty line in console for aesthetics
// 9. now the logic starts, a loop is initiated with a signature of "max" loops to expect is the provided integer number that
//      you can find in the IteratePrimes(int argument) method itself as passed value that the method is working with
//      and a new variable "num" is asigned of integer of 2 and each loop would increment the 2 by one, hence the last part of the
//      signature "num++"
//      Increment & Decrement Explenation
//      🔗 https://www.oreilly.com/library/view/learning-c-30/9780596155018/ch04s04.html
//      for the sake of logic the "num" argument is assigned 2 instead of any other number
//      is because the prime numbers are as following example. 2, 3, 5, 7, 11, 13, 17, 19, 23 and 29.
//      therefore number 1 is not neccessary and is skipped.
//      so now the loop is going to incement the number 2 by one each time, so by the end of a loop and by starting once again
//      the "num" instead of being assigned the value of 2 once more, it will increment it thus fulfilling only
//      the two other parts of the signature, checking wether the "num" argument is smaller or equal to argument "max" and if true
//      will be incremented +1 thus 2 will result in 3 and the next loop it will be 4
//      and considering that "max" arg is eg. 5 then if the "num" arg reaches the value of 5 it will stop the loop and continue on
//      anything right after the for loop
// 10. thus the first thing that happens during this looping a new argument(variable/parameter - technically an argument
//      is a signature value that is being expected (eg. line 27), parameter is a global class variable and variable is a local
//      method variable (eg. line 100) having a value assigned to it on the spot while executing the ongoing logic)
//      is being assigned.
//      this boolean variable "check" of assigned value "true" is to later on to define that job is done, eg being assigned
//      the value of "false"
// 11. then another loop is being initiated of int var of value 2 (line 167 for explenation on why number 2)
//      this loop has a bit of more sophisticated logic to its signature
//      the num arg, taken from the outer loop, is being divided by 2 this is for optimisation reasons,
//      so that hardware does not keep random uneccessary values into memorey (ignore this for now)
// 12. an if statement is being passed with a signature of "num % i == 0"
//      this basically checks if arg "num" modulo arg "i" is equal to "0"
//      if the value is zero that means that the number is not odd and thus is not a prime number
//      this is extremely specific scenario and in this case "num % i == 0" would always return false if the result is greater than
//      or lesser than 0
//      this results into break operation (line 70 for explenation onto break and continue)
//      and the loop operation is instantly broken and thus the code runs on continueing the outter loop
//      IF "num" modulo "i" not 0 and that would mean that the value is odd, what we need...
//      the outter loop provides anothe if statement expecting "check == true && num != 4"
//      Soo if arg "check" is equal to to true AND arg "num" is not equal to number 4
//          the number four check is because I'm lazy and the algorithm threw out number 4 as prime number and this
//          would count as a quick and dirty fix
//      By passing the if statement a console.writeline method is initiated and the correct prime number is being printed out

