﻿using HrDatabaseBackend.Model.EmployeeModel;

namespace HrDatabaseBackend.Services.EmployeeService
{
    public interface IEmployeeService
    {

        List<Employee> Get();

        Employee Get(string id);

        Employee Create(Employee employee);
        void Update(string id, Employee employee);
        void Remove(string id);
    }
}
