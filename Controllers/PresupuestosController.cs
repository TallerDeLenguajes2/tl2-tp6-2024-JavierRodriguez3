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
 
        public IActionResult ListarPresupuestos()
        {
            return View(_presupuestoRepository.ObtenerPresupuestos());
        }
    }
}