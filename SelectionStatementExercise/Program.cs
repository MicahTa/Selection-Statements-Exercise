using System.ComponentModel;
using System.Reflection.Metadata;

namespace SelectionStatementExercise
{
    public class Program
    {
        // Loop game forever
        static void Main(string[] args){
            bool won = false;

            while (won == false) {
                won = Game();
            }

            won = false;
            while (won == false) {
                won = Subject();
            }
        }

        static bool Subject(){
            Console.WriteLine("Guess my favorite subject:");
            string? userInput = (Console.ReadLine());

            switch(userInput){
                case ("Math"):
                    Console.WriteLine("CORRECT I LOVE MATH");
                    return true;
                case ("History"):
                    Console.WriteLine("That teacher is really funny but no");
                    return false;
                case ("English"):
                    Console.WriteLine("I am alergic to reading");
                    return false;
                case ("Ag"):
                    Console.WriteLine("Nah not really");
                    return false;
                case ("Sychology"):
                    Console.WriteLine("I hate that class more than anything");
                    return false;
                default:
                    return false;
            }
        }
        static bool Game()
        {
            // NO CHEATING
            // Dont even try to do the math or write code to tell you the awnser.
            int favriotNumber = (int)(Math.Pow(3, 4) % 4) * 6;


            Console.WriteLine("Guess my favorite number:");
            string? userInput = (Console.ReadLine());

            int userGuess = 0;

            // Both test for non parsable and no entry
            try {
                if (userInput == null || userInput == ""){
                    throw new Exception("No user input");
                }

                userGuess = int.Parse(userInput);
            } catch {
                Console.WriteLine("WRONG");
                return false;
            }

            if (userGuess == favriotNumber) {
                Console.WriteLine("\nWOW your so smart!!!!!\nI hope you didnt cheat....\nI'll find out if you cheated.\n\n\n");
                return true;
            } else {
                Console.WriteLine("WRONG");
                return false;
            }

        }
    }
}
