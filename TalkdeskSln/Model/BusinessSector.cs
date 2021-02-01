using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalkdeskSln.Model
{
    public class BusinessSector
    {
        private string _number;
        private string _sector;

        public string Number { get => _number; set => _number = value; }
        public string Sector { get => _sector; set => _sector = value; }
    }
}
