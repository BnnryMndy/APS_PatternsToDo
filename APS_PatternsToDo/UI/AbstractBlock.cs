using APS_PatternsToDo.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    abstract class AbstractBlock : IToDoImplement
    {
        
        IToDoItem item;
        Button addButton = new Button();
        Button deleteButton = new Button();

        

        public abstract void setItem();

        public AbstractBlock()
        {
            addButton.Click += addTask;
        }

        public void RenderItem(Form form)
        {
            form.Controls.Add(addButton);

            form.Controls.Add(deleteButton);
        }

        public void setTask(string task)
        {
            item.setTask(task);
        }

        public void addTask(object sender,EventArgs args)
        {

        }

        public void deleteTask(object sender, EventArgs args)
        {

        }
    }
}
