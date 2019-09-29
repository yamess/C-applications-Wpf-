using System;
using System.ComponentModel;
using System.Windows;
using SQLite;

namespace EmployeeSqlite.Models
{
    public class EmployeeModel: BaseModel
    {

        private int _ID;
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; RaisePropertyChanged("ID"); }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        private string _Lastname;
        public string LastName
        {
            get { return _Lastname; }
            set { _Lastname = value; RaisePropertyChanged("LastName"); }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; RaisePropertyChanged("Phone"); }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; RaisePropertyChanged("Address"); }
        }

        private double _Salary;
        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; RaisePropertyChanged("Salary"); }
        }

        private DateTime _HiringDate;
        public DateTime HiringDate
        {
            get { return _HiringDate; }
            set { _HiringDate = value; RaisePropertyChanged("HiringDate"); }
        }

        private string _EmailAddress;
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; RaisePropertyChanged("EmailAddress"); }
        }

        private string _Manager;
        public string Manager
        {
            get { return _Manager; }
            set { _Manager = value; RaisePropertyChanged("Manager"); }
        }

        private string _Position;
        public string Position
        {
            get { return _Position; }
            set { _Position = value; RaisePropertyChanged("Position"); }
        }

        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
                RaisePropertyChanged("DateOfBirth");
            }
        }

        //Initializing the class
        public EmployeeModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                FirstName = "Yameogo";
                LastName = "Abou";
                Phone = "5144449676";
                DateOfBirth = DateTime.Today;
                HiringDate = DateTime.Today;
                Address = "6000 Boulervard Lacordaire, Montréal, Canada";
                EmailAddress = "test@testcompany.com";
                Salary = 120000;
                Manager = "Yameogo";
                Position = "CEO";
            }
            DateOfBirth = DateTime.Today;
            HiringDate = DateTime.Today;

        }
        public void SaveToDabase()
        {

        }
    }
}
