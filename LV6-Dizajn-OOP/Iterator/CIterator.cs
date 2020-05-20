using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Iterator
{
    class CIterator : IAbstractIterator
    {
        private Notebook notebook;
        private int currentPosition;
        public CIterator(Notebook notebook)
        {
            this.notebook = notebook;
            this.currentPosition = 0;
        }
        public bool IsDone { get { return this.currentPosition >= this.notebook.Count; } }
        public note Current { get { return this.notebook[this.currentPosition]; } }
        public note First() { return this.notebook[0]; }
        public note Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.notebook[this.currentPosition];
            }
        }
    }

}
