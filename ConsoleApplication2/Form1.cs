using _2prd_injinierija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms;
using Library.Forms;

namespace ConsoleApplication2
{
    public partial class Form1 : Form
    {
        private   List<object> liste;
        
        public Form1(List<object> qs)
        {
            this.liste = qs;
            var liste = new SortableBindingList<object>(this.liste);           
            InitializeComponent();
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            BindingSource bs = new BindingSource();
           
            bs.DataSource = liste;
            bs.AddingNew +=
                new AddingNewEventHandler(bindingSource_AddingNew);
           
            bs.AllowNew = true;
            dataGridView1.DataSource = bs;

        }

        private void bindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Datorklase();
            liste.Add(e.NewObject);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public List<object> sarakstsWin() {
            return liste;
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            sarakstsWin();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
