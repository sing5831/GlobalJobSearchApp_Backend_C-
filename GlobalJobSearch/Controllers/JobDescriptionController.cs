using DropDownFilterDataAccessSQL;
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


        [HttpGet]
        [Route("ListJobDescription")]
        public bool ListJobDescription(JobDescription jobDescription)
        {
            if (jobDescription == null)
            {
                return false;
            }
            return JobDescriptionProcessor.GetCompanyName(jobDescription);
        }

        [HttpGet]
        [Route("JobDescriptionData")]
        public IEnumerable<JobDescriptionData> Get()
        {
            using (section8Entities entities = new section8Entities())
            {
                return entities.JobDescriptionDatas.ToList();
            }
        }

        [HttpGet]
        [Route("JobDescriptionData/Get")]
        public JobDescriptionData Get(int id)
        {
            using (section8Entities entities = new section8Entities())
            {
                return entities.JobDescriptionDatas.FirstOrDefault(e => e.ID == id);
            }
        }

        [HttpPost]
        [Route("EditJobDescription")]
        public bool EditJobDescription(JobDescription jobDescription)
        {
            if (jobDescription == null)
            {
                return false;
            }
            return JobDescriptionProcessor.EditJobDescription(jobDescription);
        }
    }
}
