using APS_PatternsToDo.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_PatternsToDo.Items
{
    class ItemsList
    {
        private static ItemsList instance = new ItemsList();
        private static List<IToDoItem> items = new List<IToDoItem>();

        private ItemsList() { }

        public static ItemsList GetInstance()
        {
            return instance;
        }

        public List<IToDoItem> GetItems()
        {
            return items;
        }

        public void AddItem(IToDoItem item)
        {
            items.Add(item);
            item.setID(items.Count - 1);
            this.renderList();
        }

        public void RemoveItem(int itemID)
        {
            if(itemID > 0) items.RemoveAt(itemID);
            renderList();
        }

        public void ActionItem(int id)
        {
            items.ElementAt(id).Action();
        }

        public void renderList()
        {

            foreach (IToDoItem item in items)
            {
                item.Render();
                item.setID(items.IndexOf(item));
            }
        }
    }
}
