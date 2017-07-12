using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace flip.api.Controllers
{
    [Route("establishments")]
    public class EstablishmentsController
    {
        // GET establishments
        [HttpGet]      
        public IEnumerable<string> Get()
        {
            return new string[] { "Pet Store", "Bodyshop" };
        }
    }
}
