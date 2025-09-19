namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

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
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            this.SuspendLayout();
           
            
            
            this.numericWeight.Location = new System.Drawing.Point(150, 30);
            this.numericWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numericWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(120, 22);
            this.numericWeight.TabIndex = 0;
            this.numericWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            
          
            
            this.numericHeight.Location = new System.Drawing.Point(150, 70);
            this.numericHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            this.numericHeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 22);
            this.numericHeight.TabIndex = 1;
            this.numericHeight.Value = new decimal(new int[] { 170, 0, 0, 0 });
           


            this.buttonCalc.Location = new System.Drawing.Point(30, 110);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(240, 30);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Рассчитать BMI";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            
            
            
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Location = new System.Drawing.Point(30, 160);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(240, 80);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат появится здесь";
            
            

            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.Text = "Вес (кг):";
            


            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.Text = "Рост (см):";
            


            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.numericWeight);
            this.Name = "Form1";
            this.Text = "Калькулятор BMI";
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
