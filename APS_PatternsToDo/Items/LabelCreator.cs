using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.Items
{
    class LabelCreator : AbstractItemCreator
    {
        public override IToDoItem FactoryMethod()
        {
            return new LabelItem();
        }
    }

    class LabelItem : IToDoItem
    {
        public string getTask() {
            return "xx";
        }

        public void Action()
        {

        }

    }
}
