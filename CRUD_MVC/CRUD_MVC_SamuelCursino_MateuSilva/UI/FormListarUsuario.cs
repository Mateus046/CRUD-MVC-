using CRUD_MVC_SamuelCursino_MateuSilva.BLL;
using System;
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
    public partial class FormListarUsuario : Form
    {
        public FormListarUsuario()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Criar um objeto que representa a camada BLL
            ListarUsuarioBLL listar = new ListarUsuarioBLL();

            //Chamando o controller (BLL) e obtendo o retorno (lista)
            var retorno = listar.ListarUsuario();

            //Montar o DataFridView
            dgvListar.Rows.Clear(); // limpa as linhas do DataGridView
            dgvListar.Columns.Clear(); // limpa as colunas do DataGridView
            dgvListar.Refresh();
            // atualiza a DataGridView

            //Criar as colunas da DataGridView que serão preenchidas pela lista de usuários 

            dgvListar.Columns.Add("Id","ID");
            dgvListar.Columns.Add("Nome", "Nome");
            dgvListar.Columns.Add("Email", "Email");
            dgvListar.Columns.Add("Senah", "Senha");
            dgvListar.Columns.Add("Nivel", "Nivel");
            dgvListar.Columns.Add("Data", "Data");

            //Percorre a lista (retorno) e monta o DataGridView
            foreach (var i in retorno)
            {
                dgvListar.Rows.Add(i.Id, i.Nome, i.Email, i.Senha, i.Nivel, i.Data);

                //Ajustar automaticamente o tamanho das colunas 
                dgvListar.AutoResizeColumn(1); // Coluna indice 1
                dgvListar.AutoResizeColumn(2);
                dgvListar.AutoResizeColumn(5);

                //Não permite que as colunas do DataGridView sejam editadas manualmente
                dgvListar.ReadOnly = true;

                //Controlar os botões do formulário
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListarUsuario_Load(object sender, EventArgs e)
        {
            // configurar objetos ao iniciar o formulário
            rdoNome.Checked = true;

            // configuração inicial dos botões 
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
