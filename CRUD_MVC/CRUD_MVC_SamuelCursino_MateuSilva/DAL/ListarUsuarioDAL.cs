using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_SamuelCursino_MateuSilva.DAL
{
    class ListarUsuarioDAL
    {
        //criar lista com objeto de usuários 
        // neste caso o objeto "usuariosLista" tem como seu tipo uma lista e esta lista possui itens do tipo ListarUsuarioDTO somente
        public List<ListarUsuarioDTO> usuariosLista = new List<ListarUsuarioDTO>();

        //Método ListarTodos
        //Esta método retorna uma lista contendo objetos do tipo ListarUsuarioDTO
        public List<ListarUsuarioDTO> ListarTodos()
        {
            try
            {
                //conectar ao banco de dados
                var conn = UtilsDAL.GetConnection();
                // verifica se a conexão está ok
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    var sql = "SELECT * FROM usuarios";
                    var retorno = new MySqlCommand(sql, conn);
                    var reader = retorno.ExecuteReader();

                    /*
                     * Aqui percorremos o resultado da pesquisa no banco 
                     * enquanto houver dados no objeto "reader" ele será verdadeiro o loop
                     * while ficará sendo executado.
                     */
                    while (reader.Read())
                    {
                        //Aqui está sendo feita a adição dos usuários a lista 
                        usuariosLista.Add(new ListarUsuarioDTO()
                        {
                            Id = reader [0].ToString(),// primeira coluna da tabela usuarios
                            Nome = reader [1].ToString(),
                            Email = reader[2].ToString(),
                            Senha = reader[3].ToString(),
                            Nivel = reader[4].ToString(),
                            Data = reader[5].ToString()
                           });
                    }
                    conn.Close();// encerrada conexão com o banco de dados
                }
            }
        catch(System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return usuariosLista; //retorna a lista de usuarios que foi pesquisada no banco dados
        }

    }
}
