using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CalypsoWeb.Controllers
{
    public class ConfigSetsController : ApiController
    {
        // GET api/configsets
        public IQueryable<ConfigSet> Get()
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var ConfigSets = from cs in db.ConfigSets
                             //where cs.Status == "ACTIVE"
                             select cs;

            return ConfigSets;
        }

        // GET api/configsets/1
        public IQueryable<ConfigSet> Get(int id)
        {
            DataClassesDataContext db = new DataClassesDataContext();

            var ConfigSets = from cs in db.ConfigSets
                             where cs.ConfigSetId == id
                             select cs;

            return ConfigSets;
        }
    }
}
