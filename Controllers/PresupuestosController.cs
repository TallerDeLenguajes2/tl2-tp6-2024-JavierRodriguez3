using Microsoft.AspNetCore.Mvc;
using presupuestoRepository;
using presupuestos;

namespace presupuestoController
    {
    public class PresupuestosController : Controller
    {
        private readonly PresupuestosRepository _presupuestoRepository;
        public PresupuestosController()
        {
            _presupuestoRepository = new PresupuestosRepository();
        }

        [HttpGet]
        public IActionResult ListarPresupuestos()
        {
            return View(_presupuestoRepository.ObtenerPresupuestos());
        }

        [HttpGet]
        public IActionResult ListarDetallesPresupuestos(int id)
        {
            return View(_presupuestoRepository.ObtenerDetalle(id));
        }

        [HttpGet]
        public IActionResult CrearPresupuestos()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearPresupuestos(Presupuestos presupuesto)
        {
            if (ModelState.IsValid) // Verifica si el modelo es válido
            {
                _presupuestoRepository.CrearPresupuestos(presupuesto); // Guarda el producto en el repositorio
                return RedirectToAction(nameof(ListarPresupuestos)); // Redirige a la lista de productos
            }
            return View(presupuesto); // Si hay errores, vuelve a la vista del formulario con el modelo
        }
    }
}