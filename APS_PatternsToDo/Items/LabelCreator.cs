using APS_PatternsToDo.UI;
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

    class LabelItem : AbstractItem
    {
        public override void Render()
        {
            implement.InitBlock(id);
            implement.setTask(task);
            base.Render();
        }
    }
}
