using GlobalJobSearch.Models;
using GlobalJobSearch.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlobalJobSearch.Controllers
{
    public class JobDescriptionController : ApiController
    {
        [HttpPost]
        [Route("SaveJobDescription")]
        public bool SaveJobDescription(JobDescription jobDescription)
        {
            if(jobDescription == null)
            {
                return false;
            }
            return JobDescriptionProcessor.ProcessJobDescription(jobDescription);
        }
    }
}
