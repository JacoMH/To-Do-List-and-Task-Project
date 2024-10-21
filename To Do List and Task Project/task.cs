using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_and_Task_Project
{
    internal class task
    {
        public decimal id;
        public string name;
        public string description;
        public bool deadlineCheckbox;
        public DateTime date;
        public string imagePath;
        public string textColour;
        public bool priority;

        //object lists
        public static List<task> currentTaskObjects = new List<task>();
        public static List<task> missedTaskObjects = new List<task>();
        public void createTask(decimal identifcation, string n, string d, bool deadline, DateTime datetime,string img, string colour)
        {
            id = identifcation;
            name = n;
            description = d;
            deadlineCheckbox = deadline;
            date = datetime;
            imagePath = img;
            textColour = colour;

            if (File.Exists("tasks.txt"))
            {
                File.AppendAllText("tasks.txt", $"{id},{name},{description},{deadlineCheckbox},{date.Year}/{date.Month}/{date.Day},{imagePath},{textColour}\n");
            }
        }

        public void loadTasks()
        {
            if (File.Exists("tasks.txt"))
            {
                List<task> currentTaskObjects = new List<task>();
                List<task> missedTaskObjects = new List<task>();
                List<string> strings = new List<string>();
                strings = File.ReadAllLines("tasks.txt").ToList();
                foreach (string s in strings)
                {
                    task t = new task();
                    string[] item = s.Split(',');  //learnt to split words on the current line of the file using and store in the string array here https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
                    global.ListID.Add(Convert.ToInt16(item[0]));

                    //add to object
                    t.id = Convert.ToDecimal(item[0]);
                    t.name = item[1];
                    t.description = item[2];
                    t.deadlineCheckbox = Convert.ToBoolean(item[3]);
                    if (Convert.ToBoolean(item[3]) == true)
                    {
                        t.date = Convert.ToDateTime(item[4]);
                    }
                    t.textColour = item[6];
                    t.imagePath = item[5];
                    if (DateTime.Now.Date < Convert.ToDateTime(item[4]) || t.deadlineCheckbox == false || (Convert.ToDateTime(item[4]).Date - DateTime.Now.Date).ToString("dd") == "00")
                    {
                       currentTaskObjects.Add(t);
                    }
                    else
                    {
                        missedTaskObjects.Add(t);
                    }
                }
                global.globalMissedListBox = missedTaskObjects;
                global.globalCurrentListBox = currentTaskObjects;
            }
        }
        public void updateFile()
        {
            if (File.Exists("tasks.txt"))
            {
                File.WriteAllText("tasks.txt", "");
                foreach(task t in global.globalCurrentListBox)
                {
                    File.AppendAllText("tasks.txt", $"{t.id},{t.name},{t.description},{t.deadlineCheckbox},{t.date.Year}/{t.date.Month}/{t.date.Day},{t.imagePath},{t.textColour}\n");
                }
                foreach (task t in  global.globalMissedListBox)
                {
                    File.AppendAllText("tasks.txt", $"{t.id},{t.name},{t.description},{t.deadlineCheckbox},{t.date.Year}/{t.date.Month}/{t.date.Day},{t.imagePath},{t.textColour}\n");
                }
            }
            global.globalCurrentListBox.Clear();
            global.globalMissedListBox.Clear();
            loadTasks();
        }
        
        public void toDoTaskAddToFile(string a, decimal identification, string n, string desc, bool p, string img, string colour)
        {
            id = identification;
            name = n;
            description = desc;
            priority = p;
            imagePath = img;
            textColour = colour;
            if (File.Exists($"to-do/{a}.txt"))
            {
                File.AppendAllText($"to-do/{a}.txt", $"{id},{name},{description},{imagePath},{textColour},{priority}\n");
            }
        }

        public void toDoTaskUpdateFile(string a)
        {
            if (File.Exists($"to-do/{a}.txt"))
            {
                File.WriteAllText($"to-do/{a}.txt", "");
                foreach(task t in global.globalToDoListBox)
                {
                    File.AppendAllText($"to-do/{a}.txt", $"{t.id},{t.name},{t.description},{t.imagePath},{t.textColour},{t.priority}\n");
                }
            }
            global.globalToDoListBox.Clear();
        }
    }
}
