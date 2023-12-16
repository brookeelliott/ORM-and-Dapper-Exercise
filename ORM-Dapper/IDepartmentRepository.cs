using System;
using System.Collections.Generic;
using ORM_Dapper;

namespace ORM_Dapper
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    }
}

