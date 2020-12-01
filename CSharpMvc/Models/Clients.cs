using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpMvc.Models
{
    public class Clients
    {
        public List<Client> ObtenirListeCLients()
        {
            return new List<Client>
            {
                new Client {Age=34, Name="Jonathan Rougier"},
                new Client {Age=34, Name="Flavien Groi"},
                new Client {Age=36, Name="SOufiane"}
            };
        }
    }
}
