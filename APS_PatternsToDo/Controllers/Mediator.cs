using APS_PatternsToDo.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.Controllers
{
    class Mediator
    {
        private static Mediator instance = new Mediator();
        private ItemsList itemsList = ItemsList.GetInstance();
        private Mediator() { }

        public static Mediator getInstance()
        {
            return instance;
        }


        public void DeleteItem(int id)
        {
            itemsList.RemoveItem(id);
        }

        public void addItem(IToDoItem item)
        {
            itemsList.AddItem(item);
        }

    }
}
