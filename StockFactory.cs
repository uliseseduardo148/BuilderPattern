using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /*Esta clase es la que sirve de factoría de objetos, dependiendo de la cantidad de
     * registros devuelve una u otra clase, si la cantidad de registros del array es menor
     * o igual a tres devuelve una instancia de la clase CheckChoice, sino devuelve una del tipo
     * ListChoice
     */
    public class StockFactory
    {
        public static MultiChoice getBuilder(Equities stocks)
        {
            if (stocks.count() <= 3)
            {
                return new CheckChoice(stocks);
            }
            else
            {
                return new ListChoice(stocks);
            }
        }
    }
}
