using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingproject
{
    class checking : Account
    {
        public int NextCheckNbr { get; set; } = 1;
        public string Print()
        {
            return base.Print() + $",NextCheck Nber= { NextCheckNbr}";
        }
        public int GetNextCheckNumber()
        {
            return NextCheckNbr;
        }
        public checking (string NewDescription) : base(NewDescription)
        {

        }
        public checking() : this(null)
        {

        }
    }
    
    }

