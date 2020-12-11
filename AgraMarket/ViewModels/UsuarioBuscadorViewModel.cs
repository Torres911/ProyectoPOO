using AgraMarket.Models;

namespace AgraMarket.ViewModels
{
    public class UsuarioBuscadorViewModel
    {
        public UsuarioModel UsuarioEncontrado { get; set; }

        public UsuarioBuscadorViewModel()
        {
            UsuarioEncontrado = new UsuarioModel();
        }
    }
}