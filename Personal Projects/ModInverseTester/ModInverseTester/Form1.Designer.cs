namespace ModInverseTester
{
    partial class ModInverseTester
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
            this.beginModInverseTest = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // beginModInverseTest
            // 
            this.beginModInverseTest.BackColor = System.Drawing.Color.Indigo;
            this.beginModInverseTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginModInverseTest.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginModInverseTest.Location = new System.Drawing.Point(90, 12);
            this.beginModInverseTest.Name = "beginModInverseTest";
            this.beginModInverseTest.Size = new System.Drawing.Size(75, 32);
            this.beginModInverseTest.TabIndex = 0;
            this.beginModInverseTest.Text = "Test";
            this.beginModInverseTest.UseVisualStyleBackColor = false;
            this.beginModInverseTest.Click += new System.EventHandler(this.beginModInverseTest_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoBox.Location = new System.Drawing.Point(12, 50);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoBox.Size = new System.Drawing.Size(231, 147);
            this.infoBox.TabIndex = 1;
            // 
            // ModInverseTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(255, 209);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.beginModInverseTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModInverseTester";
            this.Text = "Modular Inverse Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginModInverseTest;
        private System.Windows.Forms.TextBox infoBox;
    }
}

