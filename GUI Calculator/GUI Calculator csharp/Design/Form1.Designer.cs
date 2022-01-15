
namespace GUI_Calculator_csharp
{
    partial class CalcDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcDesign));
            this.NumberOneInput = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NumberOneLabel = new System.Windows.Forms.Label();
            this.NumberTwoLabel = new System.Windows.Forms.Label();
            this.NumberTwoInput = new System.Windows.Forms.TextBox();
            this.ConfirmCalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MathOption = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NumberOneInput
            // 
            this.NumberOneInput.Location = new System.Drawing.Point(12, 29);
            this.NumberOneInput.Name = "NumberOneInput";
            this.NumberOneInput.Size = new System.Drawing.Size(139, 20);
            this.NumberOneInput.TabIndex = 0;
            this.NumberOneInput.Text = "Number one";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(292, 165);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberOneLabel
            // 
            this.NumberOneLabel.AutoSize = true;
            this.NumberOneLabel.Location = new System.Drawing.Point(9, 9);
            this.NumberOneLabel.Name = "NumberOneLabel";
            this.NumberOneLabel.Size = new System.Drawing.Size(65, 13);
            this.NumberOneLabel.TabIndex = 2;
            this.NumberOneLabel.Text = "Number one";
            // 
            // NumberTwoLabel
            // 
            this.NumberTwoLabel.AutoSize = true;
            this.NumberTwoLabel.Location = new System.Drawing.Point(306, 9);
            this.NumberTwoLabel.Name = "NumberTwoLabel";
            this.NumberTwoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumberTwoLabel.Size = new System.Drawing.Size(64, 13);
            this.NumberTwoLabel.TabIndex = 3;
            this.NumberTwoLabel.Text = "Number two";
            // 
            // NumberTwoInput
            // 
            this.NumberTwoInput.Location = new System.Drawing.Point(228, 29);
            this.NumberTwoInput.Name = "NumberTwoInput";
            this.NumberTwoInput.Size = new System.Drawing.Size(139, 20);
            this.NumberTwoInput.TabIndex = 4;
            this.NumberTwoInput.Text = "Number two";
            // 
            // ConfirmCalculateButton
            // 
            this.ConfirmCalculateButton.Location = new System.Drawing.Point(150, 100);
            this.ConfirmCalculateButton.Name = "ConfirmCalculateButton";
            this.ConfirmCalculateButton.Size = new System.Drawing.Size(79, 23);
            this.ConfirmCalculateButton.TabIndex = 5;
            this.ConfirmCalculateButton.Text = "Calculate";
            this.ConfirmCalculateButton.UseVisualStyleBackColor = true;
            this.ConfirmCalculateButton.Click += new System.EventHandler(this.ConfirmCalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(9, 170);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(69, 13);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Result: None";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MathOption
            // 
            this.MathOption.FormattingEnabled = true;
            this.MathOption.Items.AddRange(new object[] {
            "Add",
            "Substract",
            "Multiply",
            "Divide"});
            this.MathOption.Location = new System.Drawing.Point(150, 73);
            this.MathOption.MaxDropDownItems = 4;
            this.MathOption.Name = "MathOption";
            this.MathOption.Size = new System.Drawing.Size(79, 21);
            this.MathOption.TabIndex = 7;
            this.MathOption.Text = "Add";
            // 
            // CalcDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.MathOption);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ConfirmCalculateButton);
            this.Controls.Add(this.NumberTwoInput);
            this.Controls.Add(this.NumberTwoLabel);
            this.Controls.Add(this.NumberOneLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NumberOneInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcDesign";
            this.Text = "C# Calculator by TherioJunior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOneInput;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label NumberOneLabel;
        private System.Windows.Forms.Label NumberTwoLabel;
        private System.Windows.Forms.TextBox NumberTwoInput;
        private System.Windows.Forms.Button ConfirmCalculateButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ComboBox MathOption;
    }
}

