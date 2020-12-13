using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPattern
{
    //Se implementa la interfaz MultiChoice
    public class ListChoice : MultiChoice
    {
        private ArrayList stocks;
        private Panel panel;
        private ListBox list;

        //Se agrega un ListBox de acuerdo a la cantidad de registros obtenidos del array
        public ListChoice(Equities stks)
        {
            stocks = stks.getNames();
            panel = new Panel();
            list = new ListBox();
            //posicionamos los controles
            list.Location = new Point(16, 0);
            list.Size = new Size(120, 160);
            list.SelectionMode = SelectionMode.MultiExtended;
            list.TabIndex = 0;
            panel.Controls.Add(list);

            for (int i = 0; i < stocks.Count; i++)
            {
                list.Items.Add(stocks[i]);
            }
        }

        public void clear()
        {
            list.Items.Clear();        }

        //Se agregan a una lista los items seleccionados
        public ArrayList getSelected()
        {
            ArrayList sels = new ArrayList();
            ListBox.SelectedObjectCollection
            coll = list.SelectedItems;
            for (int i = 0; i < coll.Count; i++)
            {
                string item = (string)coll[i];
                sels.Add(item);
            }
            return sels;
        }

        public Panel getWindow()
        {
            return panel;        }
    }
}
