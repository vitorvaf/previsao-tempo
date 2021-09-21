using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrevisaoTempo.Application.SearchUser.Interfaces;

namespace PrevisaoTempo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchUserAppService _service;

        public SearchController(ISearchUserAppService service)
        {
            _service = service;
            
        }      

        [HttpGet]
        public IActionResult SearchWeather(string cityname)
        {
            var city = _service.SearchWeather(cityname);

            if(city is null)
                return NotFound();
            
            return Ok(city);
        }

        [HttpGet]
        public IActionResult ListHistory()
        {
            var history = _service.ListHistorySearch();

            return Ok(history.ToArray());
        }



        
    }
}