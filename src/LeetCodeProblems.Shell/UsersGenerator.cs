using System.Collections.Generic;
using System;
using System.Text;

namespace LeetCodeProblems.Shell
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string PhoneNumber { get; set; } // New property
        public string Address { get; set; } // New property
        public DateTime DateOfBirth { get; set; } // New property
        public string Role { get; set; } // New property
        public bool IsActive { get; set; } // New property

        public static User CreateUser(int id)
        {
            return new User()
            {
                FirstName = nameof(FirstName),
                LastName = nameof(LastName),
                Email = nameof(Email),
                Id = id,
                PhoneNumber = "123-456-7890", // Example value
                Address = "123 Main St, City, Country", // Example value
                DateOfBirth = DateTime.Now.AddYears(-30), // Example value
                Role = "User", // Example value
                IsActive = true // Example value
            };
        }

        public IEnumerable<string> ToCsvParts()
        {
            yield return $"\"{nameof(Id)}:{Id}\",";
            yield return $"\"{nameof(FirstName)}:{FirstName}\",";
            yield return $"\"{nameof(LastName)}:{LastName}\",";
            yield return $"\"{nameof(Email)}:{Email}\",";
            yield return $"\"{nameof(PhoneNumber)}:{PhoneNumber}\",";
            yield return $"\"{nameof(Address)}:{Address}\",";
            yield return $"\"{nameof(DateOfBirth)}:{DateOfBirth:yyyy-MM-dd}\",";
            yield return $"\"{nameof(Role)}:{Role}\",";
            yield return $"\"{nameof(IsActive)}:{IsActive}\"";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in ToCsvParts())
            {
                sb.Append(part);
            }

            return sb.ToString();
        }
    }

    public class UsersGenerator
    {
        public static IEnumerable<User> GetUsers()
        {
            var count = 0;
            while (count < 1000)
            {
                yield return User.CreateUser(count);
                count++;
            }
        }
    }
}
