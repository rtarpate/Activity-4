namespace LibrayManagemntSystem
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
            LibraryManagemntSystemLable = new Label();
            ExitButton = new Button();
            RentAnItemButton = new Button();
            ReturnAnItemButton = new Button();
            AddNewBookButton = new Button();
            AddNewDVDButton = new Button();
            SuspendLayout();
            // 
            // LibraryManagemntSystemLable
            // 
            LibraryManagemntSystemLable.AutoSize = true;
            LibraryManagemntSystemLable.Font = new Font("Segoe UI", 20F);
            LibraryManagemntSystemLable.ForeColor = Color.White;
            LibraryManagemntSystemLable.Location = new Point(27, 35);
            LibraryManagemntSystemLable.Name = "LibraryManagemntSystemLable";
            LibraryManagemntSystemLable.Size = new Size(339, 37);
            LibraryManagemntSystemLable.TabIndex = 0;
            LibraryManagemntSystemLable.Text = "Library Managemnt System";
            LibraryManagemntSystemLable.Click += LibraryManagemntSystemLable_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Red;
            ExitButton.Font = new Font("Segoe UI", 20F);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(582, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(195, 96);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // RentAnItemButton
            // 
            RentAnItemButton.BackColor = Color.Red;
            RentAnItemButton.Font = new Font("Segoe UI", 20F);
            RentAnItemButton.ForeColor = Color.White;
            RentAnItemButton.Location = new Point(12, 342);
            RentAnItemButton.Name = "RentAnItemButton";
            RentAnItemButton.Size = new Size(188, 96);
            RentAnItemButton.TabIndex = 2;
            RentAnItemButton.Text = "Rent an Item";
            RentAnItemButton.UseVisualStyleBackColor = false;
            RentAnItemButton.Click += RentAnItemButton_Click;
            // 
            // ReturnAnItemButton
            // 
            ReturnAnItemButton.BackColor = Color.Red;
            ReturnAnItemButton.Font = new Font("Segoe UI", 20F);
            ReturnAnItemButton.ForeColor = Color.White;
            ReturnAnItemButton.Location = new Point(206, 342);
            ReturnAnItemButton.Name = "ReturnAnItemButton";
            ReturnAnItemButton.Size = new Size(182, 96);
            ReturnAnItemButton.TabIndex = 3;
            ReturnAnItemButton.Text = "Return an item";
            ReturnAnItemButton.UseVisualStyleBackColor = false;
            ReturnAnItemButton.Click += ReturnAnItemButton_Click;
            // 
            // AddNewBookButton
            // 
            AddNewBookButton.BackColor = Color.Red;
            AddNewBookButton.Font = new Font("Segoe UI", 20F);
            AddNewBookButton.ForeColor = Color.White;
            AddNewBookButton.Location = new Point(394, 342);
            AddNewBookButton.Name = "AddNewBookButton";
            AddNewBookButton.Size = new Size(182, 96);
            AddNewBookButton.TabIndex = 4;
            AddNewBookButton.Text = "Add new Book";
            AddNewBookButton.UseVisualStyleBackColor = false;
            AddNewBookButton.Click += AddNewBookButton_Click;
            // 
            // AddNewDVDButton
            // 
            AddNewDVDButton.BackColor = Color.Red;
            AddNewDVDButton.Font = new Font("Segoe UI", 20F);
            AddNewDVDButton.ForeColor = Color.White;
            AddNewDVDButton.Location = new Point(582, 342);
            AddNewDVDButton.Name = "AddNewDVDButton";
            AddNewDVDButton.Size = new Size(182, 96);
            AddNewDVDButton.TabIndex = 5;
            AddNewDVDButton.Text = "Add new DVD";
            AddNewDVDButton.UseVisualStyleBackColor = false;
            AddNewDVDButton.Click += AddNewDVDButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(AddNewDVDButton);
            Controls.Add(AddNewBookButton);
            Controls.Add(ReturnAnItemButton);
            Controls.Add(RentAnItemButton);
            Controls.Add(ExitButton);
            Controls.Add(LibraryManagemntSystemLable);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LibraryManagemntSystemLable;
        private Button ExitButton;
        private Button RentAnItemButton;
        private Button ReturnAnItemButton;
        private Button AddNewBookButton;
        private Button AddNewDVDButton;
    }
}
