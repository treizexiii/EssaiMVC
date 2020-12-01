using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMvc.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        public Contact(int id, string name, string tel)
        {
            Id = id;
            Name = name;
            Tel = tel;
        }
    }
}
