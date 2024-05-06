using Microsoft.AspNetCore.Mvc;
using TaskWeb.DAL;
using TaskWeb.Models;
using TaskWeb.ViewModels;

namespace TaskWeb.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            Department department = new Department()
            {
                Name = "UI/UX design",
                BackGroundImg = "img/services-01.jpg"
            };
            Department department1 = new Department()
            {
                Name = "Social Media",
                BackGroundImg = "img/services-02.jpg"
            };
            Department department2 = new Department()
            {
                Name = "Marketing",
                BackGroundImg = "img/services-03.jpg"
            };
            Department department3 = new Department()
            {
                Name = "Graphic",
                BackGroundImg = "img/services-04.jpg"
            };
            Department department4 = new Department()
            {
                Name = "Digtal Marketing",
                BackGroundImg = "img/services-05.jpg"
            };
            Department department5 = new Department()
            {
                Name = "Market Research",
                BackGroundImg = "img/services-06.jpg"
            };
            Department department6 = new Department()
            {
                Name = "Business",
                BackGroundImg = "img/services-07.jpg"
            };
            Department department7 = new Department()
            {
                Name = "Branding",
                BackGroundImg = "img/services-08.jpg"
            };

            Works work = new Works()
            {
                Name= "Social Media",
                Title= "Ullamco laboris nisi ut aliquip ex",
                BackGroundImg= "img/recent-work-01.jpg"
            };
            Works work1 = new Works()
            {
                Name = "Web Marketing",
                Title = "Psum officia anim id est laborum.",
                BackGroundImg = "img/recent-work-02.jpg"
            };
            Works work2 = new Works()
            {
                Name = "R & D",
                Title = "Sum dolor sit consencutur",
                BackGroundImg = "img/recent-work-03.jpg"
            };
            Works work3 = new Works()
            {
                Name = "Public Relation",
                Title = "Lorem ipsum dolor sit amet",
                BackGroundImg = "img/recent-work-04.jpg"
            };
            Works work4 = new Works()
            {
                Name = "Branding",
                Title = "Put enim ad minim veniam",
                BackGroundImg = "img/recent-work-05.jpg"
            };
            Works work5 = new Works()
            {
                Name = "Creative Design",
                Title = "Mollit anim id est laborum.",
                BackGroundImg = "img/recent-work-06.jpg"
            };

            List<Works> works = new List<Works>();
            List<Department> departments = new List<Department>();
            departments.Add(department);
            departments.Add(department1);
            departments.Add(department2);
            departments.Add(department3);
            departments.Add(department4);
            departments.Add(department5);
            departments.Add(department6);
            departments.Add(department7);
            works.Add(work);
            works.Add(work1);
            works.Add(work2);
            works.Add(work3);
            works.Add(work4);
            works.Add(work5);

            HomeVM homeVM = new HomeVM()
            {
                Departments = departments,
                Works = works,
            };

            //_dbContext.Departments.Add(department);
            //_dbContext.Departments.Add(department1);
            //_dbContext.Departments.Add(department2);
            //_dbContext.Departments.Add(department3);
            //_dbContext.Departments.Add(department4);
            //_dbContext.Departments.Add(department5);
            //_dbContext.Departments.Add(department6);
            //_dbContext.Departments.Add(department7);


            //_dbContext.SaveChanges();

            return View(homeVM);
        }
    }
}
