using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   //hereda de la clase horm
                                     //clase derivada con su constructor
        }

        //funciones de evento
        private void Boton_Click(object sender, EventArgs e)  //atraves del sender definimos de que se ejecuta la accion
            //eventArgs guarda informacion sobre el evento que desencadeno
        {
            DialogResult btnMensaje;
            btnMensaje = MessageBox.Show("Desea cerrar el sistema", "decida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (btnMensaje == DialogResult.Yes)
            {
                MessageBox.Show("espero que decida bien");
                this.Close();
            }
        }
        //propio cuadro de dialogo
        private void btnDialogo_Click(object sender, EventArgs e)
        {
            FormDialogo dialogo = new FormDialogo();
            DialogResult boton;
            boton = dialogo.ShowDialog();   //mostrara como una cuadro de dialogo y bloqueara pantalla
            if (boton == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
