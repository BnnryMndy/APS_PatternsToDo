using APS_PatternsToDo.UI;
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

    abstract class AbstractItem : IToDoItem
    {
        string task = "enter your task";
        private int id;
        IToDoImplement toDoImplement;
        ItemsList itemsList = ItemsList.GetInstance();

        public void Action()
        {
            
        }

        public int getID()
        {
            return id;
        }

        public string getTask()
        {
            return task;
        }

        public void InitImplement(IToDoImplement toDoImplement)
        {
            this.toDoImplement = toDoImplement;
            toDoImplement.InitBlock(id);
        }


        public  void Render()
        {
            toDoImplement.RenderItem();
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public void setTask(string task)
        {
            this.task = task;
        }
    }
}
