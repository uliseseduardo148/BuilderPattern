using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPattern
{
    public partial class WealthBuilder : Form
    {
        private MultiChoice mchoice;
        private List<Equities> lista;

        //Se agregan inicialmente las opciones a un ListBox, y a otra lista los objetos de tipo Equities(clase base)
        private void init()
        {
            lista = new List<Equities>();
            lista.Add(new Stocks());
            lista.Add(new Bonds());
            lista.Add(new Mutuals());

            lsEquities.Items.Add(lista[0].toString());
            lsEquities.Items.Add(lista[1].toString());
            lsEquities.Items.Add(lista[2].toString());

        }
        public WealthBuilder()
        {
            InitializeComponent();
            init();
        }

        private void LsEquities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esta linea remueve incialmente el panel de datos para que cada vez que se seleccione un elemento del ListBox
            //diferente se agregue nuevamente al final con los nuevos datos, esto es con el fin de "Refrescar" el panel
            //de lo contrario se seguirán mostrando los datos de la selección anterior
            Controls.Remove(pnlDatos);
            int i = lsEquities.SelectedIndex;
            Equities eq = (Equities)lista[i];
            mchoice = StockFactory.getBuilder(eq);
            pnl = mchoice.getWindow();
            pnlDatos = mchoice.getWindow();
            Controls.Add(pnlDatos);
            //Esto solo posiciona al control dentro de la ventana
            pnlDatos.SetBounds(400,50,800,800);
        }

        //En el evento del botón se obtienen los items seleccionados y se imprimen en un mensaje
        private void BtPlot_Click(object sender, EventArgs e)
        {
            if (mchoice != null)
            {
                ArrayList ar = mchoice.getSelected();
                string ans = "";
                for (int i = 0; i < ar.Count; i++)
                {
                    ans += (string)ar[i] + " ";
                }
                MessageBox.Show(null, ans, "Seleccionados", MessageBoxButtons.OK);
            }
        }
    }
}
