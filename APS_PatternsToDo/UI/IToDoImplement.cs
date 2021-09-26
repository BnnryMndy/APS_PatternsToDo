using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo.UI
{
    interface IToDoImplement
    {
        
        void RenderItem();

        void Action();

        int getID();

        void SetForm(Form form);

        void InitBlock(int ID);

        void setTask(string task);

        void DeleteBlock();
    }
}
