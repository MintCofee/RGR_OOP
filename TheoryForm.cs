using System.Windows.Forms;

namespace NegativeNumbersLearning.Forms
{
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();

            richTextBox1.Text =
                "ПРАВИЛА ДОДАВАННЯ І ВІДНІМАННЯ НЕГАТИВНИХ ЧИСЕЛ\n\n" +

                "1. Щоб додати два від’ємних числа, потрібно:\n" +
                "- додати їх модулі;\n" +
                "- поставити знак мінус.\n\n" +

                "Приклад:\n" +
                "-5 + (-3) = -8\n\n" +

                "2. Щоб відняти число, потрібно:\n" +
                "- додати протилежне число.\n\n" +

                "Приклад:\n" +
                "-4 - (-2) = -4 + 2 = -2";
        }
    }
}
