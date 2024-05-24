using Eflyer.Core.Models;
using Eflyer.Core.RepositoryAbstracts;
using Eflyer.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Data.RepositoryConcretes
{
    public class ElectronicRepository : GenericRepository<Electronic>, IElectronicRepository
    {
        public ElectronicRepository(AppDbContext context): base(context)
        {

        }
    }
}
