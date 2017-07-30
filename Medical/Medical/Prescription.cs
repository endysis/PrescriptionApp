using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Prescription
    {
        string medicationName;
        string prescriptionReference;
        string prescriptionStartDate;
        string prescriptionEndDate;
        string patientReference;
        double dosage;


        public Prescription(string mN, string pR, string pS, string pED, string paR, double d) {
            medicationName = mN;
            prescriptionReference = pR;
            prescriptionStartDate = pS;
            prescriptionEndDate = pED;
            patientReference = paR;
            dosage = d;
        }

    }
}
