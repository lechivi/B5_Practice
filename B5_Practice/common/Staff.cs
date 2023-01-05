using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_Practice.common
{
    internal class Staff
    {
        private string iD;
        private string name;
        private bool male;
        private DateTime dateOfBirth;
        private string phoneNumber;

        #region("Method get, set")
        public void SetID(string iD)
        {
            this.iD = iD;
        }

        public string GetID()
        {
            return this.iD;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetMale(bool male)
        {
            this.male = male;
        }

        public bool GetMale()
        {
            return this.male;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public DateTime GetDateOfBirth()
        {
            return this.dateOfBirth;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        #endregion

        #region("Properties get, set")
        public string ID
        {
            get => this.iD;
            set { this.iD = value; }
        }

        public string Name
        {
            get => this.name;
            set { this.name = value; }
        }

        public bool Male
        {
            get => this.male;
            set { this.male = value; }
        }

        public DateTime DateOfBirth
        {
            get => this.dateOfBirth;
            set { this.dateOfBirth = value; }
        }

        public string PhoneNumber
        {
            get => this.phoneNumber;
            set { this.phoneNumber = value; }
        }
        #endregion

        public Staff()
        {
            this.iD = "noID";
            this.name = "noName";
            this.male = true;
            this.dateOfBirth = new DateTime(1, 1, 1);
            this.phoneNumber = "0000000000";
        }

        public Staff(string iD, string name, bool male, DateTime dateOfBirth, string phoneNumber)
        {
            this.iD = iD;
            this.name = name;
            this.male = male;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }

        public void InputData()
        {
            Console.Write("- ID: ");
            this.iD = Console.ReadLine();

            Console.Write("- Name: ");
            this.name = Console.ReadLine();

            while (true)
            {
                Console.Write("- Male (Y/N): ");
                string _male = Console.ReadLine();
                if (_male == "Y" || _male == "y")
                {
                    this.male = true;
                    break;
                }
                if (_male == "N" || _male == "n")
                {
                    this.male = false;
                    break;
                }
                Console.WriteLine("Wrong answer!");
            }

            while (true)
            {
                Console.Write("- Date of birth (mm/dd/yyyy): ");
                string date = Console.ReadLine();
                if (Common.IsDate(date))
                {
                    this.dateOfBirth = DateTime.Parse(date);
                    break;
                }
                Console.WriteLine("Wrong answer!");
            }
            
            Console.Write("- Enter phone number: ");
            this.phoneNumber = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine("- ID: " + this.iD);
            Console.WriteLine("- Name: " + this.name);

            string gender;
            if (male)
                gender = "Male";
            else
                gender = "Female";
            Console.WriteLine("- Gender: " + gender);

            Console.WriteLine("- Date of birth: " + this.dateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("- Phone Number: " + this.phoneNumber);
        }

        public override string ToString()
        {
            string gender;
            if (male)
                gender = "Male";
            else
                gender = "Female";

            string s = "ID: " + this.iD + "\nName: " + this.name + "\nGender: " + gender + "\nDate of birth: "
                + this.dateOfBirth.ToString("dd/MM/yyyy") + "\nPhone Number: " + this.phoneNumber + '\n';

            return s;
        }
    }
}
