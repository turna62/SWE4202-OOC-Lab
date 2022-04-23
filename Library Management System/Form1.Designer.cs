namespace Library_Management_System
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
            this.UserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.BookTittleTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UserID1TextBox = new System.Windows.Forms.TextBox();
            this.ShowHistoryButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BookID1TextBox = new System.Windows.Forms.TextBox();
            this.ShowHistory1Button = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UserID2TextBox = new System.Windows.Forms.TextBox();
            this.BookID2TextBox = new System.Windows.Forms.TextBox();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(27, 24);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(40, 13);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BookID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Tittle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(73, 24);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserIDTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(73, 57);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(78, 103);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 10;
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(318, 21);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookIDTextBox.TabIndex = 11;
            // 
            // BookTittleTextBox
            // 
            this.BookTittleTextBox.Location = new System.Drawing.Point(318, 53);
            this.BookTittleTextBox.Name = "BookTittleTextBox";
            this.BookTittleTextBox.Size = new System.Drawing.Size(100, 20);
            this.BookTittleTextBox.TabIndex = 12;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(318, 87);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorTextBox.TabIndex = 13;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(318, 119);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.PublisherTextBox.TabIndex = 14;
            this.PublisherTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(318, 154);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 15;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "UserID";
            // 
            // UserID1TextBox
            // 
            this.UserID1TextBox.Location = new System.Drawing.Point(526, 31);
            this.UserID1TextBox.Name = "UserID1TextBox";
            this.UserID1TextBox.Size = new System.Drawing.Size(100, 20);
            this.UserID1TextBox.TabIndex = 17;
            // 
            // ShowHistoryButton
            // 
            this.ShowHistoryButton.Location = new System.Drawing.Point(524, 60);
            this.ShowHistoryButton.Name = "ShowHistoryButton";
            this.ShowHistoryButton.Size = new System.Drawing.Size(102, 23);
            this.ShowHistoryButton.TabIndex = 18;
            this.ShowHistoryButton.Text = "Show History";
            this.ShowHistoryButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Book ID";
            // 
            // BookID1TextBox
            // 
            this.BookID1TextBox.Location = new System.Drawing.Point(745, 31);
            this.BookID1TextBox.Name = "BookID1TextBox";
            this.BookID1TextBox.Size = new System.Drawing.Size(100, 20);
            this.BookID1TextBox.TabIndex = 20;
            this.BookID1TextBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // ShowHistory1Button
            // 
            this.ShowHistory1Button.Location = new System.Drawing.Point(745, 60);
            this.ShowHistory1Button.Name = "ShowHistory1Button";
            this.ShowHistory1Button.Size = new System.Drawing.Size(100, 23);
            this.ShowHistory1Button.TabIndex = 21;
            this.ShowHistory1Button.Text = "Show History";
            this.ShowHistory1Button.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(78, 144);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 22;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(318, 195);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 23;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(488, 195);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(224, 212);
            this.UserListBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "UserID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "BookID";
            // 
            // UserID2TextBox
            // 
            this.UserID2TextBox.Location = new System.Drawing.Point(78, 241);
            this.UserID2TextBox.Name = "UserID2TextBox";
            this.UserID2TextBox.Size = new System.Drawing.Size(100, 20);
            this.UserID2TextBox.TabIndex = 27;
            // 
            // BookID2TextBox
            // 
            this.BookID2TextBox.Location = new System.Drawing.Point(78, 289);
            this.BookID2TextBox.Name = "BookID2TextBox";
            this.BookID2TextBox.Size = new System.Drawing.Size(100, 20);
            this.BookID2TextBox.TabIndex = 28;
            this.BookID2TextBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // BorrowButton
            // 
            this.BorrowButton.Location = new System.Drawing.Point(98, 335);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(75, 23);
            this.BorrowButton.TabIndex = 29;
            this.BorrowButton.Text = "Borrow";
            this.BorrowButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 484);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.BookID2TextBox);
            this.Controls.Add(this.UserID2TextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ShowHistory1Button);
            this.Controls.Add(this.BookID1TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShowHistoryButton);
            this.Controls.Add(this.UserID1TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookTittleTextBox);
            this.Controls.Add(this.BookIDTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID);
            this.Name = "Form1";
            this.Text = "UserID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.TextBox BookTittleTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UserID1TextBox;
        private System.Windows.Forms.Button ShowHistoryButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookID1TextBox;
        private System.Windows.Forms.Button ShowHistory1Button;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UserID2TextBox;
        private System.Windows.Forms.TextBox BookID2TextBox;
        private System.Windows.Forms.Button BorrowButton;
    }
}

