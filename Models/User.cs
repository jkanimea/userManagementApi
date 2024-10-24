namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Gender { get; set; }

        public User()
        {
            Email = string.Empty; // Initialize with an empty string or some other default value
            Name = string.Empty; // Initialize with an empty string or some other default value
            Gender = string.Empty; // Initialize with an empty string or some other default value
        }


    }
}
