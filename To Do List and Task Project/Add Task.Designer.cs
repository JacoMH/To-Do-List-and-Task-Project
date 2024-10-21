namespace To_Do_List_and_Task_Project
{
    partial class Add_Task
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
            backBtn = new Button();
            taskListBox = new ListBox();
            missedTaskListBox = new ListBox();
            taskNameTxt = new TextBox();
            taskDescriptionTxt = new TextBox();
            deadlineCheckBox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            taskImportImage = new Button();
            taskImagePictureBox = new PictureBox();
            timeRemainingLbl = new Label();
            timeDescriptionLbl = new Label();
            taskColourPickerComboBox = new ComboBox();
            colourPickerLbl = new Label();
            taskNameLbl = new Label();
            taskDescriptionLbl = new Label();
            currentTasksLbl = new Label();
            missedTasksLbl = new Label();
            AddBtn = new Button();
            UpdateBtn = new Button();
            removeBtn = new Button();
            taskIDpicker = new NumericUpDown();
            taskIDlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)taskImagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskIDpicker).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(8, 368);
            backBtn.Margin = new Padding(2, 2, 2, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(105, 37);
            backBtn.TabIndex = 0;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // taskListBox
            // 
            taskListBox.FormattingEnabled = true;
            taskListBox.ItemHeight = 15;
            taskListBox.Location = new Point(332, 32);
            taskListBox.Margin = new Padding(2, 2, 2, 2);
            taskListBox.Name = "taskListBox";
            taskListBox.Size = new Size(213, 139);
            taskListBox.TabIndex = 1;
            taskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // missedTaskListBox
            // 
            missedTaskListBox.FormattingEnabled = true;
            missedTaskListBox.ItemHeight = 15;
            missedTaskListBox.Location = new Point(332, 188);
            missedTaskListBox.Margin = new Padding(2, 2, 2, 2);
            missedTaskListBox.Name = "missedTaskListBox";
            missedTaskListBox.Size = new Size(213, 139);
            missedTaskListBox.TabIndex = 2;
            missedTaskListBox.SelectedIndexChanged += taskListBox_SelectedIndexChanged;
            // 
            // taskNameTxt
            // 
            taskNameTxt.Location = new Point(88, 38);
            taskNameTxt.Margin = new Padding(2, 2, 2, 2);
            taskNameTxt.Name = "taskNameTxt";
            taskNameTxt.Size = new Size(106, 23);
            taskNameTxt.TabIndex = 3;
            taskNameTxt.TextChanged += taskNameTxt_TextChanged;
            // 
            // taskDescriptionTxt
            // 
            taskDescriptionTxt.Location = new Point(88, 67);
            taskDescriptionTxt.Margin = new Padding(2, 2, 2, 2);
            taskDescriptionTxt.Multiline = true;
            taskDescriptionTxt.Name = "taskDescriptionTxt";
            taskDescriptionTxt.Size = new Size(171, 41);
            taskDescriptionTxt.TabIndex = 4;
            // 
            // deadlineCheckBox
            // 
            deadlineCheckBox.AutoSize = true;
            deadlineCheckBox.Location = new Point(15, 119);
            deadlineCheckBox.Margin = new Padding(2, 2, 2, 2);
            deadlineCheckBox.Name = "deadlineCheckBox";
            deadlineCheckBox.Size = new Size(72, 19);
            deadlineCheckBox.TabIndex = 5;
            deadlineCheckBox.Text = "Deadline";
            deadlineCheckBox.UseVisualStyleBackColor = true;
            deadlineCheckBox.CheckedChanged += deadlineCheckBox_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(4, 149);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // taskImportImage
            // 
            taskImportImage.FlatStyle = FlatStyle.Flat;
            taskImportImage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            taskImportImage.Location = new Point(33, 194);
            taskImportImage.Margin = new Padding(2, 2, 2, 2);
            taskImportImage.Name = "taskImportImage";
            taskImportImage.Size = new Size(136, 36);
            taskImportImage.TabIndex = 9;
            taskImportImage.Text = "import image";
            taskImportImage.UseVisualStyleBackColor = true;
            taskImportImage.Click += taskImportImage_Click;
            // 
            // taskImagePictureBox
            // 
            taskImagePictureBox.Location = new Point(598, 38);
            taskImagePictureBox.Margin = new Padding(2, 2, 2, 2);
            taskImagePictureBox.Name = "taskImagePictureBox";
            taskImagePictureBox.Size = new Size(246, 312);
            taskImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            taskImagePictureBox.TabIndex = 10;
            taskImagePictureBox.TabStop = false;
            // 
            // timeRemainingLbl
            // 
            timeRemainingLbl.AutoSize = true;
            timeRemainingLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeRemainingLbl.Location = new Point(644, 11);
            timeRemainingLbl.Margin = new Padding(2, 0, 2, 0);
            timeRemainingLbl.Name = "timeRemainingLbl";
            timeRemainingLbl.Size = new Size(151, 25);
            timeRemainingLbl.TabIndex = 11;
            timeRemainingLbl.Text = "Time Remaining:";
            // 
            // timeDescriptionLbl
            // 
            timeDescriptionLbl.AutoSize = true;
            timeDescriptionLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeDescriptionLbl.Location = new Point(659, 352);
            timeDescriptionLbl.Margin = new Padding(2, 0, 2, 0);
            timeDescriptionLbl.Name = "timeDescriptionLbl";
            timeDescriptionLbl.Size = new Size(76, 25);
            timeDescriptionLbl.TabIndex = 12;
            timeDescriptionLbl.Text = "<here>";
            // 
            // taskColourPickerComboBox
            // 
            taskColourPickerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskColourPickerComboBox.FormattingEnabled = true;
            taskColourPickerComboBox.Items.AddRange(new object[] { "Black", "White", "Orange", "Green", "Purple", "Blue", "Brown" });
            taskColourPickerComboBox.Location = new Point(110, 269);
            taskColourPickerComboBox.Margin = new Padding(2, 2, 2, 2);
            taskColourPickerComboBox.Name = "taskColourPickerComboBox";
            taskColourPickerComboBox.Size = new Size(93, 23);
            taskColourPickerComboBox.TabIndex = 13;
            taskColourPickerComboBox.SelectedIndexChanged += taskColourPickerComboBox_SelectedIndexChanged;
            // 
            // colourPickerLbl
            // 
            colourPickerLbl.AutoSize = true;
            colourPickerLbl.Location = new Point(8, 269);
            colourPickerLbl.Margin = new Padding(2, 0, 2, 0);
            colourPickerLbl.Name = "colourPickerLbl";
            colourPickerLbl.Size = new Size(95, 15);
            colourPickerLbl.TabIndex = 14;
            colourPickerLbl.Text = "Pick Text Colour:";
            // 
            // taskNameLbl
            // 
            taskNameLbl.AutoSize = true;
            taskNameLbl.Location = new Point(39, 38);
            taskNameLbl.Margin = new Padding(2, 0, 2, 0);
            taskNameLbl.Name = "taskNameLbl";
            taskNameLbl.Size = new Size(42, 15);
            taskNameLbl.TabIndex = 17;
            taskNameLbl.Text = "Name:";
            // 
            // taskDescriptionLbl
            // 
            taskDescriptionLbl.AutoSize = true;
            taskDescriptionLbl.Location = new Point(9, 69);
            taskDescriptionLbl.Margin = new Padding(2, 0, 2, 0);
            taskDescriptionLbl.Name = "taskDescriptionLbl";
            taskDescriptionLbl.Size = new Size(70, 15);
            taskDescriptionLbl.TabIndex = 18;
            taskDescriptionLbl.Text = "Description:";
            // 
            // currentTasksLbl
            // 
            currentTasksLbl.AutoSize = true;
            currentTasksLbl.Location = new Point(332, 15);
            currentTasksLbl.Margin = new Padding(2, 0, 2, 0);
            currentTasksLbl.Name = "currentTasksLbl";
            currentTasksLbl.Size = new Size(80, 15);
            currentTasksLbl.TabIndex = 19;
            currentTasksLbl.Text = "Current Tasks:";
            // 
            // missedTasksLbl
            // 
            missedTasksLbl.AutoSize = true;
            missedTasksLbl.Location = new Point(332, 171);
            missedTasksLbl.Margin = new Padding(2, 0, 2, 0);
            missedTasksLbl.Name = "missedTasksLbl";
            missedTasksLbl.Size = new Size(77, 15);
            missedTasksLbl.TabIndex = 20;
            missedTasksLbl.Text = "Missed Tasks:";
            // 
            // AddBtn
            // 
            AddBtn.Enabled = false;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(8, 320);
            AddBtn.Margin = new Padding(2, 2, 2, 2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(105, 37);
            AddBtn.TabIndex = 21;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Enabled = false;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(126, 320);
            UpdateBtn.Margin = new Padding(2, 2, 2, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(105, 37);
            UpdateBtn.TabIndex = 22;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            removeBtn.Location = new Point(393, 334);
            removeBtn.Margin = new Padding(2, 2, 2, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(87, 43);
            removeBtn.TabIndex = 23;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // taskIDpicker
            // 
            taskIDpicker.Location = new Point(88, 16);
            taskIDpicker.Margin = new Padding(2, 2, 2, 2);
            taskIDpicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskIDpicker.Name = "taskIDpicker";
            taskIDpicker.Size = new Size(42, 23);
            taskIDpicker.TabIndex = 24;
            taskIDpicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // taskIDlbl
            // 
            taskIDlbl.AutoSize = true;
            taskIDlbl.Location = new Point(33, 17);
            taskIDlbl.Margin = new Padding(2, 0, 2, 0);
            taskIDlbl.Name = "taskIDlbl";
            taskIDlbl.Size = new Size(46, 15);
            taskIDlbl.TabIndex = 25;
            taskIDlbl.Text = "Task ID:";
            // 
            // Add_Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 412);
            Controls.Add(taskIDlbl);
            Controls.Add(taskIDpicker);
            Controls.Add(removeBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(missedTasksLbl);
            Controls.Add(currentTasksLbl);
            Controls.Add(taskDescriptionLbl);
            Controls.Add(taskNameLbl);
            Controls.Add(colourPickerLbl);
            Controls.Add(taskColourPickerComboBox);
            Controls.Add(timeDescriptionLbl);
            Controls.Add(timeRemainingLbl);
            Controls.Add(taskImagePictureBox);
            Controls.Add(taskImportImage);
            Controls.Add(dateTimePicker1);
            Controls.Add(deadlineCheckBox);
            Controls.Add(taskDescriptionTxt);
            Controls.Add(taskNameTxt);
            Controls.Add(missedTaskListBox);
            Controls.Add(taskListBox);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Add_Task";
            Text = "Add Or View Task";
            Load += Add_Task_Load;
            ((System.ComponentModel.ISupportInitialize)taskImagePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskIDpicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private ListBox taskListBox;
        private ListBox missedTaskListBox;
        private TextBox taskNameTxt;
        private TextBox taskDescriptionTxt;
        private CheckBox deadlineCheckBox;
        private DateTimePicker dateTimePicker1;
        private Button taskImportImage;
        private PictureBox taskImagePictureBox;
        private Label timeRemainingLbl;
        private Label timeDescriptionLbl;
        private ComboBox taskColourPickerComboBox;
        private Label colourPickerLbl;
        private Label taskNameLbl;
        private Label taskDescriptionLbl;
        private Label currentTasksLbl;
        private Label missedTasksLbl;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button removeBtn;
        private NumericUpDown taskIDpicker;
        private Label taskIDlbl;
    }
}