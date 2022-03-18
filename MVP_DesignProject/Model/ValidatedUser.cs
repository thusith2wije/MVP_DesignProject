using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_DesignProject
{
    public class ValidatedUser
    {
        public string Name { get; set; }
        public string AccType { get; set; }
        public string AccStatus { get; set; }
        public string Currency { get; set; }
        public bool IsValid { get; set; }
    }
}
