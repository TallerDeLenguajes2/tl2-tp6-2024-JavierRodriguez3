using System.Security.Principal;
using presupuestos;
using presupuestosDetalle;

namespace iPresupuestosRepository
{
    public interface IPresupuestosRepository
    {
        void CrearPresupuesto(Presupuestos presupuestos);
        List<Presupuestos> ObtenerPresupuestos();
        List<PresupuestoDetalle> ObtenerDetalle(int id);
        Presupuestos ObtenerPresupuestoConDetalles(int idPresupuesto);
        void AgregarProductoAPresupuesto(int idPresupuesto, int idProducto, int cantidad);
        void EliminarPresupuestoPorId(int idPresupuesto);
        void ModificarPresupuestoQ(Presupuestos presupuesto);
        public Presupuestos ObtenerPresupuestoPorId(int id);
    }
}