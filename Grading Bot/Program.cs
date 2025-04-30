namespace Grading_Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradingBot gradingBot = new GradingBot();
            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student score: ");
                int score = int.Parse(Console.ReadLine());
                string grade = gradingBot.GradeStudent(name, score);
                Console.WriteLine($"Student {name} got {grade}");
                Console.WriteLine(); 

            }

        }
    }
    }
