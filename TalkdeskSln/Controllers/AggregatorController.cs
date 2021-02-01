using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalkdeskSln.Helper;

namespace Talkdesk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AggregatorController : Controller
    {
        // POST: AggregatorController/Aggregate
        [HttpPost]
        public ActionResult Aggregate([FromBody] string[] numbers)
        {
            try
            {
                Helper hlp = new Helper();
                string jResult = hlp.GetNumberData(numbers.ToList<string>());

                return StatusCode(200, Json(jResult));
            }
            catch
            {
                return View();
            }
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //Example Test
            string[] numbers = new string[] { "+1983236248", "+1 7490276403", "001382355A", "+351917382672", "+35191734022" };
            Helper hlp = new Helper(false);
            string jResult = hlp.GetNumberData(numbers.ToList<string>());

            return new string[] { jResult };
        }

    }
}
