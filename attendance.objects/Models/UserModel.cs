using System;

namespace attendance.objects.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDatetime { get; set; }
    }
}
