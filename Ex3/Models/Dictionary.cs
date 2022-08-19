using System;
using System.Collections.Generic;

#nullable disable

namespace Ex3.Models
{
    public partial class Dictionary
    {
        public int WordId { get; set; }
        public string Word { get; set; }
        public DateTime EditDate { get; set; }
        public string Meaning { get; set; }
        public int Id { get; set; }

        public virtual WordType IdNavigation { get; set; }
    }
}
