namespace To_Do_List_and_Task_Project
{
    partial class ToDoListForm
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
            toDoListBox = new ListBox();
            toDoListLbl = new Label();
            toDoListComboBox = new ComboBox();
            taskIDlbl = new Label();
            taskIDpicker = new NumericUpDown();
            taskDescriptionLbl = new Label();
            taskNameLbl = new Label();
            taskDescriptionTxt = new TextBox();
            taskNameTxt = new TextBox();
            taskImportImage = new Button();
            colourPickerLbl = new Label();
            taskColourPickerComboBox = new ComboBox();
            priorityTask = new CheckBox();
            taskImagePictureBox = new PictureBox();
            UpdateBtn = new Button();
            AddBtn = new Button();
            backBtn = new Button();
            label1 = new Label();
            createListBtn = new Button();
            listName = new TextBox();
            removeFromListBox = new Button();
            toDoListRemoveBtn = new Button();
            taskTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)taskIDpicker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // toDoListBox
            // 
            toDoListBox.FormattingEnabled = true;
            toDoListBox.ItemHeight = 15;
            toDoListBox.Location = new Point(340, 57);
            toDoListBox.Margin = new Padding(2);
            toDoListBox.Name = "toDoListBox";
            toDoListBox.Size = new Size(236, 334);
            toDoListBox.TabIndex = 0;
            toDoListBox.SelectedIndexChanged += toDoListBox_SelectedIndexChanged;
            // 
            // toDoListLbl
            // 
            toDoListLbl.AutoSize = true;
            toDoListLbl.Location = new Point(340, 40);
            toDoListLbl.Margin = new Padding(2, 0, 2, 0);
            toDoListLbl.Name = "toDoListLbl";
            toDoListLbl.Size = new Size(63, 15);
            toDoListLbl.TabIndex = 1;
            toDoListLbl.Text = "To-Do List:";
            // 
            // toDoListComboBox
            // 
            toDoListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toDoListComboBox.FormattingEnabled = true;
            toDoListComboBox.Location = new Point(78, 40);
            toDoListComboBox.Margin = new Padding(2);
            toDoListComboBox.Name = "toDoListComboBox";
            toDoListComboBox.Size = new Size(129, 23);
            toDoListComboBox.TabIndex = 2;
            toDoListComboBox.SelectedIndexChanged += toDoListComboBox_SelectedIndexChanged;
            // 
            // taskIDlbl
            // 
            taskIDlbl.AutoSize = true;
            taskIDlbl.Location = new Point(24, 77);
            taskIDlbl.Margin = new Padding(2, 0, 2, 0);
            taskIDlbl.Name = "taskIDlbl";
            taskIDlbl.Size = new Size(46, 15);
            taskIDlbl.TabIndex = 31;
            taskIDlbl.Text = "Task ID:";
            // 
            // taskIDpicker
            // 
            taskIDpicker.Location = new Point(78, 76);
            taskIDpicker.Margin = new Padding(2);
            taskIDpicker.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            taskIDpicker.Name = "taskIDpicker";
            taskIDpicker.Size = new Size(42, 23);
            taskIDpicker.TabIndex = 30;
            taskIDpicker.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // taskDescriptionLbl
            // 
            taskDescriptionLbl.AutoSize = true;
            taskDescriptionLbl.Location = new Point(0, 128);
            taskDescriptionLbl.Margin = new Padding(2, 0, 2, 0);
            taskDescriptionLbl.Name = "taskDescriptionLbl";
            taskDescriptionLbl.Size = new Size(70, 15);
            taskDescriptionLbl.TabIndex = 29;
            taskDescriptionLbl.Text = "Description:";
            // 
            // taskNameLbl
            // 
            taskNameLbl.AutoSize = true;
            taskNameLbl.Location = new Point(30, 100);
            taskNameLbl.Margin = new Padding(2, 0, 2, 0);
            taskNameLbl.Name = "taskNameLbl";
            taskNameLbl.Size = new Size(42, 15);
            taskNameLbl.TabIndex = 28;
            taskNameLbl.Text = "Name:";
            // 
            // taskDescriptionTxt
            // 
            taskDescriptionTxt.Location = new Point(78, 127);
            taskDescriptionTxt.Margin = new Padding(2);
            taskDescriptionTxt.Multiline = true;
            taskDescriptionTxt.Name = "taskDescriptionTxt";
            taskDescriptionTxt.Size = new Size(171, 41);
            taskDescriptionTxt.TabIndex = 27;
            // 
            // taskNameTxt
            // 
            taskNameTxt.Location = new Point(78, 100);
            taskNameTxt.Margin = new Padding(2);
            taskNameTxt.Name = "taskNameTxt";
            taskNameTxt.Size = new Size(106, 23);
            taskNameTxt.TabIndex = 26;
            taskNameTxt.TextChanged += taskNameTxt_TextChanged;
            // 
            // taskImportImage
            // 
            taskImportImage.FlatStyle = FlatStyle.Flat;
            taskImportImage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            taskImportImage.Location = new Point(48, 223);
            taskImportImage.Margin = new Padding(2);
            taskImportImage.Name = "taskImportImage";
            taskImportImage.Size = new Size(136, 36);
            taskImportImage.TabIndex = 32;
            taskImportImage.Text = "import image";
            taskImportImage.UseVisualStyleBackColor = true;
            taskImportImage.Click += taskImportImage_Click;
            // 
            // colourPickerLbl
            // 
            colourPickerLbl.AutoSize = true;
            colourPickerLbl.Location = new Point(8, 281);
            colourPickerLbl.Margin = new Padding(2, 0, 2, 0);
            colourPickerLbl.Name = "colourPickerLbl";
            colourPickerLbl.Size = new Size(95, 15);
            colourPickerLbl.TabIndex = 34;
            colourPickerLbl.Text = "Pick Text Colour:";
            // 
            // taskColourPickerComboBox
            // 
            taskColourPickerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            taskColourPickerComboBox.FormattingEnabled = true;
            taskColourPickerComboBox.Items.AddRange(new object[] { "Black", "White", "Orange", "Green", "Purple", "Blue", "Brown" });
            taskColourPickerComboBox.Location = new Point(111, 281);
            taskColourPickerComboBox.Margin = new Padding(2);
            taskColourPickerComboBox.Name = "taskColourPickerComboBox";
            taskColourPickerComboBox.Size = new Size(93, 23);
            taskColourPickerComboBox.TabIndex = 33;
            taskColourPickerComboBox.SelectedIndexChanged += taskColourPickerComboBox_SelectedIndexChanged;
            // 
            // priorityTask
            // 
            priorityTask.AutoSize = true;
            priorityTask.Location = new Point(41, 192);
            priorityTask.Margin = new Padding(2);
            priorityTask.Name = "priorityTask";
            priorityTask.Size = new Size(64, 19);
            priorityTask.TabIndex = 35;
            priorityTask.Text = "Priority";
            priorityTask.UseVisualStyleBackColor = true;
            // 
            // taskImagePictureBox
            // 
            taskImagePictureBox.Location = new Point(601, 64);
            taskImagePictureBox.Margin = new Padding(2);
            taskImagePictureBox.Name = "taskImagePictureBox";
            taskImagePictureBox.Size = new Size(246, 312);
            taskImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            taskImagePictureBox.TabIndex = 36;
            taskImagePictureBox.TabStop = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Enabled = false;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(134, 320);
            UpdateBtn.Margin = new Padding(2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(105, 37);
            UpdateBtn.TabIndex = 41;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Enabled = false;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(15, 320);
            AddBtn.Margin = new Padding(2);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(105, 37);
            AddBtn.TabIndex = 40;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // backBtn
            // 
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.Location = new Point(15, 367);
            backBtn.Margin = new Padding(2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(105, 37);
            backBtn.TabIndex = 39;
            backBtn.Text = "back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 42;
            label1.Text = "To-Do List:";
            // 
            // createListBtn
            // 
            createListBtn.Enabled = false;
            createListBtn.FlatStyle = FlatStyle.Flat;
            createListBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            createListBtn.Location = new Point(218, 6);
            createListBtn.Margin = new Padding(2);
            createListBtn.Name = "createListBtn";
            createListBtn.Size = new Size(105, 27);
            createListBtn.TabIndex = 43;
            createListBtn.Text = "Create List";
            createListBtn.UseVisualStyleBackColor = true;
            createListBtn.Click += createListBtn_Click;
            // 
            // listName
            // 
            listName.Location = new Point(101, 7);
            listName.Margin = new Padding(2);
            listName.Name = "listName";
            listName.Size = new Size(106, 23);
            listName.TabIndex = 44;
            listName.TextChanged += listName_TextChanged;
            // 
            // removeFromListBox
            // 
            removeFromListBox.Enabled = false;
            removeFromListBox.FlatStyle = FlatStyle.Flat;
            removeFromListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            removeFromListBox.Location = new Point(398, 393);
            removeFromListBox.Margin = new Padding(2);
            removeFromListBox.Name = "removeFromListBox";
            removeFromListBox.Size = new Size(105, 26);
            removeFromListBox.TabIndex = 45;
            removeFromListBox.Text = "Remove";
            removeFromListBox.UseVisualStyleBackColor = true;
            removeFromListBox.Click += removeFromListBox_Click;
            // 
            // toDoListRemoveBtn
            // 
            toDoListRemoveBtn.Enabled = false;
            toDoListRemoveBtn.FlatStyle = FlatStyle.Flat;
            toDoListRemoveBtn.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            toDoListRemoveBtn.Location = new Point(211, 40);
            toDoListRemoveBtn.Margin = new Padding(2);
            toDoListRemoveBtn.Name = "toDoListRemoveBtn";
            toDoListRemoveBtn.Size = new Size(118, 23);
            toDoListRemoveBtn.TabIndex = 46;
            toDoListRemoveBtn.Text = "Remove";
            toDoListRemoveBtn.UseVisualStyleBackColor = true;
            toDoListRemoveBtn.Click += toDoListRemoveBtn_Click;
            // 
            // taskTitle
            // 
            taskTitle.AutoSize = true;
            taskTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            taskTitle.Location = new Point(666, 36);
            taskTitle.Margin = new Padding(2, 0, 2, 0);
            taskTitle.Name = "taskTitle";
            taskTitle.Size = new Size(85, 25);
            taskTitle.TabIndex = 47;
            taskTitle.Text = "<name>";
            taskTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 419);
            Controls.Add(taskTitle);
            Controls.Add(toDoListRemoveBtn);
            Controls.Add(removeFromListBox);
            Controls.Add(listName);
            Controls.Add(createListBtn);
            Controls.Add(label1);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(backBtn);
            Controls.Add(taskImagePictureBox);
            Controls.Add(priorityTask);
            Controls.Add(colourPickerLbl);
            Controls.Add(taskColourPickerComboBox);
            Controls.Add(taskImportImage);
            Controls.Add(taskIDlbl);
            Controls.Add(taskIDpicker);
            Controls.Add(taskDescriptionLbl);
            Controls.Add(taskNameLbl);
            Controls.Add(taskDescriptionTxt);
            Controls.Add(taskNameTxt);
            Controls.Add(toDoListComboBox);
            Controls.Add(toDoListLbl);
            Controls.Add(toDoListBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ToDoListForm";
            Text = "To-Do Lists";
            Load += ToDoListForm_Load;
            ((System.ComponentModel.ISupportInitialize)taskIDpicker).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox toDoListBox;
        private Label toDoListLbl;
        private ComboBox toDoListComboBox;
        private Label taskIDlbl;
        private NumericUpDown taskIDpicker;
        private Label taskDescriptionLbl;
        private Label taskNameLbl;
        private TextBox taskDescriptionTxt;
        private TextBox taskNameTxt;
        private Button taskImportImage;
        private Label colourPickerLbl;
        private ComboBox taskColourPickerComboBox;
        private CheckBox priorityTask;
        private PictureBox taskImagePictureBox;
        private Button UpdateBtn;
        private Button AddBtn;
        private Button backBtn;
        private Label label1;
        private Button createListBtn;
        private TextBox listName;
        private Button removeFromListBox;
        private Button toDoListRemoveBtn;
        private Label taskTitle;
    }
}