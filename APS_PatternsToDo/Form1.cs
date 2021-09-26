using APS_PatternsToDo.Controllers;
using APS_PatternsToDo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<IToDoImplement> taskList = new List<IToDoImplement>();

            //TODO: delete this
            AddTaskBlock addTask = new AddTaskBlock();
            addTask.SetForm(this);
            addTask.InitBlock(35);
            addTask.SetItem();
            //addTask.RenderItem();

            taskList.Add(addTask);

            foreach (IToDoImplement item in taskList)
            {
                item.RenderItem();
            }
        }


    }
}
