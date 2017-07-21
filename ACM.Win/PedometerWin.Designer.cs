namespace ACM.Win
{
    partial class PedometerWin
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StepGoalLabel = new System.Windows.Forms.Label();
            this.NumberStepsLabel = new System.Windows.Forms.Label();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.GoalTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(397, 37);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StepGoalLabel
            // 
            this.StepGoalLabel.AutoSize = true;
            this.StepGoalLabel.Location = new System.Drawing.Point(12, 42);
            this.StepGoalLabel.Name = "StepGoalLabel";
            this.StepGoalLabel.Size = new System.Drawing.Size(108, 13);
            this.StepGoalLabel.TabIndex = 1;
            this.StepGoalLabel.Text = "Step Goal for Today: ";
            // 
            // NumberStepsLabel
            // 
            this.NumberStepsLabel.AutoSize = true;
            this.NumberStepsLabel.Location = new System.Drawing.Point(12, 59);
            this.NumberStepsLabel.Name = "NumberStepsLabel";
            this.NumberStepsLabel.Size = new System.Drawing.Size(125, 13);
            this.NumberStepsLabel.TabIndex = 2;
            this.NumberStepsLabel.Text = "Number of Steps Today: ";
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(171, 42);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(100, 20);
            this.StepsTextBox.TabIndex = 3;
            // 
            // GoalTextBox
            // 
            this.GoalTextBox.Location = new System.Drawing.Point(171, 59);
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.Size = new System.Drawing.Size(100, 20);
            this.GoalTextBox.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(171, 227);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "label1";
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.GoalTextBox);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.NumberStepsLabel);
            this.Controls.Add(this.StepGoalLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label StepGoalLabel;
        private System.Windows.Forms.Label NumberStepsLabel;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.TextBox GoalTextBox;
        private System.Windows.Forms.Label ResultLabel;
    }
}