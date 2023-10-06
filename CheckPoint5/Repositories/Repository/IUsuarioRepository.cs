using CheckPoint5.Models;

namespace CheckPoint5.Repositories.Repository
{
    public interface IUsuarioRepository
    {
        Usuario GetById(int id);
        IEnumerable<Usuario> GetAll();

        void Add(Usuario entity);
        void Update(Usuario entity);
        void Delete(Usuario entity);
    }
}
