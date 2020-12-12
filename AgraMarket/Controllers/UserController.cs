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
        /*async task representa una tarea que se esta ejectuando,
        y que esta esperando para devolver el objeto del tipo 
        especificado*/
        public async Task<IActionResult> CrearUsuario()
        {
            UsuarioModel Usuario = new UsuarioModel()
            {
                Nombre = "Santiago",
                Apellido = "Torres",
                CC = "9847395365",
                Edad = 20,
                User = "santorin",
                Pass = "santiago1234",
                Departamento = "Valle del Cauca",
                Municipio = "Cali",
                Direccion = "En la mierda, digo en el norte",
                TipoUsuario = "Vendedor",
                NumeroTarjetaCredito = "12345",
                TipoTarjetaCredito = "Paypal",
                Monto = 500000
            };
            dBContext.Usuarios.Add(Usuario);
            /* "await" permite que se espere a que el dBContext
            haga los cambios necesarios antes de correrlo 
            (Esto le toma un tiempo a la bd)*/ 
            await dBContext.SaveChangesAsync();
            return Ok(Usuario.Id.ToString());
            /*Estos id una vez creados, no pueden repetirse en la base
            de datos, incluso después de borrarlos*/
        }
    }
}