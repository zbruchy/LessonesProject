using SchoolDigital.Core.Entities;
using SchoolDigital.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Data.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly DataContext _context;
        public MaterialRepository(DataContext context)
        {
            _context = context;
        }
        public List<Material> GetAllMaterials()
        {
            return _context.materials;
        }

        public Material GetById(int id)
        {
            var t = _context.materials.Find(x => x.Id == id);
            return t;
        }
    }
}
