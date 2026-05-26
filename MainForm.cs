using NegativeNumbersLearning.Classes;
using System;
using System.Windows.Forms;

namespace NegativeNumbersLearning.Forms
{
    public partial class MainForm : Form
    {
        private TaskGenerator generator;
        private StudentStatistics statistics;

        private IMathOperation operation;

        public MainForm()
        {
            InitializeComponent();

            generator = new TaskGenerator();
            statistics = new StudentStatistics();

            comboLevel.Items.Add("Легкий");
            comboLevel.Items.Add("Середній");
            comboLevel.Items.Add("Складний");

            comboLevel.SelectedIndex = 0;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operation = new AdditionOperation();

            GenerateNewTask();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operation = new SubtractionOperation();

            GenerateNewTask();
        }

        private void GenerateNewTask()
        {
            int level = comboLevel.SelectedIndex + 1;

            generator.GenerateTask(operation, level);

            lblTask.Text = generator.Expression;

            txtAnswer.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int answer;

            if (!int.TryParse(txtAnswer.Text, out answer))
            {
                MessageBox.Show("Введіть число!");
                return;
            }

            if (answer == generator.CorrectAnswer)
            {
                statistics.AddCorrect();

                MessageBox.Show("Правильно!");
            }
            else
            {
                statistics.AddWrong();

                MessageBox.Show(
                    $"Неправильно! Правильна відповідь: {generator.CorrectAnswer}"
                );
            }

            lblCorrect.Text = "Правильних: " + statistics.CorrectAnswers;

            lblWrong.Text = "Неправильних: " + statistics.WrongAnswers;

            GenerateNewTask();
        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            TheoryForm form = new TheoryForm();

            form.ShowDialog();
        }
    }
}

