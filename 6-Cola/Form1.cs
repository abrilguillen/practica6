using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Cola
{
    public partial class frmColas : Form
    {
        Queue queue = new Queue();
        Random aleatorio = new Random();

        public frmColas()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            Proceso proceso;
            int ciclosSinProcesos = 0;

            for (int i = 0; i < 200; i++)
            {
                if (aleatorio.Next(1, 5) == 1)
                {
                    queue.meter(new Proceso(aleatorio.Next(4, 15)));
                }

                proceso = queue.cima();

                if (proceso == null)
                    ciclosSinProcesos++;
                
                else
                {
                     if (proceso.tiempoProceso == 0)
                        queue.sacar();
                    proceso.tiempoProceso--;//

                }
            }

            txtProcesos.Clear();
            txtProcesos.Text = "La cola estuvo vacía " + ciclosSinProcesos + " ciclos" + Environment.NewLine;
            txtProcesos.Text += queue.ToString();
        }
    }
}
