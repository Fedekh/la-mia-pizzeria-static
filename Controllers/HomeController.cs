﻿using la_mia_pizzeria_static.Classes;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Pizza> _menu;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _menu = GeneratePizzaMenu();
        }

        private List<Pizza> GeneratePizzaMenu()
        {
            List<Pizza> menu = new List<Pizza>();

            menu.Add(new Pizza("Margherita", "Tomato sauce, mozzarella cheese, basil", "https://i0.wp.com/ivoatrastevere.it/wp-content/uploads/2021/03/PIZZA-ROSSA-MARGHERITA.jpg?fit=502%2C350&ssl=1", 8.99));
            menu.Add(new Pizza("Pepperoni", "Tomato sauce, pepperoni, mozzarella cheese", "https://www.ricettedalmondo.it/images/foto-ricette/p/29316-pizza-ai-peperoni.jpg", 9.99));
            menu.Add(new Pizza("Funghi", "Tomato sauce, mushrooms, mozzarella cheese", "https://blog.giallozafferano.it/odoredifelicita/wp-content/uploads/2019/10/pizza-ai-funghi-porcini-1mod.jpg", 8.99));
            menu.Add(new Pizza("Quattro Formaggi", "Tomato sauce, four types of cheese", "https://i0.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2017/06/3234_Pizza.jpg?resize=895%2C616&ssl=1", 10.99));
            menu.Add(new Pizza("Hawaiian", "Tomato sauce, ham, pineapple, mozzarella cheese", "https://mandolina.co/wp-content/uploads/2023/06/pizza-hawaian-2.jpg", 10.99));
            menu.Add(new Pizza("Vegetariana", "Tomato sauce, bell peppers, onions, olives, mozzarella cheese", "https://www.guardini.com/images/guardinispa/ricette/full/pizza_set_2021_full.jpg", 9.99));
            menu.Add(new Pizza("Capricciosa", "Tomato sauce, ham, mushrooms, artichokes, mozzarella cheese", "https://www.buttalapasta.it/wp-content/uploads/2017/11/pizza-capricciosa.jpg", 11.99));
            menu.Add(new Pizza("Diavola", "Tomato sauce, spicy salami, mozzarella cheese", "https://www.silviocicchi.com/pizzachef/wp-content/uploads/2015/03/d1.jpg", 9.99));
            menu.Add(new Pizza("Carbonara", "Cream sauce, bacon, eggs, mozzarella cheese", "https://img-global.cpcdn.com/recipes/3730d0f71fd022f2/1200x630cq70/photo.jpg", 12.99));
            menu.Add(new Pizza("Pesto", "Pesto sauce, cherry tomatoes, mozzarella cheese", "https://blog.giallozafferano.it/cucinachetipassaoriginal/wp-content/uploads/2020/11/pizza-al-pesto-20.jpg", 10.99));
            menu.Add(new Pizza("Prosciutto e Rucola", "Tomato sauce, prosciutto, arugula, mozzarella cheese", "https://i2.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2016/12/3018_Pizza.jpg?resize=895%2C616&ssl=1", 11.99));
            menu.Add(new Pizza("Siciliana", "Tomato sauce, anchovies, olives, capers, mozzarella cheese", "https://gdsit.cdn-immedia.net/2014/10/Pizza.jpg", 10.99));
            menu.Add(new Pizza("Calzone", "Folded pizza with tomato sauce, ham, mushrooms, mozzarella cheese", "https://i2.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2020/09/4460_Calzoni.jpg?resize=895%2C616&ssl=1", 11.99));
            menu.Add(new Pizza("Marinara", "Tomato sauce, garlic, oregano", "marinara.jpg", 7.99));
            menu.Add(new Pizza("Tartufo", "Cream sauce, truffle oil, mushrooms, mozzarella cheese", "https://tartuber.it/wp-content/uploads/2021/01/Cover-blog-Tartuber-1024x683.png", 13.99));
            menu.Add(new Pizza("Salmone", "Cream sauce, smoked salmon, capers, mozzarella cheese", "https://blog.giallozafferano.it/passionebimby/wp-content/uploads/2020/10/DSC_0227-scaled.jpeg", 12.99));
            menu.Add(new Pizza("Napoletana", "Tomato sauce, anchovies, olives, oregano", "https://latteriasorrentina.com/wp-content/uploads/2019/06/come-fare-la-vera-pizza-1764x882.jpg", 8.99));
            menu.Add(new Pizza("Mediterranea", "Tomato sauce, sun-dried tomatoes, olives, feta cheese", "https://i2.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2016/12/3016_Pizza.jpg?resize=895%2C616&ssl=1", 11.99));
            menu.Add(new Pizza("Bianca", "Olive oil base, ricotta cheese, spinach, garlic", "https://www.lamiabuonaforchetta.it/wp-content/uploads/2018/01/MG_1360.jpg", 9.99));
            menu.Add(new Pizza("Rustica", "Tomato sauce, sausage, onions, bell peppers, mozzarella cheese", "https://blog.giallozafferano.it/lacucinasottosopra/wp-content/uploads/2019/11/IMG_5273jpg-720x480.jpg", 10.99));

            return menu;
        }
        
      
            [HttpGet]
        public IActionResult Index()
        {
            return View(_menu);
        }

        public IActionResult User()
        {
            return View(_menu);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}