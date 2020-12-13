using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Esta es una clase base 
    public abstract class Equities
    {
        protected ArrayList array;
        public abstract string toString();
        public ArrayList getNames()
        {
            return array;
        }        public int count() {
            return array.Count;
        }
    }
}
