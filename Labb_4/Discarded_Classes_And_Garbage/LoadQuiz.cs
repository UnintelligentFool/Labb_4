using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Labb_4 {
    public class LoadQuiz {

        public LoadQuiz() {

            ShowQuiz();
            
        }

        private void ShowQuiz()//Load and Show Quiz
        {

            
            
        }

    }
}



/*






using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Serialization;
using System.IO;

namespace WPF_Tutorial_XML_Serialization_and_Deserialization {

    public partial class MainWindow : Window {
    
        private void DeserializeList() {

            EmployeeList employeeList = new EmployeeList();

            XmlSerializer serializer = new XmlSerializer(employeeList.GetType());

            TextReader textReader = new StreamReader("C:\\Users\\Niklas\\Desktop\\.NET - Utvecklare\\FilesSavedFromVisualStudioApplications\\Tutorial_XML_List_With_Employees.xml");

            employeeList = (EmployeeList)serializer.Deserialize(textReader);

            textReader.Close();

        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Serialization;

namespace WPF_Tutorial_XML_Serialization_and_Deserialization {

    [XmlRoot("CompanyEmployees")]

    public class EmployeeList {

        [XmlArray("EmployeeList")]//[XmlArray("EmployeeListing")]
        [XmlArrayItem("Employee", typeof(Employee))]

        public List<Employee> employeeList;

        public EmployeeList() {

            employeeList = new List<Employee>();

        }

        public void AddEmployee(Employee employee) {

            employeeList.Add(employee);

        }

    }
}









*/