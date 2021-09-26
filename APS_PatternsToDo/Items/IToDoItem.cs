using APS_PatternsToDo.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo
{
    interface IToDoItem
    {
        string getTask();

        void setID(int id);

        int getID();
        void InitImplement(IToDoImplement toDoImplement);

        void setTask(string task);

        void Action();

        void Render();
    }
}
