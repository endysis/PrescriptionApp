using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Patient
    {
        string iDCode;
        string name;
        int prescriptionCount;

       public Patient(string iD, string n) {
            iDCode = iD;
            name = n;
            prescriptionCount = 0;
        }

        public string patientId {
            get { return iDCode; }
        }

        public string patientName {
            get { return name; }
        }

        public int patientPrescriptionCount {
            get { return prescriptionCount; }
            set { prescriptionCount = patientPrescriptionCount; }
        }
    }
}
