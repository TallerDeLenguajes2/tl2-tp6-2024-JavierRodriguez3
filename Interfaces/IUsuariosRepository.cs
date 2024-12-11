using usuarios;

namespace iUsuariosRepository
{
    public interface IUsuariosRepository
    {
        void CrearUsuario(Usuarios user);
        Usuarios ObtenerUsuario(string usuario, string password);
        public void EliminarUsuario(int id);

    }
}