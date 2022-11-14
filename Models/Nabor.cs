using System;
using System.Collections.Generic;

namespace MyApplication.Models
{
    public partial class Nabor
    {
        public Nabor()
        {
            Arenda = new HashSet<Arendum>();
        }

        public int Id { get; set; }
        public string ArendaComputer { get; set; } = null!;
        public TimeSpan TimeBegin { get; set; }
        public int Cost { get; set; }
        public TimeSpan TimeOut { get; set; }

        public virtual ICollection<Arendum> Arenda { get; set; }
    }
}
