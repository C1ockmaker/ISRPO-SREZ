using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPO_SREZ.Models
{
    internal class Client
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public string FIO
        {
            get
            {
                return LastName + ' ' + FirstName[0] + '.' + ' ' + Patronymic[0] + '.';
            }
        }
    }
}
