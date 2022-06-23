using FitnessTracker.Models;
using FitnessTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly ExercisesService _es;

        public ExercisesController(ExercisesService es)
        {
            _es = es;
        }


        [HttpPost]
        public ActionResult<Exercise> Create([FromBody] Exercise newExercise)
        {
            try
            {
                Exercise created = _es.Create(newExercise);
                return Ok(created);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }

}