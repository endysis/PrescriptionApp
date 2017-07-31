using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Medical
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static PatientFile patientStorage;
        static Stock medicineStock;
        static PrescriptionHistory prescriptionHistory;

        Patient patientOutput;
        Medicine medicineOuput;


        public MainWindow()
        {
            InitializeComponent();
            patientStorage = new PatientFile();  // Sync with the database
            medicineStock = new Stock();
            prescriptionHistory = new PrescriptionHistory();
        }

        private void Scan_Click(object sender, RoutedEventArgs e) // Scaning in the name and bringing up patient details
        {
           patientOutput = patientStorage.find_Patient(iDInput.Text);
           PatientText.Content = patientOutput.patientName;
        }

        private void Prescribe_Click(object sender, RoutedEventArgs e)
        {
            bool medicineResult = medicineStock.inStock(prescrInput.Text); // Checks If the required medicine is in stock
            bool patientResult = patientStorage.checkPatientPrescriptionCount(patientOutput.patientName); // Checks the amount of prescriptions the patient has.
            if (medicineResult == true){
                if (patientResult == true)
                {
                    medicineOuput = medicineStock.removeStockForPatient(prescrInput.Text);
                    prescriptionHistory.makePrescription(medicineOuput.medicineTitle, medicineOuput.medicineReference, StartDate.Text, EndDate.Text, patientOutput.patientId, double.Parse(Dosage.Text));
                    patientStorage.incrementPrescriptionCount(iDInput.Text);
                } else {
                    MessageBox.Show("Cannot prescribe, the patient has reached the maximum prescription limit.");
                }
            } else {
                MessageBox.Show("The requested medicine is not in stock");
            }
        }

        private void DisplayOutput(){

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            patientStorage.prescriptionTimeOut(iDInput.Text,prescrInput.Text);
            printIDList(iDInput.Text);
        }

        private void printIDList(string iD) {
        
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
