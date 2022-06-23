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
    }

    [HttpPost]

}