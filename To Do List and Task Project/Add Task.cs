using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_and_Task_Project
{
    public partial class Add_Task : Form
    {
        int selected = 0;
        public Add_Task()
        {
            InitializeComponent();
            taskColourPickerComboBox.Text = "Black";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            menu.Show(); this.Close();
        }

        private void deadlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deadlineCheckBox.Checked == true)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void clear()
        {
            taskNameTxt.Text = "";
            taskDescriptionTxt.Text = "";
            deadlineCheckBox.Checked = false;
            taskImagePictureBox.ImageLocation = "";
            taskColourPickerComboBox.Text = "Black";
            taskIDpicker.Value = Convert.ToDecimal(global.ListID.Max() + 1);
        }
        private void Add_Task_Load(object sender, EventArgs e)
        {
            task load = new task();
            load.loadTasks();
            LoadToListBox();
            try
            {
                taskIDpicker.Value = Convert.ToDecimal(global.ListID.Max() + 1);
            }
            catch (Exception)
            {
                taskIDpicker.Value = 1;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (global.ListID.Contains(Convert.ToInt32(taskIDpicker.Value)))
            {
                MessageBox.Show("ID is already occupied.");
            }
            else
            {
                task addTask = new task();
                addTask.createTask(taskIDpicker.Value, taskNameTxt.Text, taskDescriptionTxt.Text, deadlineCheckBox.Checked, dateTimePicker1.Value, taskImagePictureBox.ImageLocation, taskColourPickerComboBox.Text);
                addTask.loadTasks();
                LoadToListBox();
                clear();
            }
        }

        private void taskImportImage_Click(object sender, EventArgs e)
        {
            ImportImageForm importImage = new ImportImageForm();
            importImage.ShowDialog();
            taskImagePictureBox.ImageLocation = global.filepath;
            checkFill();
        }

        private void LoadToListBox()
        {
            missedTaskListBox.Items.Clear();
            taskListBox.Items.Clear();
            foreach (task t in global.globalCurrentListBox)
            {
                if (t.deadlineCheckbox != true)
                {
                    taskListBox.Items.Add($"{t.id}, {t.name} ");
                }
                else
                {
                    taskListBox.Items.Add($"{t.id}, {t.name}, {(t.date - DateTime.Now).ToString("dd")} days left");
                }
            }
            foreach (task t in global.globalMissedListBox)
            {
                if (t.deadlineCheckbox != true)
                {
                    missedTaskListBox.Items.Add($"{t.id},{t.name} ");
                }
                else
                {
                    missedTaskListBox.Items.Add($"{t.id}, {t.name}, {(t.date - DateTime.Now).ToString("dd")} days missed");
                }
            }
        }

        private void taskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox task = (ListBox)sender;
                if (task.Name == "taskListBox" && taskListBox.SelectedItem != null)
                {
                    selected = 1;
                    string[] listItem = taskListBox.SelectedItem.ToString().Split(",");
                    UnselectListBox(1);
                    int index = global.globalCurrentListBox.FindIndex(x => x.id == Convert.ToDecimal(listItem[0])); //used many times throughout the program, found out how to find the index of an object through Alex Filipovici on: https://stackoverflow.com/questions/17995706/how-can-i-get-the-index-of-an-item-in-a-list-in-a-single-step
                    taskIDpicker.Value = global.globalCurrentListBox[index].id;
                    taskNameTxt.Text = global.globalCurrentListBox[index].name;
                    taskDescriptionTxt.Text = global.globalCurrentListBox[index].description;
                    deadlineCheckBox.Checked = global.globalCurrentListBox[index].deadlineCheckbox;
                    if (deadlineCheckBox.Checked == true)
                    {
                        dateTimePicker1.Value = global.globalCurrentListBox[index].date;
                    }
                    taskImagePictureBox.ImageLocation = global.globalCurrentListBox[index].imagePath;
                    taskColourPickerComboBox.Text = global.globalCurrentListBox[index].textColour;
                    checkFill();
                    timeDescriptionLbl.Text = (dateTimePicker1.Value - DateTime.Now).ToString("dd") + " days left";
                }
                else if (task.Name == "missedTaskListBox" && missedTaskListBox.SelectedItem != null)
                {
                    selected = 2;
                    string[] listItem2 = missedTaskListBox.SelectedItem.ToString().Split(",");
                    UnselectListBox(2);
                    int index = global.globalMissedListBox.FindIndex(x => x.id == Convert.ToDecimal(listItem2[0]));
                    taskIDpicker.Value = global.globalMissedListBox[index].id;
                    taskNameTxt.Text = global.globalMissedListBox[index].name;
                    taskDescriptionTxt.Text = global.globalMissedListBox[index].description;
                    deadlineCheckBox.Checked = global.globalMissedListBox[index].deadlineCheckbox;
                    if (deadlineCheckBox.Checked == true)
                    {
                        dateTimePicker1.Value = global.globalMissedListBox[index].date;
                    }
                    taskImagePictureBox.ImageLocation = global.globalMissedListBox[index].imagePath;
                    taskColourPickerComboBox.Text = global.globalMissedListBox[index].textColour;
                    checkFill();
                    timeDescriptionLbl.Text = (dateTimePicker1.Value - DateTime.Now).ToString("dd") + " days missed"; //used also on the 'days left' part, found out the "dd" part of the ToString from: https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a task.");
            }
        }
        private void UnselectListBox(int a)
        {
            if (a == 1)
            {
                missedTaskListBox.SelectedIndex = -1;
            }
            else if (a == 2)
            {
                taskListBox.SelectedIndex = -1;
            }
        }
        private void checkFill()
        {
            if (taskNameTxt.Text.Trim() != "" && taskImagePictureBox.ImageLocation != null)
            {
                AddBtn.Enabled = true;
            }
            else
            {
                AddBtn.Enabled = false;
            }

            if (taskListBox.SelectedItem != null || missedTaskListBox.SelectedItem != null)
            {
                UpdateBtn.Enabled = true;
            }
            else
            {
                UpdateBtn.Enabled = false;
            }
        }

        private void taskNameTxt_TextChanged(object sender, EventArgs e)
        {
            checkFill();
        }

        private void taskColourPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (taskColourPickerComboBox.SelectedItem.ToString())
            {
                case "Red": timeDescriptionLbl.ForeColor = Color.Red; timeRemainingLbl.ForeColor = Color.Red; break;
                case "Black": timeDescriptionLbl.ForeColor = Color.Black; timeRemainingLbl.ForeColor = Color.Black; break;
                case "Green": timeDescriptionLbl.ForeColor = Color.Green; timeRemainingLbl.ForeColor = Color.Green; break;
                case "Blue": timeDescriptionLbl.ForeColor = Color.Blue; timeRemainingLbl.ForeColor = Color.Blue; break;
                case "Orange": timeDescriptionLbl.ForeColor = Color.Orange; timeRemainingLbl.ForeColor = Color.Orange; break;
                case "Yellow": timeDescriptionLbl.ForeColor = Color.Yellow; timeRemainingLbl.ForeColor = Color.Yellow; break;
                case "White": timeDescriptionLbl.ForeColor = Color.White; timeRemainingLbl.ForeColor = Color.White; break;
                case "Pink": timeDescriptionLbl.ForeColor = Color.Pink; timeRemainingLbl.ForeColor = Color.Pink; break;
                case "Purple": timeDescriptionLbl.ForeColor = Color.Purple; timeRemainingLbl.ForeColor = Color.Purple; break;
                case "Brown": timeDescriptionLbl.ForeColor = Color.Brown; timeRemainingLbl.ForeColor = Color.Brown; break;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            task t = new task();
            if (File.Exists("tasks.txt"))
            {
                if (selected == 1)
                {
                    string[] listboxstring = taskListBox.SelectedItem.ToString().Split(",");
                    int index = global.globalCurrentListBox.FindIndex(x => x.id == Convert.ToInt32(listboxstring[0]));
                    global.globalCurrentListBox[index].id = taskIDpicker.Value;
                    global.globalCurrentListBox[index].name = taskNameTxt.Text;
                    global.globalCurrentListBox[index].description = taskDescriptionTxt.Text;
                    global.globalCurrentListBox[index].deadlineCheckbox = deadlineCheckBox.Checked;
                    if (deadlineCheckBox.Checked == true)
                    {
                        global.globalCurrentListBox[index].date = dateTimePicker1.Value;
                    }
                    global.globalCurrentListBox[index].imagePath = taskImagePictureBox.ImageLocation;
                    global.globalCurrentListBox[index].textColour = taskColourPickerComboBox.Text;
                }
                else if (selected == 2)
                {
                    string[] listboxstring = missedTaskListBox.SelectedItem.ToString().Split(",");
                    int index = global.globalMissedListBox.FindIndex(x => x.id == Convert.ToInt32(listboxstring[0]));
                    global.globalMissedListBox[index].id = taskIDpicker.Value;
                    global.globalMissedListBox[index].name = taskNameTxt.Text;
                    global.globalMissedListBox[index].description = taskDescriptionTxt.Text;
                    global.globalMissedListBox[index].deadlineCheckbox = deadlineCheckBox.Checked;
                    if (deadlineCheckBox.Checked == true)
                    {
                        global.globalMissedListBox[index].date = dateTimePicker1.Value;
                    }
                    global.globalMissedListBox[index].imagePath = taskImagePictureBox.ImageLocation;
                    global.globalMissedListBox[index].textColour = taskColourPickerComboBox.Text;

                }
            }
            UpdateBtn.Enabled = false;
            t.updateFile();
            LoadToListBox();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            task t = new task();
            if (taskListBox.SelectedItem != null)
            {
                try
                {
                    string[] item = taskListBox.SelectedItem.ToString().Split(",");
                    int index = global.globalCurrentListBox.FindIndex(x => x.id == Convert.ToInt32(item[0]));
                    global.globalCurrentListBox.RemoveAt(index);
                    taskListBox.Items.RemoveAt(taskListBox.SelectedIndex);
                    t.updateFile();
                    LoadToListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }
            else if (missedTaskListBox.SelectedItem != null)
            {
                try
                {
                    string[] item = missedTaskListBox.SelectedItem.ToString().Split(",");
                    int index = global.globalMissedListBox.FindIndex(x => x.id == Convert.ToInt32(item[0]));
                    global.globalMissedListBox.RemoveAt(index);
                    missedTaskListBox.Items.RemoveAt(missedTaskListBox.SelectedIndex);
                    t.updateFile();
                    LoadToListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }
        }
    }
}

