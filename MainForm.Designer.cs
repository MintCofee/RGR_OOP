
namespace NegativeNumbersLearning.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Bold
            );

            this.labelTitle.Location = new System.Drawing.Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(500, 37);
            this.labelTitle.Text =
                "Додавання і віднімання негативних чисел";

            // btnAddition
            this.btnAddition.Location =
                new System.Drawing.Point(40, 100);

            this.btnAddition.Size =
                new System.Drawing.Size(160, 50);

            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Text = "Додавання";

            this.btnAddition.Click +=
                new System.EventHandler(this.btnAddition_Click);

            // btnSubtraction
            this.btnSubtraction.Location =
                new System.Drawing.Point(40, 170);

            this.btnSubtraction.Size =
                new System.Drawing.Size(160, 50);

            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Text = "Віднімання";

            this.btnSubtraction.Click +=
                new System.EventHandler(this.btnSubtraction_Click);

            // btnTheory
            this.btnTheory.Location =
                new System.Drawing.Point(40, 240);

            this.btnTheory.Size =
                new System.Drawing.Size(160, 50);

            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Text = "Теорія";

            this.btnTheory.Click +=
                new System.EventHandler(this.btnTheory_Click);

            // comboLevel
            this.comboLevel.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.comboLevel.Location =
                new System.Drawing.Point(350, 100);

            this.comboLevel.Size =
                new System.Drawing.Size(180, 28);

            // lblTask
            this.lblTask.AutoSize = true;

            this.lblTask.Font = new System.Drawing.Font(
                "Segoe UI",
                22F,
                System.Drawing.FontStyle.Bold
            );

            this.lblTask.Location =
                new System.Drawing.Point(320, 180);

            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(200, 50);
            this.lblTask.Text = "-5 + (-3)";

            // txtAnswer
            this.txtAnswer.Font =
                new System.Drawing.Font("Segoe UI", 16F);

            this.txtAnswer.Location =
                new System.Drawing.Point(320, 260);

            this.txtAnswer.Size =
                new System.Drawing.Size(220, 43);

            // btnCheck
            this.btnCheck.Location =
                new System.Drawing.Point(350, 330);

            this.btnCheck.Size =
                new System.Drawing.Size(170, 50);

            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Text = "Перевірити";

            this.btnCheck.Click +=
                new System.EventHandler(this.btnCheck_Click);

            // lblCorrect
            this.lblCorrect.AutoSize = true;

            this.lblCorrect.Location =
                new System.Drawing.Point(250, 430);

            this.lblCorrect.Size =
                new System.Drawing.Size(120, 20);

            this.lblCorrect.Text = "Правильних: 0";

            // lblWrong
            this.lblWrong.AutoSize = true;

            this.lblWrong.Location =
                new System.Drawing.Point(450, 430);

            this.lblWrong.Size =
                new System.Drawing.Size(140, 20);

            this.lblWrong.Text = "Неправильних: 0";

            // MainForm
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 500);

            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblWrong);

            this.Name = "MainForm";

            this.Text =
                "Навчаюча програма";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
