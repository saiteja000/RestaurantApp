using RestaurantApp.Models;
using RestaurantApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace RestaurantApp.Controllers
{
    public class RestaurantController : Controller
    {



        public ActionResult GetAllRestaurants()
        {



            RestaurantRepo restaurantRepo = new RestaurantRepo();
            ModelState.Clear();
            return View(restaurantRepo.GetAllRestaurants());
        }
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }



        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: Restaurant/Create
        public ActionResult AddRestaurantInfo()
        {
            return View();
        }



        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult AddRestaurantInfo(RestaurantInfo restaurantInfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RestaurantRepo restaurantRepo = new RestaurantRepo();



                    if (restaurantRepo.AddRestaurantInfo(restaurantInfo))
                    {
                        ViewBag.Message = "Restaurant details added successfully";

                    }
                }
                //return RedirectToAction("GetAllRestaurants");
                return View();
            }
            catch (Exception ex)
            {



                return View();
            }
        }



        public ActionResult AddCuisine()
        {
            return View();
        }



        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult AddCuisine(Cuisine cuisine)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RestaurantRepo restaurantRepo = new RestaurantRepo();



                    if (restaurantRepo.AddCuisine(cuisine))
                    {
                        ViewBag.Message = "Restaurant details added successfully";
                    }
                }



                return View();
            }
            catch (Exception ex)
            {



                return View();
            }
        }



        public ActionResult AddRestaurantMenu()
        {
            return View();
        }



        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult AddRestaurantMenu(RestaurantMenu restaurantMenu)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RestaurantRepo restaurantRepo = new RestaurantRepo();



                    if (restaurantRepo.AddRestaurantMenu(restaurantMenu))
                    {
                        ViewBag.Message = "RestaurantMenu details added successfully";
                    }
                }



                return View();
            }
            catch (Exception ex)
            {



                return View();
            }
        }



        public ActionResult AddMenuItemType()
        {
            return View();
        }



        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult AddMenuItemType(MenuItemType menuItemType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RestaurantRepo restaurantRepo = new RestaurantRepo();



                    if (restaurantRepo.AddMenuItemType(menuItemType))
                    {
                        ViewBag.Message = "MenuItemType details added successfully";
                    }
                }



                return View();
            }
            catch (Exception ex)
            {



                return View();
            }
        }



        // GET: Restaurant/Edit/5
        public ActionResult EditRestaurantInfo(int id)
        {
            RestaurantRepo restaurantRepo = new RestaurantRepo();
            return View(restaurantRepo.GetAllRestaurants().Find(restaurant => restaurant.id == id));

        }



        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult EditRestaurantInfo(int id, RestaurantInfo restaurantInfo)
        {
            try
            {
                // TODO: Add update logic here



                RestaurantRepo restaurantRepo = new RestaurantRepo();
                restaurantRepo.UpdateRestaurantInfo(restaurantInfo);
                return View();
            }
            catch (Exception ex)
            {



                return View();
            }
        }



        // GET: Restaurant/Delete/5
        public ActionResult DeleteRestaurantInfo(int id, RestaurantInfo restaurantInfo)
        {
            RestaurantRepo restaurantRepo = new RestaurantRepo();
            //return View(restaurantRepo.GetAllRestaurants().Find(restaurant => restaurant.id == id));
            if (restaurantRepo.DeleteRestaurantInfo(restaurantInfo))
            {
                ViewBag.AlertMsg = "RestaurantInfo details deleted successfully";



            }
            return RedirectToAction("GetAllRestaurants");



        }




    }
}