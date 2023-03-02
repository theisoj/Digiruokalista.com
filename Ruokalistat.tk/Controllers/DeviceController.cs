using Digiruokalista.com.Migrations;
using Digiruokalista.com.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ruokalistat.tk.Models;
using System.Threading.Tasks;

namespace Digiruokalista.com.Controllers
{
    [Authorize]
    public class DeviceController : Controller
    {
        private readonly tietokantaContext _context;

        private readonly IConfiguration _configuration;

        public DeviceController(tietokantaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            return View(await _context.Laitteet.ToListAsync());
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            ViewBag.PublicKey = _configuration.GetSection("VapidKeys")["PublicKey"];

            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PushEndpoint,PushP256DH,PushAuth")] Device devices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(devices);
        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Laitteet
                .SingleOrDefaultAsync(m => m.Id == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devices = await _context.Laitteet.SingleOrDefaultAsync(m => m.Id == id);
            _context.Laitteet.Remove(devices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

