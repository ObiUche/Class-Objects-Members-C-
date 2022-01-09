using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Objects_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Books newBook = new Books();
            newBook.Author = "Obinna Uche";
            // Two different objects from the same class with different authors 


            Books newBook1 = new Books();
            newBook1.Author = "John Doe";


        }
    }
}
