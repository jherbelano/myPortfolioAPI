using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IUsersRepository> _userRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<IUsersRepository>(() => new
            UsersRepository(repositoryContext));
        }

        public IUsersRepository User => _userRepository.Value;
        public void Save() => _repositoryContext.SaveChanges();
    }
}
