using APS_PatternsToDo.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.UI
{
    class PlainBlock : AbstractBlock
    {
        LabelCreator creator = new LabelCreator();
        public override void SetItem()
        {
            item = creator.FactoryMethod();
        }
    }
}
