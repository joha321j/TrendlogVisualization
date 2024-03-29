﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrendlogVisualization.Data;
using TrendlogVisualization.Models;

namespace TrendlogVisualization.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrendlogContext _context;
        private IndexViewModel _indexViewModel;

        public HomeController(TrendlogContext context)
        {
            _context = context;
        }

        [HttpPost]
        public int GiveDataToCharts()
        {
            Random nr = new Random();
            int randNr = nr.Next(1, 100);
            return randNr;
        }


        public async Task<IActionResult> Index(int? pageNumber)
        {
            var superData = from s in _context.SuperData
                select s;

            var authors = _context.Authors.Select(a => a);


            PaginatedList<Author> paginatedAuthors =
                await PaginatedList<Author>.CreateAsync(authors, pageNumber ?? 1);

            _indexViewModel = new IndexViewModel
            {
                SuperDatas = await superData.ToListAsync(),
                Authors = paginatedAuthors
            };
            
            return View(_indexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public IActionResult ElementsDropDowns()
        {
            return View();
        }

        public IActionResult ElementsButtonsStandard()
        {
            return View();
        }

        public IActionResult ElementsIcons()
        {
            return View();
        }

        public IActionResult ElementsBadgesLabels()
        {
            return View();
        }

        public IActionResult ElementsCards()
        {
            return View();
        }

        public IActionResult ElementsListGroup()
        {
            return View();
        }

        public IActionResult ElementsNavigation()
        {
            return View();
        }

        public IActionResult ElementsUtilities()
        {
            return View();
        }

        public IActionResult ComponentsTabs()
        {
            return View();
        }

        public IActionResult ComponentsAccordions()
        {
            return View();
        }

        public IActionResult ComponentsNotifications()
        {
            return View();
        }

        public IActionResult ComponentsModals()
        {
            return View();
        }

        public IActionResult ComponentsProgressBars()
        {
            return View();
        }

        public IActionResult ComponentsTooltipsPopovers()
        {
            return View();
        }

        public IActionResult ComponentsCarousel()
        {
            return View();
        }

        public IActionResult ComponentsCalender()
        {
            return View();
        }

        public IActionResult ComponentsPagination()
        {
            return View();
        }

        public IActionResult ComponentsScrollableElements()
        {
            return View();
        }

        public IActionResult ComponentsMaps()
        {
            return View();
        }

        public IActionResult TablesRegular()
        {
            return View();
        }

        public IActionResult DashBoardBoxes()
        {
            return View();
        }

        public IActionResult FormsControls()
        {
            return View();
        }

        public IActionResult FormsLayout()
        {
            return View();
        }

        public IActionResult FormsValidation()
        {
            return View();
        }

        public IActionResult ChartsChartjs()
        {
            return View();
        }
    }
}
