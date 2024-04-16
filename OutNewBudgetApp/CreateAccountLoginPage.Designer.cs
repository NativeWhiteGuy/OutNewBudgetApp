namespace OutNewBudgetApp
{
    partial class CreateAccountLoginPage
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
            CreateAccountButton = new Button();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(77, 450);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(75, 38);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(158, 450);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 38);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginSignUpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 527);
            Controls.Add(LoginButton);
            Controls.Add(CreateAccountButton);
            Name = "LoginSignUpPage";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateAccountButton;
        private Button LoginButton;
    }
}