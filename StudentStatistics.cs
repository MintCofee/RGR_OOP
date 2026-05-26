namespace NegativeNumbersLearning.Classes
{
    // Статистика учня
    public class StudentStatistics
    {
        public int CorrectAnswers { get; private set; }

        public int WrongAnswers { get; private set; }

        public void AddCorrect()
        {
            CorrectAnswers++;
        }

        public void AddWrong()
        {
            WrongAnswers++;
        }

        public int Total()
        {
            return CorrectAnswers + WrongAnswers;
        }
    }
}
