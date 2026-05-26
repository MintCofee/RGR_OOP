
using System;

namespace NegativeNumbersLearning.Classes
{
    // Генератор завдань
    public class TaskGenerator
    {
        private Random random = new Random();

        public int Number1 { get; private set; }

        public int Number2 { get; private set; }

        public int CorrectAnswer { get; private set; }

        public string Expression { get; private set; }

        public void GenerateTask(IMathOperation operation, int level)
        {
            int limit = 10;

            switch (level)
            {
                case 1:
                    limit = 10;
                    break;

                case 2:
                    limit = 20;
                    break;

                case 3:
                    limit = 50;
                    break;
            }

            Number1 = random.Next(-limit, limit + 1);
            Number2 = random.Next(-limit, limit + 1);

            CorrectAnswer = operation.Calculate(Number1, Number2);

            Expression = operation.GetExpression(Number1, Number2);
        }
    }
}
