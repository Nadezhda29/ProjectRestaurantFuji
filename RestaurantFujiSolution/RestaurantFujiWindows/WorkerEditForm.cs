using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class WorkerEditForm : Form
    {
        public WorkerInfo newWorker = new WorkerInfo();
        public WorkerEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkerEditForm_Load(object sender, EventArgs e)
        {
            workerInfoBindingSource.DataSource = newWorker;
        }
    }
}
