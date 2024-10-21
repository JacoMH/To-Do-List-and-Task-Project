using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_and_Task_Project
{
    internal class global //used a class as a way to share global variables, learnt how to do from user Tommaso Belluzzo, here: https://stackoverflow.com/questions/14368129/how-to-use-global-variables-in-c
    {
        public static List<int> ListID = new List<int>();
        public static List<task> globalMissedListBox = new List<task>(); 
        public static List<task> globalCurrentListBox = new List<task>();
        public static List<task> globalToDoListBox = new List<task>();
        public static string filepath;              //using static variables as you can retrieve the value from the class without creating another instance of it. Learnt from here: https://stackoverflow.com/questions/10795502/what-is-the-use-of-static-variable-in-c-when-to-use-it-why-cant-i-declare-th
        public static List<string> toDoListName = new List<string>();
    }
}
