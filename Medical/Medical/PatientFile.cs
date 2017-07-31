using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class PatientFile
    {
        List<Patient> patients;
        int prescriptionCap = 5;

        public PatientFile() {
            //Read from the database
            //But for now
            patients = new List<Patient>();
            Patient J = new Patient("b328","John-Townsend");
            Patient I = new Patient("a12d","Ian-Smith");
            patients.Add(J);
            patients.Add(I);
        }

        public Patient find_Patient(string patientID) {
            Patient p = new Patient("","");
            for (int i = 0; i < patients.Count; i++){
                if (patientID == patients[i].patientId)
                {
                    p = patients[i];
                    return p;
                }
            }
            return p;
        }

        public bool checkPatientPrescriptionCount(string patientID) {
            for (int i = 0; i < patients.Count; i++){
                if (patients[i].patientId == patientID){
                    if (patients[i].patientPrescriptionCount < 5){
                        return true;
                    } else
                        return false;
                }
            }
            return false;
        }

        public void incrementPrescriptionCount(string patientID)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].patientId == patientID)
                {
                    patients[i].patientPrescriptionCount++;
                }
            }
        }

        public bool prescriptionTimeOut(string patientID, string prescriptionID) { // Find the patient / Find the Specific prescription / Remove the prescription - N^2 Complexity - Cest pas tres bon
           /* for(int i = 0; i < patients.Count; i++) {
                if (patients[i].patientId == patientID){
                    for(int j = 0; j < patients[i].patientPrescriptions.Count; j++){
                        if(patients[i].patientPrescriptions[j] == prescriptionID){
                            patients[i].patientPrescriptions.RemoveAt(j);
                            return true;
                        }
                    }
                }
            } */
            return false;
        }

        public List<Patient> patientList {
            get { return patients; }
        }

        public bool addPatient(Patient p) {
            //Then add to the database
            //Read from the database
            patients.Add(p);
            return true;
        }

    }
}
