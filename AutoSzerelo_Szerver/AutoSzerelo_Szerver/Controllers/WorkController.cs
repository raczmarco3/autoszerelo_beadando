using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSzerelo_Szerver.Models;
using AutoSzerelo_Szerver.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSzerelo_Szerver.Controllers
{
    [Route("api/work")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Work>> Get()
        {
            var works = WorkRepository.GetWork();
            return Ok(works);
        }

        [HttpGet("{id}")]
        public ActionResult<Work> Get(long id)
        {
            var works = WorkRepository.GetWork();
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

        [HttpPost]
        public ActionResult Post(Work work)
        {
            var works = WorkRepository.GetWork();
            var newId = GetNewId(works);
            //string Date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            DateTime Date = DateTime.Now;

            work.WorkId = newId;
            work.Date = Date;
            works.Add(work);
            WorkRepository.StoreWork(works);

            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Work work)
        {
            var works = WorkRepository.GetWork();
            var oldWork = works.FirstOrDefault(x => x.WorkId == work.WorkId);

            if(oldWork != null)
            {
                oldWork.ClientName = work.ClientName;
                oldWork.CarType = work.CarType;
                oldWork.LicensePlate = work.LicensePlate;
                oldWork.Problem = work.Problem;
            }
            else
            {
                var newId = GetNewId(works);
                work.WorkId = newId;
                works.Add(work);
            }

            WorkRepository.StoreWork(works);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var works = WorkRepository.GetWork();
            var work = works.FirstOrDefault(x => x.WorkId == id);

            if(work != null)
            {
                works.Remove(work);
                WorkRepository.StoreWork(works);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        //Létrehozunk egy még nem létező id-t és visszadjuk
        private long GetNewId(IList<Work> works)
        {
            long id = 0;
            
            foreach(var work in works)
            {
                if(id < work.WorkId)
                {
                    id = work.WorkId;
                }                
            }

            return id + 1;
        }
    }
}