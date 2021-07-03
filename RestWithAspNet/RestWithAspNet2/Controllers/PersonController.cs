using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithAspNet2.Model;
using RestWithAspNet2.Services.Interfaces;
using RestWithAspNet2.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RestWithAspNet2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        #region Private Parameters
        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;
        #endregion

        #region Constructor
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        #endregion

        #region Get Call Controller Actions
        [HttpGet("GetVersion")]
        public IActionResult GetVersion()
        {
            return Ok(VersionUtil.GetVersionString());
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }  

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null)
                return NotFound();
            else
                return Ok(person);
        }
        #endregion

        #region Post Call Controller Action
        [HttpPost]
        public IActionResult Post([FromBody] PersonModel person)
        {
            if (person != null)
                return Ok(_personService.Create(person));
            else
                return BadRequest();
        }
        #endregion

        #region Put Call Controller Action
        [HttpPut]
        public IActionResult Put([FromBody] PersonModel person)
        {
            if (person != null)
                return Ok(_personService.Update(person));
            else
                return BadRequest();
        }
        #endregion

        #region Delete Call Controller Action
        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] long Id)
        {
            if (Id != 0)
            {
                _personService.DeleteById(Id);
                return Ok();
            }
            else
                return BadRequest();
        }
        #endregion
    }
}
