namespace Anket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_male = new System.Windows.Forms.RadioButton();
            this.c_female = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_dot = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.phone_textbox = new System.Windows.Forms.MaskedTextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.country_textbox = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.fathername_textbox = new System.Windows.Forms.TextBox();
            this.label_fathername = new System.Windows.Forms.Label();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.c_male);
            this.groupBox1.Controls.Add(this.c_female);
            this.groupBox1.Controls.Add(this.label_gender);
            this.groupBox1.Controls.Add(this.label_dot);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.phone_textbox);
            this.groupBox1.Controls.Add(this.label_phone);
            this.groupBox1.Controls.Add(this.city_textbox);
            this.groupBox1.Controls.Add(this.label_city);
            this.groupBox1.Controls.Add(this.country_textbox);
            this.groupBox1.Controls.Add(this.label_country);
            this.groupBox1.Controls.Add(this.fathername_textbox);
            this.groupBox1.Controls.Add(this.label_fathername);
            this.groupBox1.Controls.Add(this.surname_textbox);
            this.groupBox1.Controls.Add(this.label_surname);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // c_male
            // 
            this.c_male.AutoSize = true;
            this.c_male.Location = new System.Drawing.Point(272, 298);
            this.c_male.Name = "c_male";
            this.c_male.Size = new System.Drawing.Size(48, 17);
            this.c_male.TabIndex = 16;
            this.c_male.TabStop = true;
            this.c_male.Text = "Male";
            this.c_male.UseVisualStyleBackColor = true;
            // 
            // c_female
            // 
            this.c_female.AutoSize = true;
            this.c_female.Location = new System.Drawing.Point(156, 298);
            this.c_female.Name = "c_female";
            this.c_female.Size = new System.Drawing.Size(59, 17);
            this.c_female.TabIndex = 15;
            this.c_female.TabStop = true;
            this.c_female.Text = "Female";
            this.c_female.UseVisualStyleBackColor = true;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gender.Location = new System.Drawing.Point(70, 295);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(80, 24);
            this.label_gender.TabIndex = 14;
            this.label_gender.Text = "Gender";
            // 
            // label_dot
            // 
            this.label_dot.AutoSize = true;
            this.label_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dot.Location = new System.Drawing.Point(27, 254);
            this.label_dot.Name = "label_dot";
            this.label_dot.Size = new System.Drawing.Size(123, 24);
            this.label_dot.TabIndex = 13;
            this.label_dot.Text = "Date of Birth";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(156, 259);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(215, 20);
            this.DateBox.TabIndex = 12;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(156, 215);
            this.phone_textbox.Mask = "(999) 000-00-00";
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(113, 20);
            this.phone_textbox.TabIndex = 11;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_phone.Location = new System.Drawing.Point(79, 212);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(71, 24);
            this.label_phone.TabIndex = 10;
            this.label_phone.Text = "Phone";
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(156, 181);
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(215, 20);
            this.city_textbox.TabIndex = 9;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_city.Location = new System.Drawing.Point(106, 176);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(44, 24);
            this.label_city.TabIndex = 8;
            this.label_city.Text = "City";
            // 
            // country_textbox
            // 
            this.country_textbox.Location = new System.Drawing.Point(156, 144);
            this.country_textbox.Name = "country_textbox";
            this.country_textbox.Size = new System.Drawing.Size(215, 20);
            this.country_textbox.TabIndex = 7;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_country.Location = new System.Drawing.Point(68, 139);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(82, 24);
            this.label_country.TabIndex = 6;
            this.label_country.Text = "Country";
            // 
            // fathername_textbox
            // 
            this.fathername_textbox.Location = new System.Drawing.Point(156, 104);
            this.fathername_textbox.Name = "fathername_textbox";
            this.fathername_textbox.Size = new System.Drawing.Size(215, 20);
            this.fathername_textbox.TabIndex = 5;
            // 
            // label_fathername
            // 
            this.label_fathername.AutoSize = true;
            this.label_fathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fathername.Location = new System.Drawing.Point(7, 99);
            this.label_fathername.Name = "label_fathername";
            this.label_fathername.Size = new System.Drawing.Size(143, 24);
            this.label_fathername.TabIndex = 4;
            this.label_fathername.Text = "Father\'s name";
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(156, 67);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(215, 20);
            this.surname_textbox.TabIndex = 3;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.Location = new System.Drawing.Point(56, 62);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(94, 24);
            this.label_surname.TabIndex = 2;
            this.label_surname.Text = "Surname";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(156, 31);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(215, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(85, 26);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(65, 24);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // filename_textbox
            // 
            this.filename_textbox.Location = new System.Drawing.Point(116, 38);
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(100, 20);
            this.filename_textbox.TabIndex = 1;
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_btn.Location = new System.Drawing.Point(222, 38);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(28, 438);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(378, 38);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter file name to load user";
            // 
            // add_user_btn
            // 
            this.add_user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_user_btn.Location = new System.Drawing.Point(331, 38);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(75, 23);
            this.add_user_btn.TabIndex = 2;
            this.add_user_btn.Text = "Clear";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.AddUser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 504);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.filename_textbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Anket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_dot;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.MaskedTextBox phone_textbox;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox country_textbox;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox fathername_textbox;
        private System.Windows.Forms.Label label_fathername;
        private System.Windows.Forms.RadioButton c_male;
        private System.Windows.Forms.RadioButton c_female;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox filename_textbox;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_user_btn;
    }
}

