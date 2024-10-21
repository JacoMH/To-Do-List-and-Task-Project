namespace To_Do_List_and_Task_Project
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void tasksBtn_Click(object sender, EventArgs e)
        {
            Add_Task task = new Add_Task();
            this.Hide(); task.Show();
        }

        private void toDoListsBtn_Click(object sender, EventArgs e)
        {
            ToDoListForm toDo = new ToDoListForm();
            toDo.Show(); this.Hide();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }
    }
}