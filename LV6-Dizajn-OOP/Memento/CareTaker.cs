using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Memento
{
    class CareTaker
    {
        public Dictionary<string,CMemento> PreviousStates { get; set; }

        public CareTaker()
        {
            this.PreviousStates = new Dictionary<string, CMemento>();
        }
        public void AddState(CMemento memento)
        {
            PreviousStates.Add(memento.Title, memento);
        }

        public Dictionary<string, CMemento> GetDictionary()
        {
            return this.PreviousStates;
        }

        public CMemento GetByTitle(string title)
        {
            if (!PreviousStates.ContainsKey(title))
            {
                Console.WriteLine("Not in dictionary!");
                return null;
            }

            else
            {
                CMemento memento = PreviousStates[title];
                return memento;
            }

        }
    }
}
