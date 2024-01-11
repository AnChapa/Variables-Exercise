namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Daisy";
            int age = 2;
            char let = 'a';
            bool goodDog = true;
            double weight = 11.8;
            decimal treats = 3.5m;
            Console.WriteLine($"Hello, my dog's name is {dogName}. She is {age} years old.\nShe weighs {weight} pounds and gets {treats} treats a day.\nThis computer says she is {let} good dog: {goodDog}");
        }
    }
}
