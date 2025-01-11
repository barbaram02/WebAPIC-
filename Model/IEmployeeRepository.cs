namespace WebAPIC_.Model
{
    //Padrão Repository
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> GetAll();
    }
}
