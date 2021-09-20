using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    class ListFrame : IFrame
    {
        List<IToDoImplement> items;
        Form renderField;
        public void GetForm(Form form)
        {
            renderField = form;
        }
        public void RenderFrame()
        {
            foreach (IToDoImplement item in items)
            {
                item.RenderItem(renderField);
            }
        }
    }
}
