using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GradesBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace GradesBooks.Controllers
{
    public class StudentController : Controller
    {

        private StudentContext context { get; set; }

        public StudentController(StudentContext ctx)
        {
            context = ctx;
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,GradePercent")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult List()
        {
            var students = context.Students
                .OrderBy(m => m.Name)
                .ToList();
            return View(students);
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || context.Students == null)
            {
                return NotFound();
            }

            var student = await context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || context.Students == null)
            {
                return NotFound();
            }

            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,Name,GradePercent")] Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(student);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(student);
        }
        private bool StudentExists(int id)
        {
            return context.Students.Any(e => e.StudentId == id);
        }
    }
}