namespace HelloWorldFormsApp
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
            btnHelloButtonTest = new Button();
            lblHelloWorldLabel = new Label();
            SuspendLayout();
            // 
            // btnHelloButtonTest
            // 
            btnHelloButtonTest.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelloButtonTest.ForeColor = SystemColors.MenuHighlight;
            btnHelloButtonTest.Location = new Point(293, 61);
            btnHelloButtonTest.Name = "btnHelloButtonTest";
            btnHelloButtonTest.Size = new Size(158, 105);
            btnHelloButtonTest.TabIndex = 0;
            btnHelloButtonTest.Text = "HelloWorldWork\r\n";
            btnHelloButtonTest.UseVisualStyleBackColor = true;
            btnHelloButtonTest.Click += ButtonOnClick;
            // 
            // lblHelloWorldLabel
            // 
            lblHelloWorldLabel.AutoSize = true;
            lblHelloWorldLabel.BackColor = SystemColors.ActiveCaption;
            lblHelloWorldLabel.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelloWorldLabel.Location = new Point(320, 214);
            lblHelloWorldLabel.Name = "lblHelloWorldLabel";
            lblHelloWorldLabel.Size = new Size(98, 36);
            lblHelloWorldLabel.TabIndex = 1;
            lblHelloWorldLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 434);
            Controls.Add(lblHelloWorldLabel);
            Controls.Add(btnHelloButtonTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHelloButtonTest;
        private Label lblHelloWorldLabel;
    }
}
