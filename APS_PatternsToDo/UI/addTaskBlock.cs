using APS_PatternsToDo.Items;
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
        protected IToDoItem newItem;
        public override void InitBlock(int ID)
        {
            //add menu init
            plain.Click += PlainMenu_click;
            todo.Click += ToDoMenu_click;
            date.Click += DateMenu_click;
            addMenu.Items.AddRange(new ToolStripItem[] { plain, todo, date });
            taskButton.ContextMenuStrip = addMenu;
            taskButton.Text = "+";

            taskButton.Click += addTask;
            taskButton.Width = taskText.Height;
            taskButton.Height = taskText.Height;
            taskText.Location = new System.Drawing.Point(taskButton.Location.X + taskButton.Width, taskButton.Location.Y);
            taskText.Width = form.Width - taskButton.Width * 2;
            base.InitBlock(ID);
        }

        public override void RenderItem()
        {
            form.Controls.Add(taskText);
            form.Controls.Add(taskButton);
        }

        public void addTask(object sender, EventArgs args)
        {
            LabelCreator labelCreator = new LabelCreator();
            newItem = labelCreator.FactoryMethod();
            PlainTextBlock plainTextBlock = new PlainTextBlock();
            
            plainTextBlock.SetForm(form);
            newItem.InitImplement(plainTextBlock);
            newItem.setTask(taskText.Text);
            //newItem.
            this.Action();
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

        public override void Action()
        {
            mediator.addItem(newItem);
        }
    }
}
