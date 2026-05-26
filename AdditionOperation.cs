namespace NegativeNumbersLearning.Classes
{
    // Клас додавання
    public class AdditionOperation : IMathOperation
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public string GetExpression(int a, int b)
        {
            return $"{a} + ({b})";
        }
    }
}
