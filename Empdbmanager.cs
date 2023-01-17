
namespace DAL;
using BOL;

public class Empdbmanager{


    public static List<Employee> GetAllEmployees(){

        using(var context=new CollectionContext()){

            var employees= from emp in context.employees select emp;
            return employees.ToList<Employee>();
        }
    }
}
