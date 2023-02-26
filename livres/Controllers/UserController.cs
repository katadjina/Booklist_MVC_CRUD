//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using livres.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace livres.Controllers
//{
//    public class UserController : Controller
//    {


//        private static List<User> _users = new List<User>
//                {
//                    new User {Prenom = "Sara", Nom = "Pehlivan"},
//                    new User {Prenom = "Allessandra", Nom = "Rafaele"},
//                    new User{Prenom = "Eleonore", Nom = "Stultjens", },
//                    new User {Prenom = "Coline", Nom = "Ducourtieux"},
                    
//                };
//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            IEnumerable<StudentListItem> model = _students.Select(s => new StudentListItem() { Nom = s.Nom, Prenom = s.Prenom, Email = s.Email });
//            return View();
//        }


//        // GET: StudentController/Details/5
//        public ActionResult Details(string id)
//        {
//            Student stu = _students.SingleOrDefault(s => s.Email == id);
//            StudentDetails model = new StudentDetails() { Nom = stu.Nom, Prenom = stu.Prenom, DateNaissance = stu.DateNaissance, Email = stu.Email };
//            return View(model);
//        }

//        // GET: StudentController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: StudentController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(StudentCreateForm collection)
//        {
//            if (!ModelState.IsValid) return View();
//            else
//            {
//                collection.Email = $"{collection.Prenom}.{collection.Nom}@interface3.be";
//                _students.Add(new Student()
//                {
//                    Nom = collection.Nom,
//                    Prenom = collection.Prenom,
//                    DateNaissance = collection.DateNaissance,
//                    Email = collection.Email
//                });
//                return RedirectToAction(nameof(Index));
//            }
//        }

//        // GET: StudentController/Edit/5
//        public ActionResult Edit(string id)
//        {
//            Student stu = _students.SingleOrDefault(s => s.Email == id);
//            StudentEditForm model = new StudentEditForm()
//            {
//                Nom = stu.Nom,
//                Prenom = stu.Prenom,
//                DateNaissance = stu.DateNaissance,
//                Email = stu.Email
//            };
//            return View(model);
//        }

//        // POST: StudentController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(string id, StudentEditForm collection)
//        {
//            if (!ModelState.IsValid) return View();
//            else
//            {
//                Student stu = _students.SingleOrDefault(s => s.Email == id);
//                stu.Nom = collection.Nom;
//                stu.Prenom = collection.Prenom;
//                stu.DateNaissance = collection.DateNaissance;
//                return RedirectToAction(nameof(Index));
//            }
//        }

//        // GET: StudentController/Delete/5
//        public ActionResult Delete(string id)
//        {
//            Student stu = _students.SingleOrDefault(s => s.Email == id);
//            StudentDelete model = new StudentDelete()
//            {
//                Nom = stu.Nom,
//                Prenom = stu.Prenom,
//                Email = stu.Email
//            };
//            return View(model);
//        }

//        // POST: StudentController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(string id, StudentDelete collection)
//        {
//            _students.Remove(_students.SingleOrDefault(s => s.Email == id));
//            return RedirectToAction(nameof(Index));
//        }
//    }
//}

