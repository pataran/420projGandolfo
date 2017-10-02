using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManeMediaReMake.Data;
using ManeMediaReMake.Models;
using Microsoft.AspNetCore.Authorization;

namespace ManeMediaReMake.Controllers
{
    [Authorize]
    public class EventsModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EventsModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventsModel.ToListAsync());
        }

        // GET: EventsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsModel = await _context.EventsModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (eventsModel == null)
            {
                return NotFound();
            }

            return View(eventsModel);
        }

        // GET: EventsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EventTitle,EventCreated,EventCreatedBy,EventDate,EventTime,EventInfo,EventDetails,EventCheckIn")] EventsModel eventsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventsModel);
        }

        // GET: EventsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsModel = await _context.EventsModel.SingleOrDefaultAsync(m => m.ID == id);
            if (eventsModel == null)
            {
                return NotFound();
            }
            return View(eventsModel);
        }

        // POST: EventsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EventTitle,EventCreated,EventCreatedBy,EventDate,EventTime,EventInfo,EventDetails,EventCheckIn")] EventsModel eventsModel)
        {
            if (id != eventsModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventsModelExists(eventsModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eventsModel);
        }

        // GET: EventsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventsModel = await _context.EventsModel
                .SingleOrDefaultAsync(m => m.ID == id);
            if (eventsModel == null)
            {
                return NotFound();
            }

            return View(eventsModel);
        }

        // POST: EventsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventsModel = await _context.EventsModel.SingleOrDefaultAsync(m => m.ID == id);
            _context.EventsModel.Remove(eventsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventsModelExists(int id)
        {
            return _context.EventsModel.Any(e => e.ID == id);
        }
    }
}
