using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DropDownFilterDataAccess;

namespace GlobalJobSearch.Controllers
{
    public class DropDownFilterController : ApiController
    {
        public IEnumerable<DropDownFilter> Get()
        {
            using (GlobalJobSearchAppEntities entities = new GlobalJobSearchAppEntities())
            {
                return entities.DropDownFilters.ToList();
            }
        }

        public DropDownFilter Get(int id)
        {
            using (GlobalJobSearchAppEntities entities = new GlobalJobSearchAppEntities())
            {
                return entities.DropDownFilters.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
