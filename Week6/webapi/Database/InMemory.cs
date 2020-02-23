using System.Collections.Generic;


namespace webapi.Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "01919",
                Email = "tom.smith@school.com"
            },
            new Student {
                Id = 2,
                StudentId = "11919",
                Email = "allen.wright@rb.com"
            },
            new Student {
                Id = 3,
                StudentId = "01856",
                Email = "henry.weinhard@rb.com"
            },
            new Student {
                Id = 4,
                StudentId = "01990",
                Email = "stewarts@rb.com"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "Jim",
                MiddleInitial = "P",
                LastName = "Halpert"
            },
            new Instructor {
                Id = 2,
                FirstName = "Dwight",
                MiddleInitial = "K",
                LastName = "Shrute"
            },
            new Instructor {
                Id = 3,
                FirstName = "Michael",
                MiddleInitial = "P",
                LastName = "Scott"
            },
            new Instructor {
                Id = 4,
                FirstName = "Pam",
                MiddleInitial = "F",
                LastName = "Beasley"
            }
        };
    }
}