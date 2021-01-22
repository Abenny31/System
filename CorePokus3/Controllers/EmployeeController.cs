using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePokus3.Database;
using CorePokus3.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CorePokus3.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
         private LoginDbContext _context;

        public EmployeeController(LoginDbContext context)
        {
            _context = context;
        }
         public async Task<IActionResult> Index()
        {

            return View(await _context.Persons.ToListAsync());
        }

public async Task<IActionResult> Details(int? id)  
        {  
            //Dodat NotFound!
            if (id == null)  
            {  
                return NotFound();  
            }  
  
            var employe = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);  

  
             
  
            if (employe == null)  
            {  
                return NotFound();  
            }  
  
            return View(employe);  
        }  

        public async Task<IActionResult> Edit(int? id)  
        {  
            if (id == null)  
            {  
                return NotFound();  
            }  
  
            var employe = await _context.Persons.FindAsync(id);  
            var employeViewModel = new RegisterViewModel()  
            {  
                FirstName = employe.FirstName,
                    LastName = employe.LastName,
                    Email = employe.Email,
                    IsEmployee = employe.IsEmployee,
                    Address = employe.Address,
                    City = employe.City,
                    DateOfBirth = employe.DateOfBirth,
                    IsOutsorced = employe.IsOutsorced,
                    IsVolunteer = employe.IsVolunteer,
                    PIN = employe.PIN
                
            };  
  
            if (employe == null)  
            {  
                return NotFound();  
            }  
            return View(employeViewModel);  
        }  
  
        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public async Task<IActionResult> Edit(int id, employeViewModel model)  
        {  
            if (ModelState.IsValid)  
            {  
                var employe = await db.employes.FindAsync(model.Id);  
                employe.employeName = model.employeName;  
                employe.Qualification = model.Qualification;  
                employe.Experience = model.Experience;  
                employe.SpeakingDate = model.SpeakingDate;  
                employe.SpeakingTime = model.SpeakingTime;  
                employe.Venue = model.Venue;  
  
                if (model.employePicture != null)  
                {  
                    if (model.ExistingImage != null)  
                    {  
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads", model.ExistingImage);  
                        System.IO.File.Delete(filePath);  
                    }  
  
                    employe.ProfilePicture = ProcessUploadedFile(model);  
                }  
                db.Update(employe);  
                await db.SaveChangesAsync();  
                return RedirectToAction(nameof(Index));  
            }  
            return View();  
        }  






    }
}
