using TaskWeb.Models;

namespace TaskWeb.ViewModels
{
    public class HomeVM
    {
        public List<Department> Departments { get; set; }
        public List<Works> Works { get; set; }
    }
}
