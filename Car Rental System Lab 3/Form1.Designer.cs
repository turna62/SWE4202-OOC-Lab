namespace lab3
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
            this.user_id = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Car_name = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.numberofcars = new System.Windows.Forms.Label();
            this.UserIDTextbox = new System.Windows.Forms.TextBox();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.DestinationTextbox = new System.Windows.Forms.TextBox();
            this.CarNameTextbox = new System.Windows.Forms.TextBox();
            this.CarModelTextbox = new System.Windows.Forms.TextBox();
            this.CarQuantityTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.user_id1 = new System.Windows.Forms.Label();
            this.user_name1 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.Label();
            this.rented_car = new System.Windows.Forms.Label();
            this.destination1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.UserID1Textbox = new System.Windows.Forms.TextBox();
            this.user_id2 = new System.Windows.Forms.Label();
            this.car_name1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.car_name2 = new System.Windows.Forms.Label();
            this.UserHistoryButton = new System.Windows.Forms.Button();
            this.CarHistoryButton = new System.Windows.Forms.Button();
            this.SaveCarButton = new System.Windows.Forms.Button();
            this.rentcar = new System.Windows.Forms.Button();
            this.CarName2Textbox = new System.Windows.Forms.TextBox();
            this.UserID2Textbox = new System.Windows.Forms.TextBox();
            this.CarName1Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CarModel1Textbox = new System.Windows.Forms.TextBox();
            this.CarQuantity1Textbox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.RentedCarLebel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(52, 144);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(46, 13);
            this.user_id.TabIndex = 2;
            this.user_id.Text = "User ID:";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(43, 175);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(63, 13);
            this.user_name.TabIndex = 3;
            this.user_name.Text = "User Name:";
            this.user_name.Click += new System.EventHandler(this.label4_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(58, 203);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 13);
            this.address.TabIndex = 4;
            this.address.Text = "Address:";
            this.address.Click += new System.EventHandler(this.label5_Click);
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(58, 232);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(63, 13);
            this.destination.TabIndex = 5;
            this.destination.Text = "Destination:";
            this.destination.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CAR";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Car_name
            // 
            this.Car_name.AutoSize = true;
            this.Car_name.Location = new System.Drawing.Point(297, 137);
            this.Car_name.Name = "Car_name";
            this.Car_name.Size = new System.Drawing.Size(57, 13);
            this.Car_name.TabIndex = 7;
            this.Car_name.Text = "Car Name:";
            this.Car_name.Click += new System.EventHandler(this.label8_Click);
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(297, 172);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(58, 13);
            this.model.TabIndex = 8;
            this.model.Text = "Car Model:";
            this.model.Click += new System.EventHandler(this.label9_Click);
            // 
            // numberofcars
            // 
            this.numberofcars.AutoSize = true;
            this.numberofcars.Location = new System.Drawing.Point(271, 210);
            this.numberofcars.Name = "numberofcars";
            this.numberofcars.Size = new System.Drawing.Size(68, 13);
            this.numberofcars.TabIndex = 9;
            this.numberofcars.Text = "Car Quantity:";
            this.numberofcars.Click += new System.EventHandler(this.label10_Click);
            // 
            // UserIDTextbox
            // 
            this.UserIDTextbox.Location = new System.Drawing.Point(127, 141);
            this.UserIDTextbox.Name = "UserIDTextbox";
            this.UserIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserIDTextbox.TabIndex = 10;
            this.UserIDTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(127, 175);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextbox.TabIndex = 11;
            this.UserNameTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(127, 203);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextbox.TabIndex = 12;
            this.AddressTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DestinationTextbox
            // 
            this.DestinationTextbox.Location = new System.Drawing.Point(127, 232);
            this.DestinationTextbox.Name = "DestinationTextbox";
            this.DestinationTextbox.Size = new System.Drawing.Size(100, 20);
            this.DestinationTextbox.TabIndex = 13;
            this.DestinationTextbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CarNameTextbox
            // 
            this.CarNameTextbox.Location = new System.Drawing.Point(383, 134);
            this.CarNameTextbox.Name = "CarNameTextbox";
            this.CarNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.CarNameTextbox.TabIndex = 14;
            // 
            // CarModelTextbox
            // 
            this.CarModelTextbox.Location = new System.Drawing.Point(383, 169);
            this.CarModelTextbox.Name = "CarModelTextbox";
            this.CarModelTextbox.Size = new System.Drawing.Size(100, 20);
            this.CarModelTextbox.TabIndex = 15;
            this.CarModelTextbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // CarQuantityTextbox
            // 
            this.CarQuantityTextbox.Location = new System.Drawing.Point(383, 207);
            this.CarQuantityTextbox.Name = "CarQuantityTextbox";
            this.CarQuantityTextbox.Size = new System.Drawing.Size(100, 20);
            this.CarQuantityTextbox.TabIndex = 16;
            this.CarQuantityTextbox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(598, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "User history";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // user_id1
            // 
            this.user_id1.AutoSize = true;
            this.user_id1.Location = new System.Drawing.Point(598, 137);
            this.user_id1.Name = "user_id1";
            this.user_id1.Size = new System.Drawing.Size(46, 13);
            this.user_id1.TabIndex = 18;
            this.user_id1.Text = "User ID:";
            this.user_id1.Click += new System.EventHandler(this.label12_Click);
            // 
            // user_name1
            // 
            this.user_name1.AutoSize = true;
            this.user_name1.Location = new System.Drawing.Point(581, 178);
            this.user_name1.Name = "user_name1";
            this.user_name1.Size = new System.Drawing.Size(63, 13);
            this.user_name1.TabIndex = 19;
            this.user_name1.Text = "User Name:";
            this.user_name1.Click += new System.EventHandler(this.label13_Click);
            // 
            // address1
            // 
            this.address1.AutoSize = true;
            this.address1.Location = new System.Drawing.Point(583, 203);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(48, 13);
            this.address1.TabIndex = 20;
            this.address1.Text = "Address:";
            this.address1.Click += new System.EventHandler(this.label14_Click);
            // 
            // rented_car
            // 
            this.rented_car.AutoSize = true;
            this.rented_car.Location = new System.Drawing.Point(583, 239);
            this.rented_car.Name = "rented_car";
            this.rented_car.Size = new System.Drawing.Size(64, 13);
            this.rented_car.TabIndex = 21;
            this.rented_car.Text = "Rented Car:";
            this.rented_car.Click += new System.EventHandler(this.label15_Click);
            // 
            // destination1
            // 
            this.destination1.AutoSize = true;
            this.destination1.Location = new System.Drawing.Point(581, 276);
            this.destination1.Name = "destination1";
            this.destination1.Size = new System.Drawing.Size(63, 13);
            this.destination1.TabIndex = 22;
            this.destination1.Text = "Destination:";
            this.destination1.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(603, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 23;
            // 
            // UserID1Textbox
            // 
            this.UserID1Textbox.Location = new System.Drawing.Point(663, 134);
            this.UserID1Textbox.Name = "UserID1Textbox";
            this.UserID1Textbox.Size = new System.Drawing.Size(100, 20);
            this.UserID1Textbox.TabIndex = 24;
            this.UserID1Textbox.TextChanged += new System.EventHandler(this.UserID1Textbox_TextChanged);
            // 
            // user_id2
            // 
            this.user_id2.AutoSize = true;
            this.user_id2.Location = new System.Drawing.Point(65, 325);
            this.user_id2.Name = "user_id2";
            this.user_id2.Size = new System.Drawing.Size(46, 13);
            this.user_id2.TabIndex = 29;
            this.user_id2.Text = "User ID:";
            // 
            // car_name1
            // 
            this.car_name1.AutoSize = true;
            this.car_name1.Location = new System.Drawing.Point(65, 350);
            this.car_name1.Name = "car_name1";
            this.car_name1.Size = new System.Drawing.Size(57, 13);
            this.car_name1.TabIndex = 30;
            this.car_name1.Text = "Car Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(300, 298);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Car History";
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUserButton.ForeColor = System.Drawing.Color.Red;
            this.SaveUserButton.Location = new System.Drawing.Point(127, 276);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(75, 23);
            this.SaveUserButton.TabIndex = 32;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.saveb_Click);
            // 
            // car_name2
            // 
            this.car_name2.AutoSize = true;
            this.car_name2.Location = new System.Drawing.Point(261, 327);
            this.car_name2.Name = "car_name2";
            this.car_name2.Size = new System.Drawing.Size(57, 13);
            this.car_name2.TabIndex = 33;
            this.car_name2.Text = "Car Name:";
            // 
            // UserHistoryButton
            // 
            this.UserHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHistoryButton.ForeColor = System.Drawing.Color.Red;
            this.UserHistoryButton.Location = new System.Drawing.Point(789, 134);
            this.UserHistoryButton.Name = "UserHistoryButton";
            this.UserHistoryButton.Size = new System.Drawing.Size(134, 24);
            this.UserHistoryButton.TabIndex = 36;
            this.UserHistoryButton.Text = "Show User History";
            this.UserHistoryButton.UseVisualStyleBackColor = true;
            this.UserHistoryButton.Click += new System.EventHandler(this.UserHistoryButton_Click);
            // 
            // CarHistoryButton
            // 
            this.CarHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarHistoryButton.ForeColor = System.Drawing.Color.Red;
            this.CarHistoryButton.Location = new System.Drawing.Point(457, 320);
            this.CarHistoryButton.Name = "CarHistoryButton";
            this.CarHistoryButton.Size = new System.Drawing.Size(140, 27);
            this.CarHistoryButton.TabIndex = 37;
            this.CarHistoryButton.Text = "Show Car History";
            this.CarHistoryButton.UseVisualStyleBackColor = true;
            this.CarHistoryButton.Click += new System.EventHandler(this.CarHistoryButton_Click);
            // 
            // SaveCarButton
            // 
            this.SaveCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCarButton.ForeColor = System.Drawing.Color.Red;
            this.SaveCarButton.Location = new System.Drawing.Point(383, 251);
            this.SaveCarButton.Name = "SaveCarButton";
            this.SaveCarButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCarButton.TabIndex = 38;
            this.SaveCarButton.Text = "Save";
            this.SaveCarButton.UseVisualStyleBackColor = true;
            this.SaveCarButton.Click += new System.EventHandler(this.SaveCarButton_Click);
            // 
            // rentcar
            // 
            this.rentcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentcar.ForeColor = System.Drawing.Color.Red;
            this.rentcar.Location = new System.Drawing.Point(152, 390);
            this.rentcar.Name = "rentcar";
            this.rentcar.Size = new System.Drawing.Size(75, 23);
            this.rentcar.TabIndex = 39;
            this.rentcar.Text = "Rent Car";
            this.rentcar.UseVisualStyleBackColor = true;
            this.rentcar.Click += new System.EventHandler(this.rentcar_Click);
            // 
            // CarName2Textbox
            // 
            this.CarName2Textbox.Location = new System.Drawing.Point(324, 327);
            this.CarName2Textbox.Name = "CarName2Textbox";
            this.CarName2Textbox.Size = new System.Drawing.Size(100, 20);
            this.CarName2Textbox.TabIndex = 40;
            this.CarName2Textbox.TextChanged += new System.EventHandler(this.carname1l_TextChanged);
            // 
            // UserID2Textbox
            // 
            this.UserID2Textbox.Location = new System.Drawing.Point(127, 320);
            this.UserID2Textbox.Name = "UserID2Textbox";
            this.UserID2Textbox.Size = new System.Drawing.Size(100, 20);
            this.UserID2Textbox.TabIndex = 43;
            // 
            // CarName1Textbox
            // 
            this.CarName1Textbox.Location = new System.Drawing.Point(127, 350);
            this.CarName1Textbox.Name = "CarName1Textbox";
            this.CarName1Textbox.Size = new System.Drawing.Size(100, 20);
            this.CarName1Textbox.TabIndex = 44;
            this.CarName1Textbox.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Car Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Car Quantity";
            // 
            // CarModel1Textbox
            // 
            this.CarModel1Textbox.Location = new System.Drawing.Point(373, 374);
            this.CarModel1Textbox.Name = "CarModel1Textbox";
            this.CarModel1Textbox.Size = new System.Drawing.Size(100, 20);
            this.CarModel1Textbox.TabIndex = 48;
            // 
            // CarQuantity1Textbox
            // 
            this.CarQuantity1Textbox.Location = new System.Drawing.Point(373, 414);
            this.CarQuantity1Textbox.Name = "CarQuantity1Textbox";
            this.CarQuantity1Textbox.Size = new System.Drawing.Size(100, 20);
            this.CarQuantity1Textbox.TabIndex = 49;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(650, 178);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 50;
            this.UserNameLabel.Text = "User Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(650, 203);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 51;
            this.AddressLabel.Text = "Address:";
            // 
            // RentedCarLebel
            // 
            this.RentedCarLebel.AutoSize = true;
            this.RentedCarLebel.Location = new System.Drawing.Point(649, 239);
            this.RentedCarLebel.Name = "RentedCarLebel";
            this.RentedCarLebel.Size = new System.Drawing.Size(64, 13);
            this.RentedCarLebel.TabIndex = 52;
            this.RentedCarLebel.Text = "Rented Car:";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(650, 276);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(63, 13);
            this.DestinationLabel.TabIndex = 53;
            this.DestinationLabel.Text = "Destination:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 474);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.RentedCarLebel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.CarQuantity1Textbox);
            this.Controls.Add(this.CarModel1Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarName1Textbox);
            this.Controls.Add(this.UserID2Textbox);
            this.Controls.Add(this.CarName2Textbox);
            this.Controls.Add(this.rentcar);
            this.Controls.Add(this.SaveCarButton);
            this.Controls.Add(this.CarHistoryButton);
            this.Controls.Add(this.UserHistoryButton);
            this.Controls.Add(this.car_name2);
            this.Controls.Add(this.SaveUserButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.car_name1);
            this.Controls.Add(this.user_id2);
            this.Controls.Add(this.UserID1Textbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.destination1);
            this.Controls.Add(this.rented_car);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.user_name1);
            this.Controls.Add(this.user_id1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CarQuantityTextbox);
            this.Controls.Add(this.CarModelTextbox);
            this.Controls.Add(this.CarNameTextbox);
            this.Controls.Add(this.DestinationTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.UserIDTextbox);
            this.Controls.Add(this.numberofcars);
            this.Controls.Add(this.model);
            this.Controls.Add(this.Car_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.address);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Car_name;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label numberofcars;
        private System.Windows.Forms.TextBox UserIDTextbox;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox DestinationTextbox;
        private System.Windows.Forms.TextBox CarNameTextbox;
        private System.Windows.Forms.TextBox CarModelTextbox;
        private System.Windows.Forms.TextBox CarQuantityTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label user_id1;
        private System.Windows.Forms.Label user_name1;
        private System.Windows.Forms.Label address1;
        private System.Windows.Forms.Label rented_car;
        private System.Windows.Forms.Label destination1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UserID1Textbox;
        private System.Windows.Forms.Label user_id2;
        private System.Windows.Forms.Label car_name1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button SaveUserButton;
        private System.Windows.Forms.Label car_name2;
        private System.Windows.Forms.Button UserHistoryButton;
        private System.Windows.Forms.Button CarHistoryButton;
        private System.Windows.Forms.Button SaveCarButton;
        private System.Windows.Forms.Button rentcar;
        private System.Windows.Forms.TextBox CarName2Textbox;
        private System.Windows.Forms.TextBox UserID2Textbox;
        private System.Windows.Forms.TextBox CarName1Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CarModel1Textbox;
        private System.Windows.Forms.TextBox CarQuantity1Textbox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label RentedCarLebel;
        private System.Windows.Forms.Label DestinationLabel;
    }
}

