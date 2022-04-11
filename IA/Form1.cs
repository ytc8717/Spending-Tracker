using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using GenericMethodForTableFilter;
using System.Xml.Linq;

namespace IA
{
    public partial class Form1 : Form
    {

        // create three dataTables
        DataTable dt = new DataTable();
        DataTable dtE = new DataTable();
        DataTable dtI = new DataTable();
        // create three dataSets
        DataSet ds = new DataSet();
        DataSet dsE = new DataSet();
        DataSet dsI = new DataSet();
        // create variable
        decimal balance;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // add columns in each dataTable
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("List", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));

            dtE.Columns.Add("Amount", typeof(decimal));

            dtI.Columns.Add("Amount", typeof(decimal));

            // bond dataTables with dataSets
            ds.Tables.Add(dt);

            dsE.Tables.Add(dtE);

            dsI.Tables.Add(dtI);

            // load xml files
            if (File.Exists(Application.StartupPath + "\\data.xml"))
            {
                ds.ReadXml(Application.StartupPath + "\\data.xml");
            }

            if (File.Exists(Application.StartupPath + "\\Expense.xml"))
            {
                dsE.ReadXml(Application.StartupPath + "\\Expense.xml");
            }

            if (File.Exists(Application.StartupPath + "\\Income.xml"))
            {
                dsI.ReadXml(Application.StartupPath + "\\Income.xml");
            }

            // Declare a variable of type  XmlTextReader
            XmlTextReader xtr1 = null;
            // Declare a string that holds the name of the file
            string fileName1 = "ComboE.xml";

            try
            {
                // Initialize the XmlTextReader variable with the name of the file
                xtr1 = new XmlTextReader(fileName1);
                xtr1.WhitespaceHandling = WhitespaceHandling.None;

                if (!File.Exists(Application.StartupPath + fileName1))
                {
                    new XDocument(
                        new XElement("Expense",
                            new XElement("Expense", "")
                        )
                    )
                    .Save("ComboE.xml");
                }

                // Scan the XML file
                while (xtr1.Read())
                {
                    // every time you find an element, find out what type it is
                    switch (xtr1.NodeType)
                    {
                        case XmlNodeType.Text:
                            // If you find text, put it in the combo box' list
                            this.comboBoxExpense.Items.Add(xtr1.Value);
                            break;
                    }
                }

                // For this example, select the first item
                //this.comboBoxExpense.SelectedIndex = 0;
            }
            finally
            {
                // Close the XmlTextReader
                if (xtr1 != null)
                    xtr1.Close();
            }

            // Declare a variable of type  XmlTextReader
            XmlTextReader xtr = null;
            // Declare a string that holds the name of the file
            string fileName = "ComboIC.xml";

            try
            {
                // Initialize the XmlTextReader variable with the name of the file
                xtr = new XmlTextReader(fileName);
                xtr.WhitespaceHandling = WhitespaceHandling.None;

                if (!File.Exists(Application.StartupPath + fileName))
                {
                    new XDocument(
                        new XElement("Income",
                            new XElement("Income", "")
                        )
                    )
                    .Save("ComboIC.xml");
                }

                // Scan the XML file
                while (xtr.Read())
                {
                    // every time you find an element, find out what type it is
                    switch (xtr.NodeType)
                    {
                        case XmlNodeType.Text:
                            // If you find text, put it in the combo box' list
                            this.comboBoxIncome.Items.Add(xtr.Value);
                            break;
                    }
                }

                // For this example, select the first item
                //this.comboBoxIncome.SelectedIndex = 0;
            }
            finally
            {
                // Close the XmlTextReader
                if (xtr != null)
                    xtr.Close();
            }

            // Calculate the sum of expense/income in each Tables(dtE & dtI) then display back out to the UI
            if (dt.Rows.Count > 0)
            {
                decimal sumExpense = (decimal)dtE.Compute("Sum(Amount)", "True");
                textBoxTExpense.Text = sumExpense.ToString("C");
                decimal sumIncome = (decimal)dtI.Compute("Sum(Amount)", "True");
                textBoxTIncome.Text = sumIncome.ToString("C");

                balance = sumIncome - sumExpense;
                textBoxBalance.Text = balance.ToString("C");
            }
            else
            {
                textBoxTExpense.Text = "$0.00";
                textBoxTIncome.Text = "$0.00";
                textBoxBalance.Text = "$0.00";
            }

            // bond datagridview1 with dataTable dt
            dataGridView1.DataSource = dt;
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (radioButtonIncome.Checked)
            {
                if (comboBoxIncome.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select or add the transaction.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dt.Rows.Add(dateTimePicker1.Text, comboBoxIncome.SelectedItem, numericUpDownIncome.Value);
                    dataGridView1.DataSource = dt;
                    dtI.Rows.Add(numericUpDownIncome.Value);
                    dtE.Rows.Add(0);
                }
            }

            if (radioButtonExpense.Checked)
            {
                if (comboBoxExpense.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select or add the transaction.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dt.Rows.Add(dateTimePicker1.Text, comboBoxExpense.SelectedItem, numericUpDownExpense.Value);
                    dataGridView1.DataSource = dt;
                    dtE.Rows.Add(numericUpDownExpense.Value);
                    dtI.Rows.Add(0);
                }
            }

            // write xml files
            ds.WriteXml(Application.StartupPath + "\\data.xml");
            dsE.WriteXml(Application.StartupPath + "\\Expense.xml");
            dsI.WriteXml(Application.StartupPath + "\\Income.xml");

            if (dt.Rows.Count > 0)
            {
                decimal sumExpense = (decimal)dtE.Compute("Sum(Amount)", "True");
                textBoxTExpense.Text = sumExpense.ToString("C");
                decimal sumIncome = (decimal)dtI.Compute("Sum(Amount)", "True");
                textBoxTIncome.Text = sumIncome.ToString("C");

                balance = sumIncome - sumExpense;
                textBoxBalance.Text = balance.ToString("C");
            }
            else
            {
                textBoxTExpense.Text = "$0.00";
                textBoxTIncome.Text = "$0.00";
                textBoxBalance.Text = "$0.00";
            }
        }

        private void radioButtonIncome_CheckedChanged(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (radioButtonIncome.Checked)
            {
                numericUpDownIncome.Enabled = true; labelIncome.Enabled = true; comboBoxIncome.Enabled = true; dateTimePicker1.Enabled = true;

            }
            else
            {
                comboBoxIncome.Enabled = false;
                labelIncome.Enabled = false;
                numericUpDownIncome.Enabled = false;
                dateTimePicker1.Enabled = false;


                numericUpDownIncome.Value = 0;
            }
        }

        private void radioButtonExpense_CheckedChanged(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (radioButtonExpense.Checked)
            {
                labelExpense.Enabled = true;
                comboBoxExpense.Enabled = true;
                numericUpDownExpense.Enabled = true;
                dateTimePicker1.Enabled = true;

            }
            else
            {
                labelExpense.Enabled = false;
                comboBoxExpense.Enabled = false;
                numericUpDownExpense.Enabled = false;
                dateTimePicker1.Enabled = false;


                numericUpDownExpense.Value = 0;
            }
        }

        private void buttonDeleteTransaction_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (dt.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                dtE.Rows.RemoveAt(rowIndex);
                dtI.Rows.RemoveAt(rowIndex);
            }

            // write xml files
            ds.WriteXml(Application.StartupPath + "\\data.xml");
            dsE.WriteXml(Application.StartupPath + "\\Expense.xml");
            dsI.WriteXml(Application.StartupPath + "\\Income.xml");

            if (dt.Rows.Count > 0)
            {
                decimal sumExpense = (decimal)dtE.Compute("Sum(Amount)", "True");
                textBoxTExpense.Text = sumExpense.ToString("C");
                decimal sumIncome = (decimal)dtI.Compute("Sum(Amount)", "True");
                textBoxTIncome.Text = sumIncome.ToString("C");

                balance = sumIncome - sumExpense;
                textBoxBalance.Text = balance.ToString("C");
            }
            else
            {
                textBoxTExpense.Text = "$0.00";
                textBoxTIncome.Text = "$0.00";
                textBoxBalance.Text = "$0.00";
            }
        }

        private void newExpenseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            int indexInteger = 0;
            bool itemFoundBoolean = false;

            if (comboBoxExpense.Text != string.Empty)
            {
                while (indexInteger < comboBoxExpense.Items.Count &&
                !itemFoundBoolean)
                {
                    if (comboBoxExpense.Items[indexInteger++].ToString().ToUpper()
                    == comboBoxExpense.Text.ToUpper())
                    {
                        MessageBox.Show("Duplicate Expense Type.", "Expense Type Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemFoundBoolean = true;
                    }
                }
                if (!itemFoundBoolean)
                {

                    comboBoxExpense.Items.Add(comboBoxExpense.Text);
                    comboBoxExpense.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Enter the New Expense Type.",
                "No Expense Type Entered", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void newIncomeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            int indexInteger = 0;
            bool itemFoundBoolean = false;

            if (comboBoxIncome.Text != string.Empty)
            {
                while (indexInteger < comboBoxIncome.Items.Count &&
                !itemFoundBoolean)
                {
                    if (comboBoxIncome.Items[indexInteger++].ToString().ToUpper()
                    == comboBoxIncome.Text.ToUpper())
                    {
                        MessageBox.Show("Duplicate Income Type.", "Income Type Not Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        itemFoundBoolean = true;
                    }
                }
                if (!itemFoundBoolean)
                {

                    comboBoxIncome.Items.Add(comboBoxIncome.Text);
                    comboBoxIncome.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Enter the New Income Type.",
                "No Income Type Entered", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void removeExpenseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (comboBoxExpense.SelectedIndex != -1)
            {
                comboBoxExpense.Items.RemoveAt(comboBoxExpense.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a Expense type to remove.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeIncomeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // else if statements to determine the actions
            if (comboBoxIncome.SelectedIndex != -1)
            {
                comboBoxIncome.Items.RemoveAt(comboBoxIncome.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a Income type to remove.", "No Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            // save the comboboxes items and write to xml files
            XmlTextWriter xtw1 = null;
            string fileName1 = "ComboE.xml";

            try
            {
                xtw1 = new XmlTextWriter(fileName1, Encoding.UTF8);
                xtw1.Formatting = Formatting.Indented;

                xtw1.WriteStartDocument();
                xtw1.WriteStartElement("Expense");

                for (int i = 0; i < this.comboBoxExpense.Items.Count; i++)
                {
                    xtw1.WriteElementString("Expense",
                         (string)this.comboBoxExpense.Items[i]);
                }

                xtw1.WriteEndElement();
                xtw1.WriteEndDocument();
            }
            finally
            {
                if (xtw1 != null)
                    xtw1.Close();
            }

            XmlTextWriter xtw = null;
            string fileName = "ComboIC.xml";

            try
            {
                xtw = new XmlTextWriter(fileName, Encoding.UTF8);
                xtw.Formatting = Formatting.Indented;

                xtw.WriteStartDocument();
                xtw.WriteStartElement("Income");

                for (int i = 0; i < this.comboBoxIncome.Items.Count; i++)
                {
                    xtw.WriteElementString("Income",
                         (string)this.comboBoxIncome.Items[i]);
                }

                xtw.WriteEndElement();
                xtw.WriteEndDocument();
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // filter the results based on textboxSearch value
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt.exFilter(textBoxSearch.Text);
        }
    }
}
