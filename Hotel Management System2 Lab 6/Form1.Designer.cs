namespace Hotel_Management_System2_Lab_6
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
            this.bookingidtxt = new System.Windows.Forms.TextBox();
            this.bookingidcombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.userid1txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.roomchoicecombo = new System.Windows.Forms.ComboBox();
            this.quantitycombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bookingid1txt = new System.Windows.Forms.TextBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.noofroomslbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.useridlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label27 = new System.Windows.Forms.Label();
            this.amount1lbl = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Booking ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "User ID:";
            // 
            // bookingidtxt
            // 
            this.bookingidtxt.Location = new System.Drawing.Point(94, 73);
            this.bookingidtxt.Name = "bookingidtxt";
            this.bookingidtxt.Size = new System.Drawing.Size(100, 21);
            this.bookingidtxt.TabIndex = 5;
            // 
            // bookingidcombo
            // 
            this.bookingidcombo.FormattingEnabled = true;
            this.bookingidcombo.Items.AddRange(new object[] {
            "Pending",
            "Confirmed"});
            this.bookingidcombo.Location = new System.Drawing.Point(200, 73);
            this.bookingidcombo.Name = "bookingidcombo";
            this.bookingidcombo.Size = new System.Drawing.Size(121, 23);
            this.bookingidcombo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact No. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address:";
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(509, 70);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(100, 21);
            this.useridtxt.TabIndex = 10;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(509, 95);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 21);
            this.nametxt.TabIndex = 11;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(509, 122);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(100, 21);
            this.contacttxt.TabIndex = 12;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(509, 152);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(100, 21);
            this.addresstxt.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Set Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Create Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "User ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(665, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Room Choice:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(665, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Entry date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(665, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Departure Date:";
            // 
            // userid1txt
            // 
            this.userid1txt.Location = new System.Drawing.Point(749, 67);
            this.userid1txt.Name = "userid1txt";
            this.userid1txt.Size = new System.Drawing.Size(100, 21);
            this.userid1txt.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(855, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quantity:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // roomchoicecombo
            // 
            this.roomchoicecombo.FormattingEnabled = true;
            this.roomchoicecombo.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.roomchoicecombo.Location = new System.Drawing.Point(749, 94);
            this.roomchoicecombo.Name = "roomchoicecombo";
            this.roomchoicecombo.Size = new System.Drawing.Size(100, 23);
            this.roomchoicecombo.TabIndex = 23;
            // 
            // quantitycombo
            // 
            this.quantitycombo.FormattingEnabled = true;
            this.quantitycombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.quantitycombo.Location = new System.Drawing.Point(915, 98);
            this.quantitycombo.Name = "quantitycombo";
            this.quantitycombo.Size = new System.Drawing.Size(97, 23);
            this.quantitycombo.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(749, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(24, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(765, 152);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(23, 21);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(747, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 25);
            this.button4.TabIndex = 27;
            this.button4.Text = "Place Booking";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(473, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Booking ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(473, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 29;
            this.label15.Text = "Status:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(473, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "No. of Rooms:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(473, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 31;
            this.label17.Text = "Amount:";
            // 
            // bookingid1txt
            // 
            this.bookingid1txt.Location = new System.Drawing.Point(549, 252);
            this.bookingid1txt.Name = "bookingid1txt";
            this.bookingid1txt.Size = new System.Drawing.Size(100, 21);
            this.bookingid1txt.TabIndex = 32;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(523, 282);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(41, 15);
            this.statuslbl.TabIndex = 33;
            this.statuslbl.Text = "Status";
            // 
            // noofroomslbl
            // 
            this.noofroomslbl.AutoSize = true;
            this.noofroomslbl.Location = new System.Drawing.Point(564, 307);
            this.noofroomslbl.Name = "noofroomslbl";
            this.noofroomslbl.Size = new System.Drawing.Size(82, 15);
            this.noofroomslbl.TabIndex = 34;
            this.noofroomslbl.Text = "No. of Rooms";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Location = new System.Drawing.Point(531, 331);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(49, 15);
            this.amountlbl.TabIndex = 35;
            this.amountlbl.Text = "Amount";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(720, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 15);
            this.label21.TabIndex = 36;
            this.label21.Text = "User ID:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(720, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 37;
            this.label22.Text = "Address:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(720, 307);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 15);
            this.label23.TabIndex = 38;
            this.label23.Text = "User Name:";
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Location = new System.Drawing.Point(777, 258);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(48, 15);
            this.useridlbl.TabIndex = 39;
            this.useridlbl.Text = "User ID";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(777, 282);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(51, 15);
            this.addresslbl.TabIndex = 40;
            this.addresslbl.Text = "Address";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(799, 307);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(70, 15);
            this.usernamelbl.TabIndex = 41;
            this.usernamelbl.Text = "User Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(607, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "See Order Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(47, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 139);
            this.listBox1.TabIndex = 43;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(44, 343);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 15);
            this.label27.TabIndex = 44;
            this.label27.Text = "Amount:";
            // 
            // amount1lbl
            // 
            this.amount1lbl.AutoSize = true;
            this.amount1lbl.Location = new System.Drawing.Point(102, 343);
            this.amount1lbl.Name = "amount1lbl";
            this.amount1lbl.Size = new System.Drawing.Size(49, 15);
            this.amount1lbl.TabIndex = 45;
            this.amount1lbl.Text = "Amount";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(227, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 46;
            this.button6.Text = "Show Room Details";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 519);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.amount1lbl);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.amountlbl);
            this.Controls.Add(this.noofroomslbl);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.bookingid1txt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.quantitycombo);
            this.Controls.Add(this.roomchoicecombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.userid1txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookingidcombo);
            this.Controls.Add(this.bookingidtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookingidtxt;
        private System.Windows.Forms.ComboBox bookingidcombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox useridtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userid1txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox roomchoicecombo;
        private System.Windows.Forms.ComboBox quantitycombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox bookingid1txt;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label noofroomslbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label amount1lbl;
        private System.Windows.Forms.Button button6;
    }
}

