﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Sucursales;

namespace Trabajo_Final
{
    public partial class MDIPaciente : Form
    {
       

        public MDIPaciente()
        {
            InitializeComponent();
        }
        //INGRESAR DATOS
        private void ShowNewForm(object sender, EventArgs e)
        {
           Paciente childForm = new Paciente();
            childForm.MdiParent = this;
            childForm.Text = "Paciente";
            childForm.Show();

        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //SUCURSALES
        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSucursales form = new FSucursales();
            form.MdiParent = this;
            form.Show();
            
        }

        private void MDIPaciente_Load(object sender, EventArgs e)
        {
          
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Examen childForm = new Examen();
            childForm.MdiParent = this;
            childForm.Text = "Examenes";
            childForm.Show();
        }

        private void MDIPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
