using Microsoft.AspNetCore.Mvc;
using AgraMarket.Services;
using AgraMarket.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AgraMarket.ViewModels;
using System;

namespace AgraMarket.Controllers
{
    [Route("[Controller]")]
    public class UserController : Controller
    {
        #region Properties
        private readonly AgraMarketDBContext dBContext;
        #endregion

        #region Constructor
        public UserController(AgraMarketDBContext dBContext)
        {
            this.dBContext = dBContext;
            /*"Mi objeto dbContext de aqui, va a 
            ser igual al que me llega por parametro*/
        }
        #endregion

        //https://Localhost:5001/User/CrearUsuario
        [HttpGet("CrearUsuario")]
        public IActionResult CrearUsuario()
        {
            try
            {
                return View();
                
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //https://Localhost:5001/User/GuardarUsuario
        [HttpGet("GuardarUsuario")]
        public async Task<IActionResult> GuardarUsuario(UsuarioModel usuario)
        {
            try
            {
                UsuarioModel user = new UsuarioModel();
                user = await dBContext.Usuarios.FindAsync(usuario);
                return Content("Este usuario ya existe. Intentalo mas tarde.");
            }

            catch (Exception e2)
            {
                dBContext.Usuarios.Add(usuario); 
                await dBContext.SaveChangesAsync(); 
                return RedirectToAction("Home", "Index");
            }
        }

        //https://Localhost:5001/User/EliminarUsuario/5
        [HttpGet("EliminarUsuario/{id}")]
        public async Task<IActionResult> EliminarUsuario(long Id)
        {
            try
            {
                UsuarioModel usuario = await dBContext.Usuarios.FindAsync(Id);
                if(usuario == null)
                {
                    throw new Exception("El usuario que ingreso no se encontro. Intentelo mas tarde.");
                    //Colocar vista o link que permita volver a Home
                }

                if(usuario != null)
                {
                    dBContext.Usuarios.Remove(usuario);
                    await dBContext.SaveChangesAsync();
                    return Ok("El usuario fue eliminado exitosamente");
                    //Colocar vista o link que permita volver a Home
                }
                return Ok("Hubo un error al intentar eliminar el usuario. Intentelo mas tarde"); 
                //Colocar vista o link que permita volver a Home o al Home del usuario
            }
            catch (Exception e1)
            {
                return Content(e1.Message);
            }

        }
    }
}