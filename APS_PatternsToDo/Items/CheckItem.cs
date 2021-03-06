using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.Items
{
    class CheckItemCreator : AbstractItemCreator
    {
        public override IToDoItem FactoryMethod()
        {
            return new CheckItem();
        }
    }

    class CheckItem : AbstractItem
    {
        bool item = false;

        public override void Action()
        {
            item = !item;
            base.Action();
        }

        

        public override void Render()
        {
            implement.InitBlock(id);
            implement.setTask(task);
            base.Render();
        }
    }
}
