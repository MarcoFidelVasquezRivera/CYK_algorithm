using CYK_Algorithm.Model;
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
        private GICManager manager;
        DataTable data;
        int counter;
        public Form1()
        {
            InitializeComponent();
            generateTable();
            manager = new GICManager();
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

        private void checkGrammarButton_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text;
            String[,] matrix = new String[data.Rows.Count, data.Columns.Count];

            for (int column = 0; column < data.Columns.Count; column++)
            {
                for (int row = 0; row < data.Rows.Count; row++)
                {
                    matrix[row, column] = Convert.ToString(data.Rows[row].ItemArray[column]);
                }
            }





            if (matrix != null)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(string.Format("{0} ", matrix[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

            }

            manager.runCYK(matrix, input);
        }
    }
}
