using productos;

namespace iProductosRepository
{
    public interface IProductosRepository
    {
        void CrearProductos(Productos nuevo);
        void ModificarProductos(int id, Productos produ);
        List<Productos> ObtenerProductos();
        Productos ObtenerDetalleProducto(int id);
        void EliminarProducto(int id);

    }
}
