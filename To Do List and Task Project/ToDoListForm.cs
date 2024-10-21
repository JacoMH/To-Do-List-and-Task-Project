using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_and_Task_Project
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
            taskColourPickerComboBox.Text = "Black";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (global.ListID.Contains(Convert.ToInt32(taskIDpicker.Value)))
            {
                MessageBox.Show("ID is already occupied.");
            }
            else
            {
                task t = new task();
                t.toDoTaskAddToFile(toDoListComboBox.Text, taskIDpicker.Value, taskNameTxt.Text, taskDescriptionTxt.Text, priorityTask.Checked, taskImagePictureBox.ImageLocation, taskColourPickerComboBox.Text);
                loadToDo2();
            }
            clear();
        }

        private void createListBtn_Click(object sender, EventArgs e)
        {
            if (global.toDoListName.Contains(listName.Text))
            {
                MessageBox.Show("List Already Exists.");
            }
            else
            {
                File.Create($"to-do/{listName.Text}.txt").Close(); //found how to close the file after creating it here as it was causing errors in other parts of the program, from user Beyondo: https://stackoverflow.com/questions/5156254/closing-a-file-after-file-create
                File.AppendAllText("todoListNames.txt", $"{listName.Text}\n");
                loadToDo();
                firstItemComboBox();
            }
            listName.Text = "";
        }
        private void toDoListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            global.ListID.Clear();
            global.filepath = "";
            loadToDo2();
            clear();
            enableDeleteBtn();
        }

        public void enableDeleteBtn()
        {
            if (toDoListComboBox.Text.Trim() != null)
            {
                toDoListRemoveBtn.Enabled = true;
            }
            else
            {
                toDoListRemoveBtn.Enabled = false;
            }
        }
        public void loadToDo()
        {
            if (File.Exists("todoListNames.txt"))
            {
                global.toDoListName.Clear();
                toDoListComboBox.Items.Clear();
                global.toDoListName = File.ReadAllLines("todoListNames.txt").ToList();
                foreach (string item in global.toDoListName)
                {
                    toDoListComboBox.Items.Add(item);
                }
            }
            loadToListBox();
        }
        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            loadToDo();
            firstItemComboBox();
        }

        private void firstItemComboBox()
        {
            try
            {
                toDoListComboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                toDoListComboBox.SelectedIndex = -1;
            }
        }
        private void loadToListBox()
        {
            toDoListBox.Items.Clear();
            foreach (task t in global.globalToDoListBox)
            {
                toDoListBox.Items.Add($"{t.id}, {t.name}, Priority:{t.priority}");
            }
        }

        private void loadToDo2()
        {
            if (File.Exists($"to-do/{toDoListComboBox.Text}.txt"))
            {
                global.globalToDoListBox.Clear();
                List<string> items = File.ReadAllLines($"to-do/{toDoListComboBox.Text}.txt").ToList();
                foreach (string item in items)
                {
                    string[] splitItem = item.Split(",");
                    if (Convert.ToBoolean(splitItem[5]) == true)
                    {
                        task t = new task();
                        t.id = Convert.ToDecimal(splitItem[0]); global.ListID.Add(Convert.ToInt32(splitItem[0]));
                        t.name = splitItem[1].ToString();
                        t.description = splitItem[2].ToString();
                        t.priority = Convert.ToBoolean(splitItem[5]);
                        t.imagePath = splitItem[3].ToString();
                        t.textColour = splitItem[4].ToString();
                        global.globalToDoListBox.Add(t);
                    }
                }
                foreach (string item in items)
                {
                    string[] splitItem = item.Split(",");

                    if (Convert.ToBoolean(splitItem[5]) == false)
                    {
                        task t = new task();
                        t.id = Convert.ToDecimal(splitItem[0]); global.ListID.Add(Convert.ToInt32(splitItem[0]));
                        t.name = splitItem[1].ToString();
                        t.description = splitItem[2].ToString();
                        t.priority = Convert.ToBoolean(splitItem[5]);
                        t.imagePath = splitItem[3].ToString();
                        t.textColour = splitItem[4].ToString();
                        global.globalToDoListBox.Add(t);
                    }
                }
                loadToListBox();
            }
        }

        private void checkFill()
        {
            if (taskNameTxt.Text.Trim() != "" && taskImagePictureBox.ImageLocation != "")
            {
                AddBtn.Enabled = true;
            }
            else
            {
                AddBtn.Enabled = false;
            }
        }

        private void clear()
        {
            taskNameTxt.Text = "";
            taskDescriptionTxt.Text = "";
            priorityTask.Checked = false;
            taskImagePictureBox.ImageLocation = "";
            taskColourPickerComboBox.Text = "Black";
            taskTitle.Text = "<name>";
            taskTitle.ForeColor = Color.Black;
            try
            {
                taskIDpicker.Value = Convert.ToDecimal(global.ListID.Max() + 1);
            }
            catch (Exception)
            {
                taskIDpicker.Value = 1;
            }
        }
        private void taskNameTxt_TextChanged(object sender, EventArgs e)
        {
            checkFill();
        }

        private void taskImportImage_Click(object sender, EventArgs e)
        {
            ImportImageForm importimage = new ImportImageForm();
            importimage.ShowDialog();
            taskImagePictureBox.ImageLocation = global.filepath;
            checkFill();
        }

        private void listName_TextChanged(object sender, EventArgs e)
        {
            if (listName.Text.Trim() == "")
            {
                createListBtn.Enabled = false;
            }
            else
            {
                createListBtn.Enabled = true;
            }
        }

        private void toDoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] item = toDoListBox.SelectedItem.ToString().Split(",");
                int index = global.globalToDoListBox.FindIndex(x => x.id == Convert.ToDecimal(item[0]));
                taskIDpicker.Value = global.globalToDoListBox[index].id;
                taskNameTxt.Text = global.globalToDoListBox[index].name; taskTitle.Text = global.globalToDoListBox[index].name;
                taskDescriptionTxt.Text = global.globalToDoListBox[index].description;
                priorityTask.Checked = global.globalToDoListBox[index].priority;
                taskImagePictureBox.ImageLocation = global.globalToDoListBox[index].imagePath;
                taskColourPickerComboBox.Text = global.globalToDoListBox[index].textColour;
                checkFill();
                checkUpdateBtnEnabled();

                if (toDoListBox.SelectedIndex != null)
                {
                    removeFromListBox.Enabled = true;
                }
                else
                {
                    removeFromListBox.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item.");
            }

        }

        private void checkUpdateBtnEnabled()
        {
            if (toDoListBox.SelectedItem != null)
            {
                UpdateBtn.Enabled = true;
            }
            else
            {
                UpdateBtn.Enabled = false;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists($"to-do/{toDoListComboBox.Text}.txt"))
            {
                task t = new task();
                string[] listboxstring = toDoListBox.SelectedItem.ToString().Split(",");
                int index = global.globalToDoListBox.FindIndex(x => x.id == Convert.ToInt32(listboxstring[0]));
                global.globalToDoListBox[index].id = taskIDpicker.Value;
                global.globalToDoListBox[index].name = taskNameTxt.Text;
                global.globalToDoListBox[index].description = taskDescriptionTxt.Text;
                global.globalToDoListBox[index].priority = priorityTask.Checked;
                global.globalToDoListBox[index].imagePath = taskImagePictureBox.ImageLocation;
                global.globalToDoListBox[index].textColour = taskColourPickerComboBox.Text;
                t.toDoTaskUpdateFile(toDoListComboBox.Text);
                loadToDo2();
                clear();
                UpdateBtn.Enabled = false;
            }
        }

        private void removeFromListBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists($"to-do/{toDoListComboBox.Text}.txt"))
                {
                    string[] item = toDoListBox.SelectedItem.ToString().Split(",");
                    int index = global.globalToDoListBox.FindIndex(x => x.id == Convert.ToInt32(item[0])); //
                    global.globalToDoListBox.RemoveAt(index);
                    File.WriteAllText($"to-do/{toDoListComboBox.Text}.txt", "");
                    foreach (task t in global.globalToDoListBox)
                    {
                        File.AppendAllText($"to-do/{toDoListComboBox.Text}.txt", $"{t.id},{t.name},{t.description},{t.imagePath},{t.textColour},{t.priority}");
                    }
                    loadToDo2();
                    clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an Item.");
            }
        }

        private void toDoListRemoveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists($"to-do/{toDoListComboBox.Text}.txt"))
            {
                File.Delete($"to-do/{toDoListComboBox.Text}.txt");
            }
            if (File.Exists("todoListNames.txt"))
            {

                File.WriteAllText("todoListNames.txt", "");
                global.toDoListName.Remove(toDoListComboBox.Text);
                foreach (string item in global.toDoListName)
                {
                    File.AppendAllText("todoListNames.txt", $"{item}\n");
                }
                loadToDo();
                clear();
                firstItemComboBox();
            }
        }

        private void taskColourPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (taskColourPickerComboBox.SelectedItem.ToString())
            {
                case "Red": taskTitle.ForeColor = Color.Red; break;
                case "Black": taskTitle.ForeColor = Color.Black; break;
                case "Green": taskTitle.ForeColor = Color.Green; break;
                case "Blue": taskTitle.ForeColor = Color.Blue; break;
                case "Orange": taskTitle.ForeColor = Color.Orange; break;
                case "Yellow": taskTitle.ForeColor = Color.Yellow; break;
                case "White": taskTitle.ForeColor = Color.White; break;
                case "Pink": taskTitle.ForeColor = Color.Pink; break;
                case "Purple": taskTitle.ForeColor = Color.Purple; break;
                case "Brown": taskTitle.ForeColor = Color.Brown; break;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            menu.Show(); this.Close();
        }
    }
}
