using Agenda.be;
using Agenda.bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private blAgenda agenda;
        public Form1()
        {
            InitializeComponent();
            agenda = new blAgenda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var resultado = agenda.eliminarClientes((int)txtId.Value);
            if (!resultado)
                MessageBox.Show("ERROR EN ELIMINAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtEdad.Text == string.Empty)
                MessageBox.Show("INGRESE LA EDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var per = new BEClientes();
                per.idCliente = (int)txtId.Value;
                per.nombres = txtNombres.Text;
                per.edad = (int)txtEdad.Value;

                if (!agenda.insertaTipoCliente(per))
                    MessageBox.Show("NO SE REALIZO EL REGISTRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("SE COMPLETO EL REGISTRO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var per = agenda.seleccionaTipoCliente((int)txtId.Value);
            if (per != null)
            {
                txtId.Value = per.idCliente;
                txtNombres.Text = per.nombres;
                txtEdad.Value=per.edad;

            }
            else
            {
                MessageBox.Show("NO EXISTE NINGUN ESTUDIANTE REGISTRADO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((int)txtId.Value == 3)
                MessageBox.Show("ERROR EN MODIFICACION DE CLIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var perComun = new BEClientes();
                perComun.idCliente = (int)txtId.Value;
                perComun.nombres = txtNombres.Text;
                perComun.edad = (int)txtEdad.Value;
               


                if (!agenda.actualizaTipoCliente(perComun))
                    MessageBox.Show("ERROR DE ACTUALIZACION", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("SE HA ACTUALIZO CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
