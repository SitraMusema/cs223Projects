using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventory.Product
{
    internal class product
    {
        public bool isAvaliable { get; set; }   

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Inventory_Number { get; set; }
        public string Object_Name { get; set; }
        public int count { get; set; }
        public double price { get; set; }

        public void Save()
        {
            Console.WriteLine("query excuted");   
        }

    }
    
    
}
