using APS_PatternsToDo.Controllers;
using APS_PatternsToDo.Items;
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

            ItemsList items = ItemsList.GetInstance();

            AddTask addMenu = new AddTask();
            AddTaskBlock addTaskBlock = new AddTaskBlock();
            addTaskBlock.SetForm(this);
            
            addMenu.InitImplement(addTaskBlock);
            items.AddItem(addMenu);
            

            items.renderList();
        }


    }
}
