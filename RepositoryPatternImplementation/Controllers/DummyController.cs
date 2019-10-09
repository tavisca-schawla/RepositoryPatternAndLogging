using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPatternImplementation.Models;
using RepositoryPatternImplementation.Repositories;

namespace RepositoryPatternImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        private DummyGenericRepository<DummyModel> _dummyRepository { get; }
        private readonly ILogger<DummyController> _logger;

        public DummyController(ILogger<DummyController> logger)
        {
            this._logger = logger;
            this._dummyRepository = new DummyGenericRepository<DummyModel>();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<DummyModel>> Get()
        {
            _logger.LogInformation("Dummy GetAll is accessed");
            _logger.LogWarning("Warning is logged");
            _logger.LogDebug("Debug log is logged");
            _logger.LogError("Error is logged");
            return this._dummyRepository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<DummyModel> Get(int id)
        {
            _logger.LogInformation("Dummy GetById is accessed");
            return this._dummyRepository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogInformation("Dummy Post is accessed");
            this._dummyRepository.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogInformation("Dummy Put is accessed");
            this._dummyRepository.Update(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogInformation("Dummy Delete is accessed");
            this._dummyRepository.Delete(id);
        }
    }
}
