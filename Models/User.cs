using System;
using System.Collections.Generic;

namespace MyApplication.Models
{
    public partial class User
    {
        public User()
        {
            Arenda = new HashSet<Arendum>();
            Users = new HashSet<Arendum>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Card { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Arendum> Arenda { get; set; }

        public virtual ICollection<Arendum> Users { get; set; }
    }
}
