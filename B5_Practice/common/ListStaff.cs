using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_Practice.common
{
    internal class ListStaff
    {
        private int amount = 0;
        private List<Staff> listStaff = new List<Staff>();

        #region("Properties get, set")
        public int Amount
        {
            get => this.amount;
            set { this.amount = value; }
        }
        public List<Staff> _ListStaff
        {
            get => this.listStaff;
            set { this.listStaff = value; }
        }
        #endregion

        public void InputData()
        {
            //Enter number of staff
            while (true)
            {
                Console.WriteLine("Enter number of staff: ");
                this.amount = Convert.ToInt32(Console.ReadLine());
                if (this.amount > 0)
                    break;
                Console.WriteLine("Amount must bigger than 0!");
            }

            //Enter information of staffs
            for (int i = 0; i < this.amount; i++)
            {
                Staff nv = new Staff();
                Console.WriteLine("\nEnter information of staff #" + (i + 1));
                nv.InputData();
                this.listStaff.Add(nv);
            }
        }

        public void OutputData()
        {
            for (int i = 0; i < this.amount; i++)
            {
                Console.WriteLine("\nInformation of staff #" + (i + 1));
                this.listStaff[i].OutputData();
            }
        }
    }
}
