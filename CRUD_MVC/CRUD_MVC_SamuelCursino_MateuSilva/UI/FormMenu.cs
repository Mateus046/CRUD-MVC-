﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva.UI
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tsmCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var FormMenu = new FormCadastroUsuario();
            FormMenu.Show();
        }

        private void tsmListarUsuario_Click(object sender, EventArgs e)
        {
            var FormMenu = new FormListarUsuario();
            FormMenu.Show();
        }
    }
}
