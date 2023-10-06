using CheckPoint5.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckPoint5.Repositories.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly OracleDbContext _dbContext;
        
        public UsuarioRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _dbContext.Usuarios.ToList();
        }

        public void Add(Usuario entity) { 
            _dbContext.Usuarios.Add(entity);
            _dbContext.SaveChanges();

        }

        public Usuario GetById(int id) {
            return _dbContext.Usuarios.Find(id);
        }

        public void Update(Usuario entity) { 
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();   
        }

        public void Delete(Usuario entity) {
            _dbContext.Usuarios.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
