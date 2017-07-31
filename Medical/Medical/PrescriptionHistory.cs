using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class PrescriptionHistory
    {
        List<Prescription> history;

        public PrescriptionHistory() {
            // Sync with database
            history = new List<Prescription>();
        }
        
        public void makePrescription(string medicationName, string prescriptionReference, string prescriptionStartDate, string prescriptionEndDate, string patientReference, double dosage){
            Prescription newPrescription = new Prescription(medicationName,patientReference,prescriptionStartDate,prescriptionEndDate,patientReference,dosage);
            history.Add(newPrescription);
        }
        

    }
}
