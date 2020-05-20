using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.Iterator
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }

}
