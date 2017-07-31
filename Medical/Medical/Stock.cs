using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Stock
    {
        List<Medicine> stock;

        public Stock() {
            // Syncronise with db;
            stock = new List<Medicine>();

            Medicine paracetamol = new Medicine("Paracetamol","1111");
            Medicine Ibuprofen = new Medicine("Ibuprofen", "2222");

            stock.Add(paracetamol);
            stock.Add(Ibuprofen);
        }

        public bool addStock(string title, string reference) {
            Medicine newStock = new Medicine(title, reference);
            stock.Add(newStock);
            return true;
        }

        public bool inStock(string medicineTitle) {
            for(int i = 0; i < stock.Count; i++) {
                if (medicineTitle == stock[i].medicineTitle) { return true; }
            }
            return false;
        }

        public Medicine removeStockForPatient(string medicineTitle) {
            Medicine medicine = new Medicine("","");
            for(int i = 0; i < stock.Count; i++) {
                if(medicineTitle == stock[i].medicineTitle) {
                    medicine = stock[i];
                    stock.RemoveAt(i);
                    break;
                }
            }
            return medicine;
        }


        public bool removeStock(string title, int quantity){
            int amount = quantity;
            for(int i = 0; i < stock.Count; i++) {
                if (amount <= 0) {break;}
                if (title == stock[i].medicineTitle) {
                    stock.RemoveAt(i);
                }
            }
            return true;
        }

    


    }
}
