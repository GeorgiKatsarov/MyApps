using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noter
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            OldNotes.DataSource = notes;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[OldNotes.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                notes.Rows[OldNotes.CurrentCell.RowIndex]["Note"] = NoteTextBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleTextBox.Text, NoteTextBox.Text);

            }
            editing = false;
            TitleTextBox.Text = "";
            NoteTextBox.Text = "";
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = notes.Rows[OldNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteTextBox.Text = notes.Rows[OldNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[OldNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception)
            {
                Console.WriteLine("Something failed");
            }
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            NoteTextBox.Text = "";
        }
    }
}
