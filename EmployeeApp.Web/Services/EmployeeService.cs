using EmployeeApp.Web.Models;

namespace EmployeeApp.Web.Services;

public class EmployeeService
{
    static List<Employee> employees = new List<Employee>();

    public Employee[] GetAll() => employees.OrderBy(x => x.Id).ToArray();

    public void Add(Employee employee)
    {
        employee.Id = employees.Count == 0 ? 1 : employees.Max(x => x.Id) + 1;

        employees.Add(employee);
    }

    public Employee GetById(int id) => employees.Single(x => x.Id == id);
}
