using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        private int MyVar;

        public int MyProperty
        {
            get { return MyVar; }
            set { MyVar = value; }

        }


        public ICollection<Enrollment>Enrollments { get; set; }
    }
}