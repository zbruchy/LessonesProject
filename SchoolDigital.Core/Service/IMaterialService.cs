using SchoolDigital.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDigital.Core.Service
{
    public interface IMaterialService
    {
        public List<Material> GetAll();
        public Material GetById(int id);
    }
}
