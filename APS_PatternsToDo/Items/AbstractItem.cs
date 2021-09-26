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
        protected string task = "enter your task";
        protected int id;
        protected ItemsList itemsList = ItemsList.GetInstance();
        public IToDoImplement implement;
        public virtual void Action()
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
            this.implement = toDoImplement;
        }


        public void setID(int id)
        {
            this.id = id;
            implement.InitBlock(this.id);
        }

        public void setTask(string task)
        {
            this.task = task;
        }

        public virtual void Render()
        {
            implement.RenderItem();
        }

        //public void Delete()
        //{
        //    implement.DeleteBlock();
        //}
    }
}
