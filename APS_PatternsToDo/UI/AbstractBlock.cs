using APS_PatternsToDo.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    abstract class Block : IToDoImplement
    {
        
        IToDoItem item;
        Button addButton;
        Button deleteButton;


        public abstract void setItem();

        public void RenderItem(Form form)
        {
            
            Label label = new Label();
            label.Text = item.getTask();
            label.Location = new System.Drawing.Point(50, 50);
            form.Controls.Add(label);
        }

        public void setTask(string task)
        {
            item.setTask(task);
        }
    }
}
