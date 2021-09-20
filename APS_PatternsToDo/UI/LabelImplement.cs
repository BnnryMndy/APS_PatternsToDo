using APS_PatternsToDo.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class LabelImplement : IToDoImplement
    {
        LabelCreator creator = new LabelCreator();
        IToDoItem item;

        public void RenderItem(Form form)
        {
            item = creator.FactoryMethod();
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
