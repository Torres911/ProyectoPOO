using Microsoft.AspNetCore.Mvc;
using AgraMarket.Services;
using AgraMarket.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AgraMarket.ViewModels;
using System;
using System.Linq;

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
            UsuarioModel usuario = new UsuarioModel();
            try
            {
                return View(usuario);
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
                return RedirectToAction("Index", "Home");
            }
        }

        //https://Localhost:5001/IngresarUsuario
        [HttpGet("IngresarUsuario")]
        public IActionResult IngresarUsuario()
        {
            try
            {
                UsuarioModel usuario = new UsuarioModel();
                return View(usuario);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //https://Localhost:5001/User/ClientePage
        [HttpGet("ClientePage")]
        public IActionResult ClientePage(UsuarioModel usuario)
        {
            try
            {
                return View(usuario);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //https://Localhost:5001/User/VendedorPage
        [HttpGet("VendedorPage")]
        public IActionResult VendedorPage(UsuarioModel usuario)
        {
            try
            {
                return View(usuario);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //Verifica que el usuario ingresado sea correcto
        //https://Localhost:5001/User/UpdateUsuario
        [HttpPost("UpdateUsuario")]
        public async Task<IActionResult> UpdateUsuario(UsuarioModel usuario)
        {
            UsuarioModel user = new UsuarioModel();
            try
            {
                user = await dBContext.Usuarios.FirstAsync(a => a.User == usuario.User && a.Pass == usuario.Pass);
                if(user.TipoUsuario == "Vendedor")
                {
                    return RedirectToAction("VendedorPage", user);
                }
                return RedirectToAction("ClientePage", user);
            }
            catch(Exception e)
            {
                return View(e.Message);
            }
        }

        //https://Localhost:5001/User/EditarUsuario
        [HttpPost("EditarUsuario")]
        public async Task<IActionResult> EditarUsuario(long codigo)
        {
            try
            {
                UsuarioModel user = await dBContext.Usuarios.FindAsync(codigo); //user.codigo
                if(user == null)
                {
                    return Content("Hubo un error editando. Intentalo de nuevo.");
                }
                return View(user);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        //https://Localhost:5001/User/UpdateEdicion
        [HttpPost("UpdateEdicion")]
        public async Task<IActionResult> UpdateEdicion(UsuarioModel usuario)
        {
            try
            {
                dBContext.Entry(usuario).State = EntityState.Modified;
                await dBContext.SaveChangesAsync();
                if(usuario.TipoUsuario == "Vendedor")
                {
                    return RedirectToAction("VendedorPage", usuario);
                }
                return RedirectToAction("ClientePage", usuario);
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        //https://Localhost:5001/User/EliminarUsuario/
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