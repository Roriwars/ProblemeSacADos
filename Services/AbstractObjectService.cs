using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Services
{
    public abstract class AbstractObjectService
    {
        public abstract List<Objets> getObjets();
    }
}
