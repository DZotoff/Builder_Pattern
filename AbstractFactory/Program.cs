namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        private static Printer instance;

        private Printer() { }

        public static Printer GetInstance()
        {
            if (instance == null)
            {
                instance = new Printer();
            }
            return instance;
        }

        public void Print(string message)
        {
            // Output: print out the string message 
            Console.WriteLine(message);
         
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public interface Exam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }

    public class MathExam : Exam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Printer printer = Printer.GetInstance();
            printer.Print("Conducting Math Exam");

        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Printer printer = Printer.GetInstance();
            printer.Print("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Printer printer = Printer.GetInstance();
            printer.Print("Publishing Math Exam Results");
        }
    }

    // TODO#5: Add new ScienceExam class
    public class ScienceExam : Exam
    {
        public void Conduct()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Publishing Science Exam Results");
        }
    }

    // TODO#6: Add another ProgrammingExam class
    public class ProgrammingExam : Exam
    {
        public void Conduct()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Publishing Programming Exam Results");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.GetInstance();

            // TODO#8: Test that the created Printer works, by calling the Print method
            printer.Print("Testing Printer");
            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance
            Printer anotherPrinter = Printer.GetInstance();
            Console.WriteLine("Are the two printer instances the same? " + (printer == anotherPrinter));
            // TODO#10: Use Abstract Factory to create different types of exams.
            Exam mathExam = new MathExam();
            Exam scienceExam = new ScienceExam();
            Exam programmingExam = new ProgrammingExam();

            mathExam.Conduct();
            mathExam.Evaluate();
            mathExam.PublishResults();

            scienceExam.Conduct();
            scienceExam.Evaluate();
            scienceExam.PublishResults();

            programmingExam.Conduct();
            programmingExam.Evaluate();
            programmingExam.PublishResults();
        }
    }

}
