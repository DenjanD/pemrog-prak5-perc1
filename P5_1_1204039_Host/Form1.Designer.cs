namespace P5_1_1204039_Host
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBox1 = new P5_1_1204039.NumericTextBox();
            this.verticalLabel1 = new P5_1_1204039.VerticalLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extended Control : Numeric Text Box";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(12, 27);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(373, 23);
            this.numericTextBox1.TabIndex = 1;
            this.numericTextBox1.Text = "3232";
            // 
            // verticalLabel1
            // 
            this.verticalLabel1.Location = new System.Drawing.Point(65, 113);
            this.verticalLabel1.Name = "verticalLabel1";
            this.verticalLabel1.Size = new System.Drawing.Size(57, 79);
            this.verticalLabel1.TabIndex = 2;
            this.verticalLabel1.Text = "Vertical Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custom Control : Vertical Label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalLabel1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controls Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private P5_1_1204039.NumericTextBox numericTextBox1;
        private P5_1_1204039.VerticalLabel verticalLabel1;
        private Label label2;
    }
}