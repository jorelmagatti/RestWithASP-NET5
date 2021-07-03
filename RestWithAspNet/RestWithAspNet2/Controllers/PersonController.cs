using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNet2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        #region Private Parameters
        private readonly ILogger<PersonController> _logger;
        #endregion

        #region Constructor
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Get Call Controller Actions
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        #endregion
    }
}
