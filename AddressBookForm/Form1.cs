using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llenando el obj
            Contact c = new Contact();
            c.Name = "tro";
            c.LastName = "abc";
            c.Comment = "comment";
            c.Address = "Address";
            c.Phones.Add(new Phone()
            {
                Type = "mobil", Number = "8097936917"
            });

            //conexion a Db y guardar datos.
            using (dbContainer context = new dbContainer())
            {
                context.Contacts.Add(c);
                context.SaveChanges();
            }
        }
    }
}
