using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Stocks : Equities
    {
        //Esta clase implementa a la clase Equities, y al ser instanciada se agregan registros a una lista
        public Stocks()
        {
            array = new ArrayList();
            array.Add("Cisco");
            array.Add("Coca Cola");
            array.Add("GE");
            array.Add("Harley Davidson");
            array.Add("IBM");
            array.Add("Microsoft");
        }

        //Este método devuelve un string con el nombre de la clase
        public override string toString()
        {
            return "Stocks";
        }
    }
}
