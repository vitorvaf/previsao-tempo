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
        [Route("getweather")]
        public IActionResult SearchWeather([FromQuery] string cityname)
        {
            var city = _service.getInfoWeatherByCityname(cityname);

            if (city is null)
            {
                return NotFound(cityname);
            }

            return Ok(city);
        }

        [HttpGet]
        [Route("list-all")]
        public IActionResult ListHistory()
        {
            var history = _service.ListHistorySearch();

            return Ok(history.ToArray());
        }
    }
}