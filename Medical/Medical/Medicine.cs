using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Medicine
    {
        string title;
        string reference;

        public Medicine(string t, string r) {
            title = t;
            reference = r;
        }

        public string medicineTitle {
            get { return title; }
        }

        public string medicineReference
        {
            get { return title; }
        }
    }
}
