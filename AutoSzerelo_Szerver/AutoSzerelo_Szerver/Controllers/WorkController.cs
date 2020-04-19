using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSzerelo_Szerver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSzerelo_Szerver.Controllers
{
    [Route("api/work")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private Work[] works = new Work[]
        {
            new Work { WorkId=1, ClientName="Lakatos József", CarType="Ford", LicensePlate="ASD-123", Problem="valami baj van"},
            new Work { WorkId=2, ClientName="Tóth János", CarType="Nissan", LicensePlate="BTR-142", Problem="asdlol"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Work>> Get()
        {
            return Ok(works);
        }

        [HttpGet("{id}")]
        public ActionResult<Work> Get(long id)
        {
            var work = works.FirstOrDefault(i => i.WorkId == id);

            if(work != null)
            {
                return work;
            }
            else
            {
                return NotFound();
            }
        }
    }
}