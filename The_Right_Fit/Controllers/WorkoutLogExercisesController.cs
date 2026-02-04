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
    public class WorkoutLogExercisesController : ControllerBase
    {
        private readonly The_Right_FitContext _context;

        public WorkoutLogExercisesController(The_Right_FitContext context)
        {
            _context = context;
        }

        // GET: api/WorkoutLogExercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkoutLogExercise>>> GetWorkoutLogExercise()
        {
            return await _context.WorkoutLogExercise.ToListAsync();
        }

        // GET: api/WorkoutLogExercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutLogExercise>> GetWorkoutLogExercise(int id)
        {
            var workoutLogExercise = await _context.WorkoutLogExercise.FindAsync(id);

            if (workoutLogExercise == null)
            {
                return NotFound();
            }

            return workoutLogExercise;
        }

        // PUT: api/WorkoutLogExercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkoutLogExercise(int id, WorkoutLogExercise workoutLogExercise)
        {
            if (id != workoutLogExercise.Id)
            {
                return BadRequest();
            }

            _context.Entry(workoutLogExercise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkoutLogExerciseExists(id))
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

        // POST: api/WorkoutLogExercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkoutLogExercise>> PostWorkoutLogExercise(WorkoutLogExercise workoutLogExercise)
        {
            _context.WorkoutLogExercise.Add(workoutLogExercise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkoutLogExercise", new { id = workoutLogExercise.Id }, workoutLogExercise);
        }

        // DELETE: api/WorkoutLogExercises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkoutLogExercise(int id)
        {
            var workoutLogExercise = await _context.WorkoutLogExercise.FindAsync(id);
            if (workoutLogExercise == null)
            {
                return NotFound();
            }

            _context.WorkoutLogExercise.Remove(workoutLogExercise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkoutLogExerciseExists(int id)
        {
            return _context.WorkoutLogExercise.Any(e => e.Id == id);
        }
    }
}
