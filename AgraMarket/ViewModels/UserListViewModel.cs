using System.Collections.Generic;
using AgraMarket.Models;

namespace AgraMarket.ViewModels
{
    public class UserListViewModel
    {
        public List<UsuarioModel> Usuarios { get; set;}
        {
            public UserListViewModel()
            {
                Usuarios = new List<UsuarioModel>();

            }
        }
    }
}