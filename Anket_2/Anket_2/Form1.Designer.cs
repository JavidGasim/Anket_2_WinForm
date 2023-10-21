namespace Anket_2
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
            anket_group_box = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            add_button = new Button();
            birth_label = new Label();
            phone_label = new Label();
            email_label = new Label();
            soyad_label = new Label();
            phone_box = new TextBox();
            email_box = new TextBox();
            surname_box = new TextBox();
            name_box = new TextBox();
            ad_label = new Label();
            names_listBox = new ListBox();
            file_name = new TextBox();
            load_button = new Button();
            openFileDialog1 = new OpenFileDialog();
            anket_group_box.SuspendLayout();
            SuspendLayout();
            // 
            // anket_group_box
            // 
            anket_group_box.Controls.Add(dateTimePicker1);
            anket_group_box.Controls.Add(add_button);
            anket_group_box.Controls.Add(birth_label);
            anket_group_box.Controls.Add(phone_label);
            anket_group_box.Controls.Add(email_label);
            anket_group_box.Controls.Add(soyad_label);
            anket_group_box.Controls.Add(phone_box);
            anket_group_box.Controls.Add(email_box);
            anket_group_box.Controls.Add(surname_box);
            anket_group_box.Controls.Add(name_box);
            anket_group_box.Controls.Add(ad_label);
            anket_group_box.Location = new Point(12, 12);
            anket_group_box.Name = "anket_group_box";
            anket_group_box.Size = new Size(447, 426);
            anket_group_box.TabIndex = 0;
            anket_group_box.TabStop = false;
            anket_group_box.Text = "Anket";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(84, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(307, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // add_button
            // 
            add_button.Location = new Point(263, 340);
            add_button.Name = "add_button";
            add_button.Size = new Size(128, 54);
            add_button.TabIndex = 10;
            add_button.Text = "Elave et";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // birth_label
            // 
            birth_label.AutoSize = true;
            birth_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birth_label.Location = new Point(0, 273);
            birth_label.Name = "birth_label";
            birth_label.Size = new Size(78, 28);
            birth_label.TabIndex = 9;
            birth_label.Text = "Dogum";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone_label.Location = new Point(4, 220);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(74, 28);
            phone_label.TabIndex = 8;
            phone_label.Text = "Telefon";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.Location = new Point(6, 166);
            email_label.Name = "email_label";
            email_label.Size = new Size(68, 28);
            email_label.TabIndex = 7;
            email_label.Text = "E-Mail";
            // 
            // soyad_label
            // 
            soyad_label.AutoSize = true;
            soyad_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            soyad_label.Location = new Point(4, 112);
            soyad_label.Name = "soyad_label";
            soyad_label.Size = new Size(67, 28);
            soyad_label.TabIndex = 6;
            soyad_label.Text = "Soyad";
            // 
            // phone_box
            // 
            phone_box.Location = new Point(84, 220);
            phone_box.Name = "phone_box";
            phone_box.Size = new Size(307, 27);
            phone_box.TabIndex = 4;
            phone_box.TextChanged += phone_box_TextChanged;
            // 
            // email_box
            // 
            email_box.Location = new Point(84, 166);
            email_box.Name = "email_box";
            email_box.Size = new Size(307, 27);
            email_box.TabIndex = 3;
            email_box.TextChanged += email_box_TextChanged;
            // 
            // surname_box
            // 
            surname_box.Location = new Point(81, 112);
            surname_box.Name = "surname_box";
            surname_box.Size = new Size(310, 27);
            surname_box.TabIndex = 2;
            surname_box.TextChanged += surname_box_TextChanged;
            // 
            // name_box
            // 
            name_box.Location = new Point(81, 54);
            name_box.Name = "name_box";
            name_box.Size = new Size(310, 27);
            name_box.TabIndex = 1;
            name_box.TextChanged += name_box_TextChanged;
            // 
            // ad_label
            // 
            ad_label.AutoSize = true;
            ad_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ad_label.Location = new Point(22, 54);
            ad_label.Name = "ad_label";
            ad_label.Size = new Size(37, 28);
            ad_label.TabIndex = 0;
            ad_label.Text = "Ad";
            // 
            // names_listBox
            // 
            names_listBox.FormattingEnabled = true;
            names_listBox.ItemHeight = 20;
            names_listBox.Location = new Point(514, 22);
            names_listBox.Name = "names_listBox";
            names_listBox.Size = new Size(257, 304);
            names_listBox.TabIndex = 1;
            // 
            // file_name
            // 
            file_name.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            file_name.ForeColor = SystemColors.ScrollBar;
            file_name.Location = new Point(514, 341);
            file_name.Name = "file_name";
            file_name.Size = new Size(257, 27);
            file_name.TabIndex = 2;
            // 
            // load_button
            // 
            load_button.Location = new Point(514, 377);
            load_button.Name = "load_button";
            load_button.Size = new Size(257, 29);
            load_button.TabIndex = 3;
            load_button.Text = "Load";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(load_button);
            Controls.Add(file_name);
            Controls.Add(names_listBox);
            Controls.Add(anket_group_box);
            Name = "Form1";
            Text = "Anket";
            anket_group_box.ResumeLayout(false);
            anket_group_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox anket_group_box;
        private Label soyad_label;
        private TextBox phone_box;
        private TextBox email_box;
        private TextBox surname_box;
        private TextBox name_box;
        private Label ad_label;
        private Button add_button;
        private Label birth_label;
        private Label phone_label;
        private Label email_label;
        private ListBox names_listBox;
        private TextBox file_name;
        private Button load_button;
        private DateTimePicker dateTimePicker1;
        private OpenFileDialog openFileDialog1;
    }
}