using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternImplementation.Db
{
    public class DB : DbContext
    {
        public DB(DbSet<DummyModel> dummyModel) : base()
        {
            
        }

        public DbSet<DummyModel> DummyModel;
    }
}
