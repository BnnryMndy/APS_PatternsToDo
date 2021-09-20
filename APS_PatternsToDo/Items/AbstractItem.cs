using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.Items
{
    abstract class AbstractItemCreator
    {
        public abstract IToDoItem FactoryMethod();

        public void Action()
        {
            var item = FactoryMethod();

            item.Action();
        }

        public string getTask()
        {
            var item = FactoryMethod();
            return item.getTask();
        }


    }
}
