using System;
using System.Collections.Generic;

namespace AS2223_BlattiMarco_SqlDb
{
    internal class list<T>
    {
        public static implicit operator list<T>(List<Query> v)
        {
            throw new NotImplementedException();
        }
    }
}