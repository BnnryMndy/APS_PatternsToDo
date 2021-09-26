using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class AddTaskBlock : AbstractBlock
    {
        protected ContextMenuStrip addMenu = new ContextMenuStrip();
        protected ToolStripMenuItem plain = new ToolStripMenuItem("text");
        protected ToolStripMenuItem todo = new ToolStripMenuItem("todo");
        protected ToolStripMenuItem date = new ToolStripMenuItem("date");
        protected TextBox taskText = new TextBox();
        public override void SetItem()
        {
            //add menu init
            plain.Click += PlainMenu_click;
            todo.Click += ToDoMenu_click;
            date.Click += DateMenu_click;
            addMenu.Items.AddRange(new ToolStripItem[] { plain, todo, date });
            taskButton.ContextMenuStrip = addMenu;
            taskButton.Text = "+";
            //taskText. = 12;
            taskButton.Click += addTask;
            taskButton.Width = taskText.Height;
            taskButton.Height = taskText.Height;
            taskText.Location = new System.Drawing.Point(taskButton.Location.X + taskButton.Width, taskButton.Location.Y);
            taskText.Width = form.Width - taskButton.Width * 2;

        }

        public override void RenderItem()
        {
            
            //taskText.Anchor = AnchorStyles.Right;
            //taskText.Anchor = AnchorStyles.Bottom;
            form.Controls.Add(taskText);
            form.Controls.Add(taskButton);
        }

        public void addTask(object sender, EventArgs args)
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
