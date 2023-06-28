﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Movie_Name = "Shrek !" };

            var customers = new List<Customer> {

              new Customer {Name = "Customer 1"},
              new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
              Movie = movie,
              Customers = customers
            };

            //return View(movie);
            return View(viewModel);

            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
          return Content("id" + id);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
          return Content( year + "/" + month);
        }

    

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
          if(!pageIndex.HasValue)
            {
            pageIndex = 1;
          }
          if(String.IsNullOrWhiteSpace(sortBy))
          {
            sortBy = "name";
          }
        
          return Content(String.Format("pageIndex = { 0 }& sortBy{ 1}", pageIndex, sortBy));
        }
    }
}