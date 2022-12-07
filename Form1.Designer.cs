namespace Campus
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
            this.AddCampusBtn = new System.Windows.Forms.Button();
            this.UniversityNameTextBox = new System.Windows.Forms.TextBox();
            this.RevenuePerMonthTextBox = new System.Windows.Forms.TextBox();
            this.AmountOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.AmountOfPersonalTextBox = new System.Windows.Forms.TextBox();
            this.AmountOfRoomsTextBox = new System.Windows.Forms.TextBox();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.UniversityNameLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.AmountOfRoomsLabel = new System.Windows.Forms.Label();
            this.AmountOfPersonalLabel = new System.Windows.Forms.Label();
            this.AmountOfStudentsLabel = new System.Windows.Forms.Label();
            this.RevenuePerMonthLabel = new System.Windows.Forms.Label();
            this.SavedCampusesLabel = new System.Windows.Forms.Label();
            this.SavedCampusesComboBox = new System.Windows.Forms.ComboBox();
            this.AddRoomsTextBox = new System.Windows.Forms.TextBox();
            this.AddOrRemoveStudentsTextBox = new System.Windows.Forms.TextBox();
            this.RevenuePeriodComboBox = new System.Windows.Forms.ComboBox();
            this.CloneCampusBtn = new System.Windows.Forms.Button();
            this.SelectedCampusLabel = new System.Windows.Forms.Label();
            this.AddRoomsBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.RemoveStudentsBtn = new System.Windows.Forms.Button();
            this.CalculateRevenueBtn = new System.Windows.Forms.Button();
            this.ShowInfoBtn = new System.Windows.Forms.Button();
            this.AddDiningRoomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCampusBtn
            // 
            this.AddCampusBtn.Location = new System.Drawing.Point(12, 221);
            this.AddCampusBtn.Name = "AddCampusBtn";
            this.AddCampusBtn.Size = new System.Drawing.Size(111, 29);
            this.AddCampusBtn.TabIndex = 0;
            this.AddCampusBtn.Text = "Add Campus";
            this.AddCampusBtn.UseVisualStyleBackColor = true;
            this.AddCampusBtn.Click += new System.EventHandler(this.AddCampusBtn_Click);
            // 
            // UniversityNameTextBox
            // 
            this.UniversityNameTextBox.Location = new System.Drawing.Point(12, 14);
            this.UniversityNameTextBox.Name = "UniversityNameTextBox";
            this.UniversityNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.UniversityNameTextBox.TabIndex = 1;
            // 
            // RevenuePerMonthTextBox
            // 
            this.RevenuePerMonthTextBox.Location = new System.Drawing.Point(12, 179);
            this.RevenuePerMonthTextBox.Name = "RevenuePerMonthTextBox";
            this.RevenuePerMonthTextBox.Size = new System.Drawing.Size(125, 27);
            this.RevenuePerMonthTextBox.TabIndex = 2;
            // 
            // AmountOfStudentsTextBox
            // 
            this.AmountOfStudentsTextBox.Location = new System.Drawing.Point(12, 146);
            this.AmountOfStudentsTextBox.Name = "AmountOfStudentsTextBox";
            this.AmountOfStudentsTextBox.Size = new System.Drawing.Size(125, 27);
            this.AmountOfStudentsTextBox.TabIndex = 3;
            // 
            // AmountOfPersonalTextBox
            // 
            this.AmountOfPersonalTextBox.Location = new System.Drawing.Point(12, 113);
            this.AmountOfPersonalTextBox.Name = "AmountOfPersonalTextBox";
            this.AmountOfPersonalTextBox.Size = new System.Drawing.Size(125, 27);
            this.AmountOfPersonalTextBox.TabIndex = 4;
            // 
            // AmountOfRoomsTextBox
            // 
            this.AmountOfRoomsTextBox.Location = new System.Drawing.Point(12, 80);
            this.AmountOfRoomsTextBox.Name = "AmountOfRoomsTextBox";
            this.AmountOfRoomsTextBox.Size = new System.Drawing.Size(125, 27);
            this.AmountOfRoomsTextBox.TabIndex = 5;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(12, 47);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(125, 27);
            this.AdressTextBox.TabIndex = 6;
            // 
            // UniversityNameLabel
            // 
            this.UniversityNameLabel.AutoSize = true;
            this.UniversityNameLabel.Location = new System.Drawing.Point(158, 14);
            this.UniversityNameLabel.Name = "UniversityNameLabel";
            this.UniversityNameLabel.Size = new System.Drawing.Size(117, 20);
            this.UniversityNameLabel.TabIndex = 7;
            this.UniversityNameLabel.Text = "University Name";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(158, 50);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(53, 20);
            this.AdressLabel.TabIndex = 8;
            this.AdressLabel.Text = "Adress";
            // 
            // AmountOfRoomsLabel
            // 
            this.AmountOfRoomsLabel.AutoSize = true;
            this.AmountOfRoomsLabel.Location = new System.Drawing.Point(158, 80);
            this.AmountOfRoomsLabel.Name = "AmountOfRoomsLabel";
            this.AmountOfRoomsLabel.Size = new System.Drawing.Size(132, 20);
            this.AmountOfRoomsLabel.TabIndex = 9;
            this.AmountOfRoomsLabel.Text = "Amount Of Rooms";
            // 
            // AmountOfPersonalLabel
            // 
            this.AmountOfPersonalLabel.AutoSize = true;
            this.AmountOfPersonalLabel.Location = new System.Drawing.Point(158, 116);
            this.AmountOfPersonalLabel.Name = "AmountOfPersonalLabel";
            this.AmountOfPersonalLabel.Size = new System.Drawing.Size(141, 20);
            this.AmountOfPersonalLabel.TabIndex = 10;
            this.AmountOfPersonalLabel.Text = "Amount Of Personal";
            // 
            // AmountOfStudentsLabel
            // 
            this.AmountOfStudentsLabel.AutoSize = true;
            this.AmountOfStudentsLabel.Location = new System.Drawing.Point(158, 153);
            this.AmountOfStudentsLabel.Name = "AmountOfStudentsLabel";
            this.AmountOfStudentsLabel.Size = new System.Drawing.Size(143, 20);
            this.AmountOfStudentsLabel.TabIndex = 11;
            this.AmountOfStudentsLabel.Text = "Amount Of Students";
            // 
            // RevenuePerMonthLabel
            // 
            this.RevenuePerMonthLabel.AutoSize = true;
            this.RevenuePerMonthLabel.Location = new System.Drawing.Point(158, 186);
            this.RevenuePerMonthLabel.Name = "RevenuePerMonthLabel";
            this.RevenuePerMonthLabel.Size = new System.Drawing.Size(136, 20);
            this.RevenuePerMonthLabel.TabIndex = 12;
            this.RevenuePerMonthLabel.Text = "Revenue Per Month";
            // 
            // SavedCampusesLabel
            // 
            this.SavedCampusesLabel.AutoSize = true;
            this.SavedCampusesLabel.Location = new System.Drawing.Point(637, 14);
            this.SavedCampusesLabel.Name = "SavedCampusesLabel";
            this.SavedCampusesLabel.Size = new System.Drawing.Size(120, 20);
            this.SavedCampusesLabel.TabIndex = 13;
            this.SavedCampusesLabel.Text = "Saved Campuses";
            // 
            // SavedCampusesComboBox
            // 
            this.SavedCampusesComboBox.FormattingEnabled = true;
            this.SavedCampusesComboBox.Location = new System.Drawing.Point(606, 46);
            this.SavedCampusesComboBox.Name = "SavedCampusesComboBox";
            this.SavedCampusesComboBox.Size = new System.Drawing.Size(151, 28);
            this.SavedCampusesComboBox.TabIndex = 14;
            // 
            // AddRoomsTextBox
            // 
            this.AddRoomsTextBox.Location = new System.Drawing.Point(663, 221);
            this.AddRoomsTextBox.Name = "AddRoomsTextBox";
            this.AddRoomsTextBox.Size = new System.Drawing.Size(125, 27);
            this.AddRoomsTextBox.TabIndex = 15;
            // 
            // AddOrRemoveStudentsTextBox
            // 
            this.AddOrRemoveStudentsTextBox.Location = new System.Drawing.Point(663, 267);
            this.AddOrRemoveStudentsTextBox.Name = "AddOrRemoveStudentsTextBox";
            this.AddOrRemoveStudentsTextBox.Size = new System.Drawing.Size(125, 27);
            this.AddOrRemoveStudentsTextBox.TabIndex = 16;
            // 
            // RevenuePeriodComboBox
            // 
            this.RevenuePeriodComboBox.FormattingEnabled = true;
            this.RevenuePeriodComboBox.Items.AddRange(new object[] {
            "Month",
            "HalfYear",
            "Year"});
            this.RevenuePeriodComboBox.Location = new System.Drawing.Point(663, 330);
            this.RevenuePeriodComboBox.Name = "RevenuePeriodComboBox";
            this.RevenuePeriodComboBox.Size = new System.Drawing.Size(125, 28);
            this.RevenuePeriodComboBox.TabIndex = 17;
            this.RevenuePeriodComboBox.Text = "Month";
            // 
            // CloneCampusBtn
            // 
            this.CloneCampusBtn.Location = new System.Drawing.Point(558, 80);
            this.CloneCampusBtn.Name = "CloneCampusBtn";
            this.CloneCampusBtn.Size = new System.Drawing.Size(199, 29);
            this.CloneCampusBtn.TabIndex = 18;
            this.CloneCampusBtn.Text = "Clone Selected Campus";
            this.CloneCampusBtn.UseVisualStyleBackColor = true;
            this.CloneCampusBtn.Click += new System.EventHandler(this.CloneCampusBtn_Click);
            // 
            // SelectedCampusLabel
            // 
            this.SelectedCampusLabel.AutoSize = true;
            this.SelectedCampusLabel.Location = new System.Drawing.Point(458, 47);
            this.SelectedCampusLabel.Name = "SelectedCampusLabel";
            this.SelectedCampusLabel.Size = new System.Drawing.Size(123, 20);
            this.SelectedCampusLabel.TabIndex = 19;
            this.SelectedCampusLabel.Text = "Selected Campus";
            // 
            // AddRoomsBtn
            // 
            this.AddRoomsBtn.Location = new System.Drawing.Point(519, 219);
            this.AddRoomsBtn.Name = "AddRoomsBtn";
            this.AddRoomsBtn.Size = new System.Drawing.Size(111, 29);
            this.AddRoomsBtn.TabIndex = 20;
            this.AddRoomsBtn.Text = "Add Room(s)";
            this.AddRoomsBtn.UseVisualStyleBackColor = true;
            this.AddRoomsBtn.Click += new System.EventHandler(this.AddRoomsBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(485, 265);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(160, 29);
            this.AddStudentBtn.TabIndex = 21;
            this.AddStudentBtn.Text = "Add Student(s)";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // RemoveStudentsBtn
            // 
            this.RemoveStudentsBtn.Location = new System.Drawing.Point(293, 265);
            this.RemoveStudentsBtn.Name = "RemoveStudentsBtn";
            this.RemoveStudentsBtn.Size = new System.Drawing.Size(170, 29);
            this.RemoveStudentsBtn.TabIndex = 22;
            this.RemoveStudentsBtn.Text = "Remove Student(s)";
            this.RemoveStudentsBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentsBtn.Click += new System.EventHandler(this.RemoveStudentsBtn_Click);
            // 
            // CalculateRevenueBtn
            // 
            this.CalculateRevenueBtn.Location = new System.Drawing.Point(458, 330);
            this.CalculateRevenueBtn.Name = "CalculateRevenueBtn";
            this.CalculateRevenueBtn.Size = new System.Drawing.Size(170, 29);
            this.CalculateRevenueBtn.TabIndex = 23;
            this.CalculateRevenueBtn.Text = "Calculate Revenue";
            this.CalculateRevenueBtn.UseVisualStyleBackColor = true;
            this.CalculateRevenueBtn.Click += new System.EventHandler(this.CalculateRevenueBtn_Click);
            // 
            // ShowInfoBtn
            // 
            this.ShowInfoBtn.Location = new System.Drawing.Point(621, 116);
            this.ShowInfoBtn.Name = "ShowInfoBtn";
            this.ShowInfoBtn.Size = new System.Drawing.Size(124, 30);
            this.ShowInfoBtn.TabIndex = 24;
            this.ShowInfoBtn.Text = "Show Full Info";
            this.ShowInfoBtn.UseVisualStyleBackColor = true;
            this.ShowInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // AddDiningRoomBtn
            // 
            this.AddDiningRoomBtn.Location = new System.Drawing.Point(24, 298);
            this.AddDiningRoomBtn.Name = "AddDiningRoomBtn";
            this.AddDiningRoomBtn.Size = new System.Drawing.Size(153, 29);
            this.AddDiningRoomBtn.TabIndex = 25;
            this.AddDiningRoomBtn.Text = "Add dining room";
            this.AddDiningRoomBtn.UseVisualStyleBackColor = true;
            this.AddDiningRoomBtn.Click += new System.EventHandler(this.AddDinningRoomBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDiningRoomBtn);
            this.Controls.Add(this.ShowInfoBtn);
            this.Controls.Add(this.CalculateRevenueBtn);
            this.Controls.Add(this.RemoveStudentsBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.AddRoomsBtn);
            this.Controls.Add(this.SelectedCampusLabel);
            this.Controls.Add(this.CloneCampusBtn);
            this.Controls.Add(this.RevenuePeriodComboBox);
            this.Controls.Add(this.AddOrRemoveStudentsTextBox);
            this.Controls.Add(this.AddRoomsTextBox);
            this.Controls.Add(this.SavedCampusesComboBox);
            this.Controls.Add(this.SavedCampusesLabel);
            this.Controls.Add(this.RevenuePerMonthLabel);
            this.Controls.Add(this.AmountOfStudentsLabel);
            this.Controls.Add(this.AmountOfPersonalLabel);
            this.Controls.Add(this.AmountOfRoomsLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.UniversityNameLabel);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.AmountOfRoomsTextBox);
            this.Controls.Add(this.AmountOfPersonalTextBox);
            this.Controls.Add(this.AmountOfStudentsTextBox);
            this.Controls.Add(this.RevenuePerMonthTextBox);
            this.Controls.Add(this.UniversityNameTextBox);
            this.Controls.Add(this.AddCampusBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddCampusBtn;
        private TextBox UniversityNameTextBox;
        private TextBox RevenuePerMonthTextBox;
        private TextBox AmountOfStudentsTextBox;
        private TextBox AmountOfPersonalTextBox;
        private TextBox AmountOfRoomsTextBox;
        private TextBox AdressTextBox;
        private Label UniversityNameLabel;
        private Label AdressLabel;
        private Label AmountOfRoomsLabel;
        private Label AmountOfPersonalLabel;
        private Label AmountOfStudentsLabel;
        private Label RevenuePerMonthLabel;
        private Label SavedCampusesLabel;
        private ComboBox SavedCampusesComboBox;
        private TextBox AddRoomsTextBox;
        private TextBox AddOrRemoveStudentsTextBox;
        private ComboBox RevenuePeriodComboBox;
        private Button CloneCampusBtn;
        private Label SelectedCampusLabel;
        private Button AddRoomsBtn;
        private Button AddStudentBtn;
        private Button RemoveStudentsBtn;
        private Button CalculateRevenueBtn;
        private Button ShowInfoBtn;
        private Button AddDiningRoomBtn;
    }
}