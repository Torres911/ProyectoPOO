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
    public class ProductController : Controller
    {
        #region Properties
        private readonly AgraMarketDBContext dBContext;
        #endregion

        #region Constructor
        public ProductController(AgraMarketDBContext dBContext)
        {
            this.dBContext = dBContext;
            /*"Mi objeto dbContext de aqui, va a 
            ser igual al que me llega por parametro*/
        }
        #endregion

        //https://Localhost:5001/Product/CrearProducto
        [HttpGet("CrearProducto")]
        /*async task representa una tarea que se esta ejectuando,
        y que esta esperando para devolver el objeto del tipo 
        especificado*/
        public async Task<IActionResult> CrearUsuario()
        {
            ProductoModel Producto = new ProductoModel()
            {
                IdVendedor = 5, //Este es el Foreign Key
                NomProducto = "Papas",
                FotoProducto = "LaFotoDeLasPapas",
                ValorProducto = 15000,
                Cantidad = 100
            };
            dBContext.Productos.Add(Producto);
            /* "await" permite que se espere a que el dBContext
            haga los cambios necesarios antes de correrlo 
            (Esto le toma un tiempo a la bd)*/ 
            await dBContext.SaveChangesAsync();
            return Ok(Producto.Id.ToString());
            /*Estos id una vez creados, no pueden repetirse en la base
            de datos, incluso después de borrarlos*/
        }

        //https://Localhost:5001/Product/EliminarProducto/5
        [HttpGet("EliminarProducto/{id}")]
        public async Task<IActionResult> EliminarUsuario(long Id)
        {
            try
            {
                UsuarioModel usuario = await dBContext.Usuarios.FindAsync(Id);
                if(usuario != null)
                {
                    dBContext.Usuarios.Remove(usuario);
                    await dBContext.SaveChangesAsync();
                    return Ok("El usuario fue eliminado");
                }
                return Ok("Hubo un error al intentar eliminar el usuario"); 
            }
            catch (Exception e1)
            {
                return StatusCode(410);
            }

        }
    }
}