using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Iterator
{
    class Notebook : IAbstractCollection
    {
        private List<note> notes;
        public Notebook(){ this.notes = new List<note>(); }
        public Notebook(List<note> notes)
        {
            this.notes = new List<note>(notes.ToArray());
        }
        public void AddNote(note note){ this.notes.Add(note); }
        public void RemoveNote(note note){ this.notes.Remove(note); }
        public void Clear(){ this.notes.Clear(); }
        public int Count { get { return this.notes.Count; } }
        public note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new CIterator(this); }
    }

}
