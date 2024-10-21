namespace To_Do_List_and_Task_Project
{
    partial class menuForm
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
            titleLbl = new Label();
            tasksBtn = new Button();
            toDoListsBtn = new Button();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 26F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            titleLbl.Location = new Point(8, 41);
            titleLbl.Margin = new Padding(2, 0, 2, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(514, 47);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "To-Do Lists and Task Manager";
            // 
            // tasksBtn
            // 
            tasksBtn.FlatStyle = FlatStyle.Flat;
            tasksBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tasksBtn.Location = new Point(216, 110);
            tasksBtn.Margin = new Padding(2, 2, 2, 2);
            tasksBtn.Name = "tasksBtn";
            tasksBtn.Size = new Size(116, 36);
            tasksBtn.TabIndex = 1;
            tasksBtn.Text = "Tasks";
            tasksBtn.UseVisualStyleBackColor = true;
            tasksBtn.Click += tasksBtn_Click;
            // 
            // toDoListsBtn
            // 
            toDoListsBtn.FlatStyle = FlatStyle.Flat;
            toDoListsBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toDoListsBtn.Location = new Point(216, 155);
            toDoListsBtn.Margin = new Padding(2, 2, 2, 2);
            toDoListsBtn.Name = "toDoListsBtn";
            toDoListsBtn.Size = new Size(116, 36);
            toDoListsBtn.TabIndex = 2;
            toDoListsBtn.Text = "To-Do lists";
            toDoListsBtn.UseVisualStyleBackColor = true;
            toDoListsBtn.Click += toDoListsBtn_Click;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 226);
            Controls.Add(toDoListsBtn);
            Controls.Add(tasksBtn);
            Controls.Add(titleLbl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
            Name = "menuForm";
            Text = "Menu";
            Load += menuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button tasksBtn;
        private Button toDoListsBtn;
    }
}