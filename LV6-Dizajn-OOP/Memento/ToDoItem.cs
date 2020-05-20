using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Memento
{
    class ToDoItem
    {
        private string title;
        private string text;
        private DateTime timeDue;
        public DateTime CreationTime { get; private set; }
        public ToDoItem(string title, string text, DateTime timeDue)
        {
            this.title = title;
            this.text = text;
            this.timeDue = timeDue;
            this.CreationTime = DateTime.Now;
        }
        public void Rename(string title) { this.title = title; }
        public void ChangeTask(string text) { this.text = text; }
        public void ChangeTimeDue(DateTime timeDue) { this.timeDue = timeDue; }
        public override string ToString()
        {
            return this.title + " - due by: " + this.timeDue + "\n" + this.text;
        }
        public CMemento StoreState()
        {
            return new CMemento(this.title, this.text, this.timeDue, this.CreationTime);
        }
        public void RestoreState(CMemento previous)
        {
            if (previous == null)
                Console.WriteLine("");
            else
            {
                this.title = previous.Title;
                this.text = previous.Text;
                this.timeDue = previous.TimeDue;
                this.CreationTime = previous.CreationTime;
            }
        }

        public void AddStateCT(CareTaker careTaker)
        {
            careTaker.AddState(StoreState());
        }

        public void GetByTitleCT(CareTaker careTaker, string title)
        {
            RestoreState(careTaker.GetByTitle(title));
        }
    }
}
