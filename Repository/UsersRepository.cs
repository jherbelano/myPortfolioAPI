using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
        public UsersRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
