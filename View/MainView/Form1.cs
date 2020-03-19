using Logbook.View.Interface;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Logbook.View
{
    public partial class Form1 : MetroForm,IForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel Panel { 
            get
            {
                return panel;
            }
        }


        public event EventHandler<EventArgs> Adding;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Adding.Invoke(this, e);
        }
    }
}
