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
    public class CheckChoice : MultiChoice
    {
        private ArrayList stocks;
        private Panel panel;
        private ArrayList boxes;

        //Se agregan CheckBoxs de acuerdo a la cantidad de registros obtenidos del array
        public CheckChoice(Equities stks)
        {
            stocks = stks.getNames();
            panel = new Panel();
            boxes = new ArrayList();
            for (int i = 0; i < stocks.Count; i++)
            {
                CheckBox ck = new CheckBox();
                //posicionamos los CheckBox
                ck.Location = new Point(8, 16 + i * 32);
                string stk = (string)stocks[i];
                ck.Text = stk;
                ck.Size = new Size(112, 24);
                ck.TabIndex = 0;
                ck.TextAlign = ContentAlignment.MiddleLeft;
                boxes.Add(ck);
                panel.Controls.Add(ck);
            }
        }
        public void clear()
        {
            for (int i = 0; i < boxes.Count; i++)
            {
                CheckBox ck = (CheckBox)boxes[i];
                ck.Checked = false;
            }
        }

        //Se agregan a una lista los CheckBox seleccionados
        public ArrayList getSelected()
        {
            ArrayList sels = new ArrayList();
            for (int i = 0; i < boxes.Count; i++)
            {
                CheckBox ck = (CheckBox)boxes[i];
                if (ck.Checked)
                {
                    sels.Add(ck.Text);
                }
            }
            return sels;
        }

        public Panel getWindow()
        {
            return panel;
        }
    }
}
