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
        PatientFile p;
        // Later to be converted into classes for sync with database.
        // But for now
        List<Prescription> history;
        List<Medicine> stock;


        public MainWindow()
        {
            InitializeComponent();
            p = new PatientFile();  // Sync with the database
        }
         
        private void Scan_Click(object sender, RoutedEventArgs e){

            bool result = p.prescribe(iDInput.Text, prescrInput.Text);
            switch (result) {
                case false:
                    MessageBox.Show("Patient has reached the prescription limit");
                    break;
                case true:
                    break;
            }
            printIDList(iDInput.Text);
        }

        private void DisplayOutput(){

        }

        private void iDInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            p.prescriptionTimeOut(iDInput.Text,prescrInput.Text);
            printIDList(iDInput.Text);
        }

        private void printIDList(string iD) {
            string outputString = "";
            Patient patientOutput;
            patientOutput = p.find_Patient(iDInput.Text.ToString());
            foreach (string s in patientOutput.patientPrescriptions)
            {
                outputString = outputString + s + "/";
            }
            PatientText.Content = patientOutput.patientName + outputString;
        }
    }
}
