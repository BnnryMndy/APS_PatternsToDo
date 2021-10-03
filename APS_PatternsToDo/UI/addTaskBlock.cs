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
            if (!hasEvents) taskButton.Click += addTask;
            if (!hasEvents) plain.Click += PlainMenu_click;
            if (!hasEvents) todo.Click += ToDoMenu_click;
            if (!hasEvents) date.Click += DateMenu_click;
            
            base.InitBlock(ID);

            addMenu.Items.AddRange(new ToolStripItem[] { plain, todo, date });
            
            taskButton.ContextMenuStrip = addMenu;
            taskButton.Text = "+";       
            taskButton.Width = taskText.Height;
            taskButton.Height = taskText.Height;
            taskText.Location = new System.Drawing.Point(taskButton.Location.X + taskButton.Width, taskButton.Location.Y);
            taskText.Width = form.Width - taskButton.Width * 2;
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
            this.Action();
        }

        public void PlainMenu_click(object sender, EventArgs args)
        {
            addTask(sender, args);
        }

        public void ToDoMenu_click(object sender, EventArgs args)
        {
            CheckItemCreator itemCreator = new CheckItemCreator();
            newItem = itemCreator.FactoryMethod();
            CheckBlock checkBlock = new CheckBlock();

            checkBlock.SetForm(form);
            newItem.InitImplement(checkBlock);
            newItem.setTask(taskText.Text);
            this.Action();
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
