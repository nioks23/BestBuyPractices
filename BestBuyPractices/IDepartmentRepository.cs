using System;
using System.Collections.Generic;

namespace BestBuyPractices
{
    public interface IDepartmentRepository
    {

        IEnumerable<Department> GetAllDepartments();


    }
}
