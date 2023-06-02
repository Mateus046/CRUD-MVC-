using CRUD_MVC_SamuelCursino_MateuSilva.DAL;
using CRUD_MVC_SamuelCursino_MateuSilva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_SamuelCursino_MateuSilva.BLL
{
    class ListarUsuarioBLL
    {
        //Este Método apenas chama a DAL e retorna a lista 
        public List<ListarUsuarioDTO> ListarUsuario()
        {
            //Criar o bojeto da classe ListarUsuarioDAL
            ListarUsuarioDAL Lista = new ListarUsuarioDAL();

            //Fazer a chamada do método ListarTodos() da classe DAL
            return Lista.ListarTodos();

        }
    }
}
