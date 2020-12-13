using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Mutuals : Equities
    {
        //Esta clase implementa a la clase Equities, y al ser instanciada se agregan registros a una lista
        public Mutuals()
        {
            array = new ArrayList();
            array.Add("1");
            array.Add("2");
            array.Add("3");
        }

        //Este método devuelve un string con el nombre de la clase
        public override string toString()
        {
            return "Mutuals";
        }
    }
}
