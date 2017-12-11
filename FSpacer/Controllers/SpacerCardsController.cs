using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FSpacer.Data;
using FSpacer.Models;

namespace FSpacer.Controllers
{
    public class SpacerCardsController : Controller
    {
        private readonly AGCDbContext _context;

        public SpacerCardsController(AGCDbContext context)
        {
            _context = context;
        }

        // GET: SpacerCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpacerCards.ToListAsync());
        }

        // GET: SpacerCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spacerCard = await _context.SpacerCards
                .SingleOrDefaultAsync(m => m.ID == id);
            if (spacerCard == null)
            {
                return NotFound();
            }

            return View(spacerCard);
        }

        // GET: SpacerCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpacerCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,HorizontalGearCaseDeviation,HorizontalCarrierDeviation,Bearing,HMDGear,VerticalGearCaseDeviation,VerticalCarrierDeviation,GearMount,VMDGear,DriveNumber,OperatorID,Date,Active,Backlash,HorizontalSetting,OutputSetting,HelicalGearNumber,HelicalPinionNumber,HorizontalSpacerLength,VerticalSpacerLength")] SpacerCard spacerCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spacerCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spacerCard);
        }

        // GET: SpacerCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spacerCard = await _context.SpacerCards.SingleOrDefaultAsync(m => m.ID == id);
            if (spacerCard == null)
            {
                return NotFound();
            }
            return View(spacerCard);
        }

        // POST: SpacerCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,HorizontalGearCaseDeviation,HorizontalCarrierDeviation,Bearing,HMDGear,VerticalGearCaseDeviation,VerticalCarrierDeviation,GearMount,VMDGear,DriveNumber,OperatorID,Date,Active,Backlash,HorizontalSetting,OutputSetting,HelicalGearNumber,HelicalPinionNumber,HorizontalSpacerLength,VerticalSpacerLength")] SpacerCard spacerCard)
        {
            if (id != spacerCard.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spacerCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpacerCardExists(spacerCard.ID))
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
            return View(spacerCard);
        }

        // GET: SpacerCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spacerCard = await _context.SpacerCards
                .SingleOrDefaultAsync(m => m.ID == id);
            if (spacerCard == null)
            {
                return NotFound();
            }

            return View(spacerCard);
        }

        // POST: SpacerCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spacerCard = await _context.SpacerCards.SingleOrDefaultAsync(m => m.ID == id);
            _context.SpacerCards.Remove(spacerCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpacerCardExists(int id)
        {
            return _context.SpacerCards.Any(e => e.ID == id);
        }

        [HttpPost, ActionName("Update")]
        public IActionResult SpacerCardUpdate(SpacerCard sc)
        {

            _context.SpacerCards.Add(sc);

            _context.SaveChanges();
            return View("SpacerCardConfirmed");

        }
    }
}
