using System;
using System.Collections.Generic;

namespace SortingAlgorithmsApp.DAL.Entities
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Salary { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
