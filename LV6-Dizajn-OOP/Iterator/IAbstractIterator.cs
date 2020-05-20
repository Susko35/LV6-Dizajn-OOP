using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Iterator
{
    interface IAbstractIterator
    {
        note First();
        note Next();
        bool IsDone { get; }
        note Current { get; }
    }
}
