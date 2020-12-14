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
        [HttpGet("CrearProducto")]
        public IActionResult CrearProducto()
        {
            try
            {
                ProductoModel producto = new ProductoModel();
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
                prod = await dBContext.Productos.FindAsync(prod);
                return Content("Este producto ya existe.");
            }

            catch (Exception e2)
            {
                dBContext.Productos.Add(producto);
                await dBContext.SaveChangesAsync();
                return RedirectToAction("VendedorProductosPage", "Product");
            }
        }

        //http://localhost:5001/User/DesplegarProductos
        [HttpGet("DesplegarProductos")]
        public async Task<IActionResult> DesplegarProductos(int id)
        {    
            try
            {
                List<ProductoModel> dbCompleta = new List<ProductoModel>();
                dbCompleta = await dBContext.Productos.ToListAsync();
                List<ProductoModel> dBVendedor = new List<ProductoModel>();
                foreach(ProductoModel temp in dbCompleta){
                    if(temp.IdVendedor == id){
                        dBVendedor.Add(temp);
                    }
                }
                return RedirectToAction("VendedorProductosPage", dBVendedor);
            }

            catch (Exception e2)
            {
                return View(e2.Message);
            }
        }
        
        //http://localhost:5001/User/VendedorProductosPage
        [HttpGet("VendedorProductosPage")]
        public IActionResult VendedorProductosPage(List<ProductoModel> dBVendedor)
        {    
            try
            {
                return View(dBVendedor);
            }

            catch (Exception e2)
            {
                return View(e2.Message);
            }
        }
    }
}