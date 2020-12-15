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
        public readonly AgraMarketDBContext dBContext;
        #endregion

        #region Constructor
        public ProductController(AgraMarketDBContext dBContext)
        {
            this.dBContext = dBContext;
            /*"Mi objeto dbContext de aqui, va a 
            ser igual al que me llega por parametro*/
        }
        #endregion

        //https://Localhost:5001/User/CrearProducto
        [HttpPost("CrearProducto")]
        public IActionResult CrearProducto(long id)
        {
            try
            {
                ProductoModel producto = new ProductoModel();
                producto.IdVendedor = id;
                //Especificar id
                return View(producto);
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }

        //https://Localhost:5001/User/GuardarProducto
        [HttpGet("GuardarProducto")]
        public async Task<IActionResult> GuardarProducto(ProductoModel producto)
        {    
            try
            {
                ProductoModel prod = new ProductoModel();
                prod = await dBContext.Productos.FindAsync(producto);
                return Content("Este producto ya existe.");
            }

            catch (Exception e2)
            {
                dBContext.Productos.Add(producto);
                await dBContext.SaveChangesAsync();
                return RedirectToAction("VendedorPage", "Product");
            }
        }

        //http://localhost:5001/User/DesplegarProductos/
        [HttpPost("DesplegarProductos")]
        public async Task<IActionResult> DesplegarProductos(long id)
        {
            UsuarioModel user = new UsuarioModel();
            //List<UsuarioModel> ListaCompleta = new List<UsuarioModel>();
            //ListaCompleta = await dBContext.Usuarios.ToListAsync();
            user = await dBContext.Usuarios.FindAsync(id);
            try
            {
                return View(user);
            }
            catch (Exception e2)
            {
                return View(e2.Message);
            }
        }
    }
}