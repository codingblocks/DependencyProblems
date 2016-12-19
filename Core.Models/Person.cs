using System;
using log4net;
using log4net.Config;

namespace Core.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Person));

        public string FirstName;
        public string LastName;
        public int Age;
        public Gender Gender;

        public Person(string firstName, string lastName, int age, string gender)
        {
            Gender parseGender;

            FirstName = firstName;
            LastName = lastName;
            Age = age;

            var parsedSuccessfully = Enum.TryParse(gender, true, out parseGender);
            if (parsedSuccessfully)
            {
                Gender = parseGender;
            }

            log.Info(this);
        }
    }
}
