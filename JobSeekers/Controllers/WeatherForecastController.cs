using JobSeekers.Model;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekers.Controllers
{
    public class JobSeekers : Controller
    {

        private readonly DBContextJob _dpprod;
        private Model.JSiteHome JSiteHomeSiteHome;

        public JobSeekers(DBContextJob dpprod)
        {
            _dpprod = dpprod;
        }

        [HttpPut("JobSeekersAdd")]
        public IActionResult Index(JSiteHome JSiteHome)
        {
            JSiteHome jSiteHome = JSiteHome;
            _dpprod.jsiteHomes.Add(JSiteHomeSiteHome);
            _dpprod.SaveChanges();

            return Ok();
        }

        [HttpGet("JobSeekersShow")]
        public IEnumerable<JSiteHome> GetAll()
        {
            return _dpprod.JSiteHomes;
        }
    }

    public class JSiteHome
    {
    }
}