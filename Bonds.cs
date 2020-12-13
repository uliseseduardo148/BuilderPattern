using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BuilderPattern
{
    //Esta clase implementa a la clase Equities, y al ser instanciada se agregan registros a una lista
    public class Bonds:Equities
    {
        public Bonds() {
            array = new ArrayList();
            array.Add("CTG0 2005");
            array.Add("NY G0 2012");
            array.Add("GE CORP BONDS");
        }

        //Este método devuelve un string con el nombre de la clase
        public override string toString()
        {
            return "Bonds";
        }
    }
 }
