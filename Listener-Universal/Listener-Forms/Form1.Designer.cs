namespace Listener_Forms
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HitCount = new System.Windows.Forms.Label();
            this.BytesReceived = new System.Windows.Forms.Label();
            this.HitTextBox = new System.Windows.Forms.TextBox();
            this.BytesTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(261, 243);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(84, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Listener";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(364, 243);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(84, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop Listener";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(261, 303);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(84, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(364, 303);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(84, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HitCount
            // 
            this.HitCount.AutoSize = true;
            this.HitCount.Location = new System.Drawing.Point(258, 93);
            this.HitCount.Name = "HitCount";
            this.HitCount.Size = new System.Drawing.Size(51, 13);
            this.HitCount.TabIndex = 4;
            this.HitCount.Text = "Hit Count";
            // 
            // BytesReceived
            // 
            this.BytesReceived.AutoSize = true;
            this.BytesReceived.Location = new System.Drawing.Point(258, 126);
            this.BytesReceived.Name = "BytesReceived";
            this.BytesReceived.Size = new System.Drawing.Size(82, 13);
            this.BytesReceived.TabIndex = 5;
            this.BytesReceived.Text = "Bytes Received";
            // 
            // HitTextBox
            // 
            this.HitTextBox.Location = new System.Drawing.Point(364, 90);
            this.HitTextBox.Name = "HitTextBox";
            this.HitTextBox.ReadOnly = true;
            this.HitTextBox.Size = new System.Drawing.Size(100, 20);
            this.HitTextBox.TabIndex = 6;
            // 
            // BytesTextBox
            // 
            this.BytesTextBox.Location = new System.Drawing.Point(364, 123);
            this.BytesTextBox.Name = "BytesTextBox";
            this.BytesTextBox.ReadOnly = true;
            this.BytesTextBox.Size = new System.Drawing.Size(100, 20);
            this.BytesTextBox.TabIndex = 7;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(258, 159);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(71, 13);
            this.PortLabel.TabIndex = 8;
            this.PortLabel.Text = "Listening Port";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(364, 156);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 20);
            this.PortTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 545);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.BytesTextBox);
            this.Controls.Add(this.HitTextBox);
            this.Controls.Add(this.BytesReceived);
            this.Controls.Add(this.HitCount);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label HitCount;
        private System.Windows.Forms.Label BytesReceived;
        private System.Windows.Forms.TextBox HitTextBox;
        private System.Windows.Forms.TextBox BytesTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
    }
}

