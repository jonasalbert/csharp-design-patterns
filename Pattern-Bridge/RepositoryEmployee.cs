using System;

namespace Pattern_Bridge
{
    public class RepositoryEmployee: Repository<Employee>
    {
        public RepositoryEmployee()
        {
            this.List.Add(new Employee() { Id = Guid.NewGuid(), FirstName = "Jim", LastName = "Jones", MiddleName = "" });
            this.List.Add(new Employee() { Id = Guid.NewGuid(), FirstName = "Samual", LastName = "Jackson", MiddleName = "" });
            this.List.Add(new Employee() { Id = Guid.NewGuid(), FirstName = "Allen", LastName = "Good", MiddleName = "" });
            this.List.Add(new Employee() { Id = Guid.NewGuid(), FirstName = "Lisa", LastName = "Giolani", MiddleName = "" });
        }
    }
}