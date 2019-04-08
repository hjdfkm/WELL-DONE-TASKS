using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("EmployeeList.xml");
            XmlElement root = doc.DocumentElement;
            XmlElement employee = doc.CreateElement("Employee");
            XmlAttribute id = doc.CreateAttribute("ID");
            XmlElement name = doc.CreateElement("Name");
            XmlElement post = doc.CreateElement("Post");
            XmlElement salary = doc.CreateElement("Salary");
            XmlText idText = doc.CreateTextNode(textBox4.Text);
            XmlText nameText = doc.CreateTextNode(textBox1.Text);
            XmlText postText = doc.CreateTextNode(textBox2.Text);
            XmlText salaryText = doc.CreateTextNode(textBox3.Text);

            
            id.AppendChild(idText);
            name.AppendChild(nameText);
            post.AppendChild(postText);
            salary.AppendChild(salaryText);
            employee.Attributes.Append(id);
            employee.AppendChild(name);
            employee.AppendChild(post);
            employee.AppendChild(salary);
            root.AppendChild(employee);
            doc.Save("EmployeeList.xml");
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Empty;
            List<dynamic> employees = new List<dynamic>();
            XDocument xdoc = XDocument.Load("EmployeeList.xml");
            foreach (XElement element in xdoc.Element("EmployeeList").Elements("Employee"))
            {
                XElement postElement = element.Element("Post");
                XElement salaryElement = element.Element("Salary");

                if (postElement.Value == textBox2.Text && salaryElement.Value == textBox3.Text)
                {
                    employees.Add(element);
                }
            }
            for (int i = 0; i < employees.Count; i++)
            {
                textBox5.Text += employees[i].ToString() + "\r\n";
            }
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }
    }
}
