using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class PlainTextBlock : AbstractBlock
    {
        Label label = new Label();
        string task = "";
        public override void Action()
        {
            throw new NotImplementedException();
        }

        public override void InitBlock(int ID)
        {
            base.InitBlock(ID);
            label.Text = task;
            label.Location = new System.Drawing.Point(0, deleteButton.Location.Y);
            label.Size = new System.Drawing.Size(form.Width - deleteButton.Size.Width * 2, deleteButton.Size.Height);
            label.BorderStyle = BorderStyle.FixedSingle;
        }

        public override void setTask(string task)
        {
            this.task = task;
        }

        public override void RenderItem()
        {
            form.Controls.Add(label);
            form.Controls.Add(deleteButton);
        }
    }
}
