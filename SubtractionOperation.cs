namespace NegativeNumbersLearning.Classes
{
    // Клас віднімання
    public class SubtractionOperation : IMathOperation
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }

        public string GetExpression(int a, int b)
        {
            return $"{a} - ({b})";
        }
    }
}
