using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternImplementation.Models
{
    public class DummyModel : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
