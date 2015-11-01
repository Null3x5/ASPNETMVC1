using WebApplication1.Models;
using System.Collections.Generic;
using System.Web.Mvc;
namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        List<Class1> junkList = new List<Class1>();
        List<Class2> catList = new List<Class2>();

        Application_Start()
        {
            Class2 one1 = new Class2
            {
                Name = "Computer"
            };

            Class2 one2 = new Class2
            {
                Name = "Laptop"
            };

            Class2 one3 = new Class2
            {
                Name = "Plane"
            };

            Class2 one4 = new Class2
            {
                Name = "Boat"
            };

            catList.Add(one1);
            catList.Add(one3);
            catList.Add(one2);
            catList.Add(one4);

            Class1 loot1 = new Class1
            {
                id = 1,
                Code = "666",
                Name = "Evil Laptop",
                Category = "Laptop",
                Description = "Use at your own risk"
            };

            Class1 loot2 = new Class1
            {
                id = 2,
                Code = "007",
                Name = "Laptop",
                Category = "Laptop",
                Description = "Laptop used by 007"
            };

            Class1 loot3 = new Class1
            {
                id = 3,
                Code = "123",
                Name = "Another Laptop",
                Category = "Laptop",
                Description = "This wasn't used by 007"
            };
            Class1 loot4 = new Class1
            {
                id = 4,
                Code = "999",
                Name = "Nice Laptop",
                Category = "Laptop",
                Description = "Eviler then the other one"
            };

            Class1 loot5 = new Class1
            {
                id = 5,
                Code = "M16",
                Name = "Laptop",
                Category = "Laptop",
                Description = "Laptop used by 007"
            };

            Class1 loot6 = new Class1
            {
                id = 6,
                Code = "F16",
                Name = "Fighter Jet",
                Category = "Plane",
                Description = "Need a pilots license to use"
            };


            junkList.Add(loot1);
            junkList.Add(loot2);
            junkList.Add(loot3);
            junkList.Add(loot4);
            junkList.Add(loot5);
            junkList.Add(loot6);

        }

        public ViewResult AddE()
        {
            int number = junkList.Count;
            string name = Request.Form["name"];
            string category = Request.Form["category"];
            string code = Request.Form["code"];
            string description = Request.Form["description"];
            if (!name.Equals(null)&!category.Equals(null)&!code.Equals(null)&!description.Equals(null))
            {
                Class1 loot = new Class1
                {
                    id = 6,
                    Code = code,
                    Name = name,
                    Category = category,
                    Description = description
                };


                junkList.Add(loot);
            }
            return View("Index");

        }




        public ViewResult Index()
        {
            ViewBag.list = junkList;
            return View();
        }

        public ViewResult Index2()
        {
            ViewBag.list = junkList;

            string name = Request.Form["name"];
            Class2 another = new Class2
            {
                Name = name
            };

            catList.Add(another);
            //ViewBag.list = junkList;
            ViewBag.list = catList;

            return View("AddEquipment");
        }
        
        public ViewResult AddCat()
        {
            return View();
        }

        public ViewResult ItemInfo(int id)
        {
            ViewBag.list = junkList;
            ViewBag.id = id;
            return View();
        }

        public ViewResult AddEquipment()
        {

            ViewBag.list = catList;
            return View();
        }
    }
}