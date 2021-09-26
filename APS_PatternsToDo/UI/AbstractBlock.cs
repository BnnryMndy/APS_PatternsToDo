using APS_PatternsToDo.Controllers;
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
        

        protected int blockID;

        protected Button taskButton = new Button();
        protected Button deleteButton = new Button();

        protected Mediator mediator = Mediator.getInstance();
        protected Form form;


        //public abstract void SetItem();

        public void SetForm(Form form)
        {
            this.form = form;
            InitBlock(blockID);
        }

        

        public virtual void InitBlock(int ID)
        {

            blockID = ID;
            //add button init
            taskButton.Location = new System.Drawing.Point(0, ID*36);
            taskButton.Width = 30;
            taskButton.Height = 30;
            taskButton.Text = "+";

            //taskButton.ContextMenuStrip = addMenu;
            


            //delete button init
            deleteButton.Location = new System.Drawing.Point(form.Width - 60, ID*36);
            deleteButton.Width = 30;
            deleteButton.Height = 30;
            deleteButton.Text = "X";
            deleteButton.Click += DeleteButton_Click;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteBlock();
        }

        public AbstractBlock()
        {

        }

        public virtual void RenderItem()
        {
            form.Controls.Add(taskButton);

            form.Controls.Add(deleteButton);
        }

        public virtual void setTask(string task)
        {
            //mediator.
        }

        public int getID()
        {
            return blockID;
        }

        public void DeleteBlock()
        {
            form.Controls.Clear();
            mediator.DeleteItem(blockID);
        }

        public abstract void Action();
    }

    
}
