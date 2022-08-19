using System;
using System.Collections.Generic;

#nullable disable

namespace Ex3.Models
{
    public partial class WordType
    {
        public WordType()
        {
            Dictionaries = new HashSet<Dictionary>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Dictionary> Dictionaries { get; set; }
    }
}
