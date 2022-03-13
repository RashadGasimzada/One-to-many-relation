using LessonMigration.Data;
using LessonMigration.Models;
using LessonMigration.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.Where(m=>m.IsDeleted == false).ToListAsync();
            List<Product> products = await _context.Products.Where(m=>m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.Images)
                .OrderByDescending(m=>m.Id)
                .Take(8)
                .ToListAsync();
            List<Gift> gifts = await _context.Gifts.Where(d =>d.IsDeleted == false).Include(m => m.FooterText).ToListAsync();
            FlowerExpertsTitle flowerExpertsTitle = await _context.FlowerExpertsTitles.Where(m => m.IsDeleted == false).FirstOrDefaultAsync();
            List<FlowerExpertProfile> flowerExpertProfiles = await _context.FlowerExpertProfiles.Where(m => m.IsDeleted == false).ToListAsync();
            BlogTitle blogTitle = await _context.BlogTitles.Where(m => m.IsDeleted == false).FirstOrDefaultAsync();
            List<BlogProfile> blogProfiles = await _context.BlogProfiles.Where(m => m.IsDeleted == false).ToListAsync();
            List<IGAccount> iGAccounts = await _context.IGAccounts.Where(m => m.IsDeleted == false).ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                Categories = categories,
                Products = products,
                Gifts = gifts,
                FlowerExpertProfiles = flowerExpertProfiles,
                FlowerExpertsTitle = flowerExpertsTitle,
                BlogProfiles = blogProfiles,
                BlogTitle = blogTitle,
                IGAccounts = iGAccounts,
            };

            return View(homeVM);
        }
    }
}
