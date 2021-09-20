using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class AbstractBlock : IToDoImplement
    {
        IToDoItem item;
        public void RenderItem(Form form)
        {
            throw new NotImplementedException();
        }

        public void setTask(string task)
        {
            item.setTask(task);
        }
    }
}
