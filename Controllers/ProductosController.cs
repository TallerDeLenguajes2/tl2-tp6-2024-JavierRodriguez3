using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tl2_tp6_2024_JavierRodriguez3.Models;
using productoReposotory;

namespace productosController{
    public class ProductosController : Controller{
        private readonly ProductosRepository _productosRepository;

        public ProductosController()
        {
            _productosRepository = new ProductosRepository();
        }

        public IActionResult ListarProductos()
        {
            return View(_productosRepository.ObtenerProductos());
        }
    }



}