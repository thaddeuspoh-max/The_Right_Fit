using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using The_Right_Fit.Data;
using The_Right_Fit.Domain;

namespace The_Right_Fit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutPlanExercisesController : ControllerBase
    {
        private readonly The_Right_FitContext _context;

        public WorkoutPlanExercisesController(The_Right_FitContext context)
        {
            _context = context;
        }

        // GET: api/WorkoutPlanExercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkoutPlanExercise>>> GetWorkoutPlanExercise()
        {
            return await _context.WorkoutPlanExercise.ToListAsync();
        }

        // GET: api/WorkoutPlanExercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutPlanExercise>> GetWorkoutPlanExercise(int id)
        {
            var workoutPlanExercise = await _context.WorkoutPlanExercise.FindAsync(id);

            if (workoutPlanExercise == null)
            {
                return NotFound();
            }

            return workoutPlanExercise;
        }

        // PUT: api/WorkoutPlanExercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkoutPlanExercise(int id, WorkoutPlanExercise workoutPlanExercise)
        {
            if (id != workoutPlanExercise.Id)
            {
                return BadRequest();
            }

            _context.Entry(workoutPlanExercise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkoutPlanExerciseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WorkoutPlanExercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkoutPlanExercise>> PostWorkoutPlanExercise(WorkoutPlanExercise workoutPlanExercise)
        {
            _context.WorkoutPlanExercise.Add(workoutPlanExercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkoutPlanExercise", new { id = workoutPlanExercise.Id }, workoutPlanExercise);
        }

        // DELETE: api/WorkoutPlanExercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkoutPlanExercise(int id)
        {
            var workoutPlanExercise = await _context.WorkoutPlanExercise.FindAsync(id);
            if (workoutPlanExercise == null)
            {
                return NotFound();
            }

            _context.WorkoutPlanExercise.Remove(workoutPlanExercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkoutPlanExerciseExists(int id)
        {
            return _context.WorkoutPlanExercise.Any(e => e.Id == id);
        }
    }
}
