namespace LibrayManagemntSystem
{
    partial class AddNewItemFormBook
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
            AddNewBookLabel = new Label();
            MainMenuButton = new Button();
            EnterBookNameLabel = new Label();
            EnterBookNameTextBox = new TextBox();
            EnterBookAuthorTextBox = new TextBox();
            EnterBookAuthorLabel = new Label();
            EnterBookPriceTextBox = new TextBox();
            EnterBookPriceLabel = new Label();
            EnterBookStockTextBox = new TextBox();
            EnterBookStockLabel = new Label();
            EnterBookYearPublishedTextBox = new TextBox();
            EnterBookYearPublishedLabel = new Label();
            AddBookButton = new Button();
            EnterBookTypeLabel = new Label();
            NovelRadioButton = new RadioButton();
            ComicBookRadioButton = new RadioButton();
            MangaRadioButton = new RadioButton();
            AllCurentBooksListBox = new ListBox();
            AllCurrentBooksLabel = new Label();
            SuspendLayout();
            // 
            // AddNewBookLabel
            // 
            AddNewBookLabel.AutoSize = true;
            AddNewBookLabel.Font = new Font("Segoe UI", 20F);
            AddNewBookLabel.ForeColor = Color.White;
            AddNewBookLabel.Location = new Point(12, 9);
            AddNewBookLabel.Name = "AddNewBookLabel";
            AddNewBookLabel.Size = new Size(194, 37);
            AddNewBookLabel.TabIndex = 1;
            AddNewBookLabel.Text = "Add New Book";
            AddNewBookLabel.Click += AddNewBookLabel_Click;
            // 
            // MainMenuButton
            // 
            MainMenuButton.BackColor = Color.Red;
            MainMenuButton.Font = new Font("Segoe UI", 20F);
            MainMenuButton.ForeColor = Color.White;
            MainMenuButton.Location = new Point(1155, 26);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(168, 61);
            MainMenuButton.TabIndex = 2;
            MainMenuButton.Text = "Main Menu";
            MainMenuButton.UseVisualStyleBackColor = false;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // EnterBookNameLabel
            // 
            EnterBookNameLabel.AutoSize = true;
            EnterBookNameLabel.Font = new Font("Segoe UI", 10F);
            EnterBookNameLabel.ForeColor = Color.White;
            EnterBookNameLabel.Location = new Point(12, 54);
            EnterBookNameLabel.Name = "EnterBookNameLabel";
            EnterBookNameLabel.Size = new Size(116, 19);
            EnterBookNameLabel.TabIndex = 3;
            EnterBookNameLabel.Text = "Enter Book Name";
            EnterBookNameLabel.Click += EnterBookNameLabel_Click;
            // 
            // EnterBookNameTextBox
            // 
            EnterBookNameTextBox.Location = new Point(12, 78);
            EnterBookNameTextBox.Name = "EnterBookNameTextBox";
            EnterBookNameTextBox.Size = new Size(100, 23);
            EnterBookNameTextBox.TabIndex = 4;
            EnterBookNameTextBox.TextChanged += EnterBookNameTextBox_TextChanged;
            // 
            // EnterBookAuthorTextBox
            // 
            EnterBookAuthorTextBox.Location = new Point(12, 128);
            EnterBookAuthorTextBox.Name = "EnterBookAuthorTextBox";
            EnterBookAuthorTextBox.Size = new Size(100, 23);
            EnterBookAuthorTextBox.TabIndex = 6;
            EnterBookAuthorTextBox.TextChanged += EnterBookAuthorTextBox_TextChanged;
            // 
            // EnterBookAuthorLabel
            // 
            EnterBookAuthorLabel.AutoSize = true;
            EnterBookAuthorLabel.Font = new Font("Segoe UI", 10F);
            EnterBookAuthorLabel.ForeColor = Color.White;
            EnterBookAuthorLabel.Location = new Point(12, 104);
            EnterBookAuthorLabel.Name = "EnterBookAuthorLabel";
            EnterBookAuthorLabel.Size = new Size(123, 19);
            EnterBookAuthorLabel.TabIndex = 5;
            EnterBookAuthorLabel.Text = "Enter Book Author";
            EnterBookAuthorLabel.Click += EnterBookAuthorLabel_Click;
            // 
            // EnterBookPriceTextBox
            // 
            EnterBookPriceTextBox.Location = new Point(12, 178);
            EnterBookPriceTextBox.Name = "EnterBookPriceTextBox";
            EnterBookPriceTextBox.Size = new Size(100, 23);
            EnterBookPriceTextBox.TabIndex = 8;
            EnterBookPriceTextBox.TextChanged += EnterBookPriceTextBox_TextChanged;
            // 
            // EnterBookPriceLabel
            // 
            EnterBookPriceLabel.AutoSize = true;
            EnterBookPriceLabel.Font = new Font("Segoe UI", 10F);
            EnterBookPriceLabel.ForeColor = Color.White;
            EnterBookPriceLabel.Location = new Point(12, 154);
            EnterBookPriceLabel.Name = "EnterBookPriceLabel";
            EnterBookPriceLabel.Size = new Size(109, 19);
            EnterBookPriceLabel.TabIndex = 7;
            EnterBookPriceLabel.Text = "Enter Book Price";
            EnterBookPriceLabel.Click += EnterBookPriceLabel_Click;
            // 
            // EnterBookStockTextBox
            // 
            EnterBookStockTextBox.Location = new Point(12, 228);
            EnterBookStockTextBox.Name = "EnterBookStockTextBox";
            EnterBookStockTextBox.Size = new Size(100, 23);
            EnterBookStockTextBox.TabIndex = 10;
            EnterBookStockTextBox.TextChanged += EnterBookStockTextBox_TextChanged;
            // 
            // EnterBookStockLabel
            // 
            EnterBookStockLabel.AutoSize = true;
            EnterBookStockLabel.Font = new Font("Segoe UI", 10F);
            EnterBookStockLabel.ForeColor = Color.White;
            EnterBookStockLabel.Location = new Point(12, 204);
            EnterBookStockLabel.Name = "EnterBookStockLabel";
            EnterBookStockLabel.Size = new Size(113, 19);
            EnterBookStockLabel.TabIndex = 9;
            EnterBookStockLabel.Text = "Enter Book Stock";
            EnterBookStockLabel.Click += EnterBookStockLabel_Click;
            // 
            // EnterBookYearPublishedTextBox
            // 
            EnterBookYearPublishedTextBox.Location = new Point(12, 278);
            EnterBookYearPublishedTextBox.Name = "EnterBookYearPublishedTextBox";
            EnterBookYearPublishedTextBox.Size = new Size(100, 23);
            EnterBookYearPublishedTextBox.TabIndex = 12;
            EnterBookYearPublishedTextBox.TextChanged += EnterBookYearPublishedTextBox_TextChanged;
            // 
            // EnterBookYearPublishedLabel
            // 
            EnterBookYearPublishedLabel.AutoSize = true;
            EnterBookYearPublishedLabel.Font = new Font("Segoe UI", 10F);
            EnterBookYearPublishedLabel.ForeColor = Color.White;
            EnterBookYearPublishedLabel.Location = new Point(12, 254);
            EnterBookYearPublishedLabel.Name = "EnterBookYearPublishedLabel";
            EnterBookYearPublishedLabel.Size = new Size(169, 19);
            EnterBookYearPublishedLabel.TabIndex = 11;
            EnterBookYearPublishedLabel.Text = "Enter Book Year Published";
            EnterBookYearPublishedLabel.Click += EnterBookYearPublishedLabel_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.Red;
            AddBookButton.Font = new Font("Segoe UI", 10F);
            AddBookButton.ForeColor = Color.White;
            AddBookButton.Location = new Point(12, 408);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(123, 30);
            AddBookButton.TabIndex = 13;
            AddBookButton.Text = "Add Book";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // EnterBookTypeLabel
            // 
            EnterBookTypeLabel.AutoSize = true;
            EnterBookTypeLabel.Font = new Font("Segoe UI", 10F);
            EnterBookTypeLabel.ForeColor = Color.White;
            EnterBookTypeLabel.Location = new Point(12, 304);
            EnterBookTypeLabel.Name = "EnterBookTypeLabel";
            EnterBookTypeLabel.Size = new Size(108, 19);
            EnterBookTypeLabel.TabIndex = 14;
            EnterBookTypeLabel.Text = "Enter Book Type";
            EnterBookTypeLabel.Click += EnterBookTypeLabel_Click;
            // 
            // NovelRadioButton
            // 
            NovelRadioButton.AutoSize = true;
            NovelRadioButton.ForeColor = Color.White;
            NovelRadioButton.Location = new Point(12, 326);
            NovelRadioButton.Name = "NovelRadioButton";
            NovelRadioButton.Size = new Size(56, 19);
            NovelRadioButton.TabIndex = 15;
            NovelRadioButton.TabStop = true;
            NovelRadioButton.Text = "Novel";
            NovelRadioButton.UseVisualStyleBackColor = true;
            NovelRadioButton.CheckedChanged += NovelRadioButton_CheckedChanged;
            // 
            // ComicBookRadioButton
            // 
            ComicBookRadioButton.AutoSize = true;
            ComicBookRadioButton.ForeColor = Color.White;
            ComicBookRadioButton.Location = new Point(12, 351);
            ComicBookRadioButton.Name = "ComicBookRadioButton";
            ComicBookRadioButton.Size = new Size(90, 19);
            ComicBookRadioButton.TabIndex = 16;
            ComicBookRadioButton.TabStop = true;
            ComicBookRadioButton.Text = "Comic Book";
            ComicBookRadioButton.UseVisualStyleBackColor = true;
            ComicBookRadioButton.CheckedChanged += ComicBookRadioButton_CheckedChanged;
            // 
            // MangaRadioButton
            // 
            MangaRadioButton.AutoSize = true;
            MangaRadioButton.ForeColor = Color.White;
            MangaRadioButton.Location = new Point(12, 376);
            MangaRadioButton.Name = "MangaRadioButton";
            MangaRadioButton.Size = new Size(62, 19);
            MangaRadioButton.TabIndex = 17;
            MangaRadioButton.TabStop = true;
            MangaRadioButton.Text = "Manga";
            MangaRadioButton.UseVisualStyleBackColor = true;
            MangaRadioButton.CheckedChanged += MangaRadioButton_CheckedChanged;
            // 
            // AllCurentBooksListBox
            // 
            AllCurentBooksListBox.FormattingEnabled = true;
            AllCurentBooksListBox.ItemHeight = 15;
            AllCurentBooksListBox.Location = new Point(187, 84);
            AllCurentBooksListBox.Name = "AllCurentBooksListBox";
            AllCurentBooksListBox.Size = new Size(936, 304);
            AllCurentBooksListBox.TabIndex = 18;
            AllCurentBooksListBox.SelectedIndexChanged += AllCurentBooksListBox_SelectedIndexChanged;
            // 
            // AllCurrentBooksLabel
            // 
            AllCurrentBooksLabel.AutoSize = true;
            AllCurrentBooksLabel.Font = new Font("Segoe UI", 10F);
            AllCurrentBooksLabel.ForeColor = Color.White;
            AllCurrentBooksLabel.Location = new Point(187, 54);
            AllCurrentBooksLabel.Name = "AllCurrentBooksLabel";
            AllCurrentBooksLabel.Size = new Size(116, 19);
            AllCurrentBooksLabel.TabIndex = 19;
            AllCurrentBooksLabel.Text = "All Current Books";
            AllCurrentBooksLabel.Click += AllCurrentBooksLabel_Click;
            // 
            // AddNewItemFormBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1335, 450);
            Controls.Add(AllCurrentBooksLabel);
            Controls.Add(AllCurentBooksListBox);
            Controls.Add(MangaRadioButton);
            Controls.Add(ComicBookRadioButton);
            Controls.Add(NovelRadioButton);
            Controls.Add(EnterBookTypeLabel);
            Controls.Add(AddBookButton);
            Controls.Add(EnterBookYearPublishedTextBox);
            Controls.Add(EnterBookYearPublishedLabel);
            Controls.Add(EnterBookStockTextBox);
            Controls.Add(EnterBookStockLabel);
            Controls.Add(EnterBookPriceTextBox);
            Controls.Add(EnterBookPriceLabel);
            Controls.Add(EnterBookAuthorTextBox);
            Controls.Add(EnterBookAuthorLabel);
            Controls.Add(EnterBookNameTextBox);
            Controls.Add(EnterBookNameLabel);
            Controls.Add(MainMenuButton);
            Controls.Add(AddNewBookLabel);
            Name = "AddNewItemFormBook";
            Text = "AddNewItemFormBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewBookLabel;
        private Button MainMenuButton;
        private Label EnterBookNameLabel;
        private TextBox EnterBookNameTextBox;
        private TextBox EnterBookAuthorTextBox;
        private Label EnterBookAuthorLabel;
        private TextBox EnterBookPriceTextBox;
        private Label EnterBookPriceLabel;
        private TextBox EnterBookStockTextBox;
        private Label EnterBookStockLabel;
        private TextBox EnterBookYearPublishedTextBox;
        private Label EnterBookYearPublishedLabel;
        private Button AddBookButton;
        private Label EnterBookTypeLabel;
        private RadioButton NovelRadioButton;
        private RadioButton ComicBookRadioButton;
        private RadioButton MangaRadioButton;
        private ListBox AllCurentBooksListBox;
        private Label AllCurrentBooksLabel;
    }
}