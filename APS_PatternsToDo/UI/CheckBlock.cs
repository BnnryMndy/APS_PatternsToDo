using APS_PatternsToDo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class CheckBlock : AbstractBlock
    {
        CheckBox checkBox = new CheckBox();
        string task = "";
        public override void Action()
        {
            Mediator mediator = Mediator.getInstance();
            mediator.ActionItem(blockID);
        }

        public override void InitBlock(int ID)
        {
            if(!hasEvents)
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            base.InitBlock(ID);
            
            checkBox.Text = task;
            checkBox.Location = new System.Drawing.Point(0, deleteButton.Location.Y);
            checkBox.Size = new System.Drawing.Size(form.Width - deleteButton.Size.Width * 2, deleteButton.Size.Height);
            
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox.Font.Strikeout) checkBox.Font = new System.Drawing.Font(checkBox.Font.FontFamily, checkBox.Font.Size, System.Drawing.FontStyle.Strikeout);
            else checkBox.Font = new System.Drawing.Font(checkBox.Font.FontFamily, checkBox.Font.Size, System.Drawing.FontStyle.Regular);
            Action();
        }

        public override void setTask(string task)
        {
            this.task = task;
        }

        public override void RenderItem()
        {
            form.Controls.Add(checkBox);
            form.Controls.Add(deleteButton);
        }
    }
}
