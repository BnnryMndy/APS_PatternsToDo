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
        
        protected IToDoItem item;

        protected Button addButton = new Button();
        protected Button deleteButton = new Button();
        protected ContextMenuStrip addMenu = new ContextMenuStrip();
        protected ToolStripMenuItem plain = new ToolStripMenuItem("text");
        protected ToolStripMenuItem todo = new ToolStripMenuItem("todo");
        protected ToolStripMenuItem date = new ToolStripMenuItem("date");
        //protected 
        protected Form form;





        public abstract void SetItem();

        public void setForm(Form form)
        {
            this.form = form;
        }

        public AbstractBlock()
        {
            //add button init
            plain.Click += PlainMenu_click;
            todo.Click += ToDoMenu_click;
            date.Click += DateMenu_click;
            addMenu.Items.AddRange(new ToolStripItem[]{ plain, todo, date});
            

            addButton.Location = new System.Drawing.Point(0, 0);
            addButton.Width = 30;
            addButton.Height = 30;
            addButton.Text = "+";

            addButton.ContextMenuStrip = addMenu;
            addButton.Click += addTask;


            //delete button init
            //TODO: do this

            
        }

        public void RenderItem()
        {
            form.Controls.Add(addButton);

            //form.Controls.Add(deleteButton);
        }

        public void setTask(string task)
        {
            item.setTask(task);
        }

        public void addTask(object sender,EventArgs args)
        {

        }

        public void DeleteTask(object sender, EventArgs args)
        {

        }

        public void PlainMenu_click(object sender, EventArgs args)
        {
            
        }

        public void ToDoMenu_click(object sender, EventArgs args)
        {

        }

        public void DateMenu_click(object sender, EventArgs args)
        {

        }
    }

    
}
