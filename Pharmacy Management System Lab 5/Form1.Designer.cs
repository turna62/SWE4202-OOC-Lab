namespace Pharmacy_Management_System_Lab_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PreviousBalanceTxt = new System.Windows.Forms.TextBox();
            this.MedicineNameTxt = new System.Windows.Forms.TextBox();
            this.NoofMedicineTxt = new System.Windows.Forms.TextBox();
            this.AddTxt = new System.Windows.Forms.TextBox();
            this.PricePerPieceTxt = new System.Windows.Forms.TextBox();
            this.MedicineButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MedicineName1Txt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.QuantityRemainingLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.MedicineNameLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Previous Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medicine Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. of Medicine";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price per piece";
            // 
            // PreviousBalanceTxt
            // 
            this.PreviousBalanceTxt.Location = new System.Drawing.Point(128, 76);
            this.PreviousBalanceTxt.Name = "PreviousBalanceTxt";
            this.PreviousBalanceTxt.Size = new System.Drawing.Size(100, 20);
            this.PreviousBalanceTxt.TabIndex = 7;
            // 
            // MedicineNameTxt
            // 
            this.MedicineNameTxt.Location = new System.Drawing.Point(128, 107);
            this.MedicineNameTxt.Name = "MedicineNameTxt";
            this.MedicineNameTxt.Size = new System.Drawing.Size(100, 20);
            this.MedicineNameTxt.TabIndex = 8;
            this.MedicineNameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NoofMedicineTxt
            // 
            this.NoofMedicineTxt.Location = new System.Drawing.Point(128, 134);
            this.NoofMedicineTxt.Name = "NoofMedicineTxt";
            this.NoofMedicineTxt.Size = new System.Drawing.Size(100, 20);
            this.NoofMedicineTxt.TabIndex = 9;
            // 
            // AddTxt
            // 
            this.AddTxt.Location = new System.Drawing.Point(128, 159);
            this.AddTxt.Name = "AddTxt";
            this.AddTxt.Size = new System.Drawing.Size(100, 20);
            this.AddTxt.TabIndex = 10;
            this.AddTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PricePerPieceTxt
            // 
            this.PricePerPieceTxt.Location = new System.Drawing.Point(127, 187);
            this.PricePerPieceTxt.Name = "PricePerPieceTxt";
            this.PricePerPieceTxt.Size = new System.Drawing.Size(100, 20);
            this.PricePerPieceTxt.TabIndex = 11;
            this.PricePerPieceTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // MedicineButton
            // 
            this.MedicineButton.Location = new System.Drawing.Point(127, 222);
            this.MedicineButton.Name = "MedicineButton";
            this.MedicineButton.Size = new System.Drawing.Size(107, 40);
            this.MedicineButton.TabIndex = 12;
            this.MedicineButton.Text = "Update Medicine History";
            this.MedicineButton.UseVisualStyleBackColor = true;
            this.MedicineButton.Click += new System.EventHandler(this.MedicineButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Selling Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Medicine Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quantity";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MedicineName1Txt
            // 
            this.MedicineName1Txt.Location = new System.Drawing.Point(128, 335);
            this.MedicineName1Txt.Name = "MedicineName1Txt";
            this.MedicineName1Txt.Size = new System.Drawing.Size(100, 20);
            this.MedicineName1Txt.TabIndex = 16;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(127, 367);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(100, 20);
            this.QuantityTxt.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(406, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "After Selling Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Medicine Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(403, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Current Balance";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Quantity Remaining";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // QuantityRemainingLabel
            // 
            this.QuantityRemainingLabel.AutoSize = true;
            this.QuantityRemainingLabel.Location = new System.Drawing.Point(513, 175);
            this.QuantityRemainingLabel.Name = "QuantityRemainingLabel";
            this.QuantityRemainingLabel.Size = new System.Drawing.Size(99, 13);
            this.QuantityRemainingLabel.TabIndex = 26;
            this.QuantityRemainingLabel.Text = "Quantity Remaining";
            this.QuantityRemainingLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(513, 149);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(83, 13);
            this.CurrentBalanceLabel.TabIndex = 25;
            this.CurrentBalanceLabel.Text = "Current Balance";
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Location = new System.Drawing.Point(513, 125);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(81, 13);
            this.MedicineNameLabel.TabIndex = 24;
            this.MedicineNameLabel.Text = "Medicine Name";
            this.MedicineNameLabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(281, 333);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(281, 370);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameButton
            // 
            this.NameButton.Location = new System.Drawing.Point(650, 149);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(75, 23);
            this.NameButton.TabIndex = 29;
            this.NameButton.Text = "Show";
            this.NameButton.UseVisualStyleBackColor = true;
            this.NameButton.Click += new System.EventHandler(this.NameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.QuantityRemainingLabel);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Controls.Add(this.MedicineNameLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.MedicineName1Txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MedicineButton);
            this.Controls.Add(this.PricePerPieceTxt);
            this.Controls.Add(this.AddTxt);
            this.Controls.Add(this.NoofMedicineTxt);
            this.Controls.Add(this.MedicineNameTxt);
            this.Controls.Add(this.PreviousBalanceTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pharmacy Management System Lab 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PreviousBalanceTxt;
        private System.Windows.Forms.TextBox MedicineNameTxt;
        private System.Windows.Forms.TextBox NoofMedicineTxt;
        private System.Windows.Forms.TextBox AddTxt;
        private System.Windows.Forms.TextBox PricePerPieceTxt;
        private System.Windows.Forms.Button MedicineButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MedicineName1Txt;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label QuantityRemainingLabel;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.Label MedicineNameLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NameButton;
    }
}

