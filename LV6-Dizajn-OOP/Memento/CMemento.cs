using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Memento
{
    class CMemento
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreationTime { get; private set; }
        public CMemento(string title, string text, DateTime timeDue, DateTime creationTime)
        {
            this.Title = title;
            this.Text = text;
            this.TimeDue = timeDue;
            this.CreationTime = creationTime;
        }
    }
}
