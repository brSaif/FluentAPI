namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  ICollection<Course> Courses { get; set; }
    }
}
