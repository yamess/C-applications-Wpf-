using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;

namespace EmployeeSqlite.Models
{
    public class EmployeeModel: BaseModel
    {

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

        private string _Position;

        public string Position
        {
            get { return _Position; }
            set { _Position = value; RaisePropertyChanged("Position"); }
        }

        private string _Manager;

        public string Manager
        {
            get { return _Manager; }
            set { _Manager = value; RaisePropertyChanged("Manager"); }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                RaisePropertyChanged("Age");
            }
        }

        public EmployeeModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                FirstName = "Yameogo";
                LastName = "Abou";
                Manager = "Yameogo";
                Position = "CEO";
            }
        }
    }
}
