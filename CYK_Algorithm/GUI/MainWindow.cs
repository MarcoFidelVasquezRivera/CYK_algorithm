using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYK_Algorithm
{
    public partial class Form1 : Form
    {
        DataTable data;
        int counter;
        public Form1()
        {
            InitializeComponent();
            generateTable();
            counter = 65;
        }

        public void generateTable() {
            data = new DataTable();
            data.Columns.Add(); //Columna de variables
            data.Columns.Add(); //Columna de transicion
            data.Rows.Add();

            data.Rows[0].ItemArray = new String[] { "S" };
            table.DataSource = data; 
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            if (counter != 91)
            {
                data.Rows.Add();
                if (counter == 83) counter++;
                char letter = (char)counter;
                Console.WriteLine(letter);
                String sLetter = Char.ToString(letter);
                data.Rows[data.Rows.Count - 1].ItemArray = new String[] { sLetter };
                counter++;
            }
            else {
                MessageBox.Show("Cannot add more states", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        
        }

        private void addColumnButton_Click(object sender, EventArgs e)
        {
            data.Columns.Add();
        }
    }
}
