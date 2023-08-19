using ProyectoGB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiseñoSoft
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
            this.Close();
        }

        private void botonLibro_Click(object sender, EventArgs e)
        {
            AdministracionLibro administradorLibro = new AdministracionLibro();
            administradorLibro.Show();
            this.Close();
        }




        private void botonNotificaciones_Click(object sender, EventArgs e)
        {
            Notificaciones_Automaticas notificaciones = new Notificaciones_Automaticas();
            notificaciones.Show();
            this.Close();
        }

    

        private void botonPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos_Automaticos prestamos = new Prestamos_Automaticos();
            prestamos.Show();
            this.Close();

        }
    }
}
