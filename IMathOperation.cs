namespace NegativeNumbersLearning.Classes
{
    // Інтерфейс математичної операції
    public interface IMathOperation
    {
        int Calculate(int a, int b);

        string GetExpression(int a, int b);
    }
}
