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

        int getID();

        void InitBlock(int ID);

        void setTask(string task);

        void DeleteBlock();
    }
}
