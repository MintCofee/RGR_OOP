namespace NegativeNumbersLearning.Forms
{
    partial class TheoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox richTextBox1;

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
            this.richTextBox1 =
                new System.Windows.Forms.RichTextBox();

            this.SuspendLayout();

            this.richTextBox1.Location =
                new System.Drawing.Point(20, 20);

            this.richTextBox1.Size =
                new System.Drawing.Size(540, 360);

            this.richTextBox1.Font =
                new System.Drawing.Font("Segoe UI", 12F);

            this.richTextBox1.ReadOnly = true;
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(600, 420);

            this.Controls.Add(this.richTextBox1);

            this.Name = "TheoryForm";

            this.Text = "Теоретичний матеріал";

            this.ResumeLayout(false);
        }
    }
}
