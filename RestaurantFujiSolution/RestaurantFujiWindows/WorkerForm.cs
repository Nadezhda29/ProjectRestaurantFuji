using System;
using System.Windows.Forms;
using RestaurantFujiLibrary;

namespace RestaurantFujiWindows
{
    public partial class WorkerForm : Form
    {
        WorkerList workerList = new WorkerList();
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshWorkerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerEditForm newForm = new WorkerEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newWorker.InsertNewWorker();
            }

            RefreshWorkerList();
        }

        void RefreshWorkerList()
        {
            workerList = WorkerList.GetDefaultWorkerList();
            workerListBindingSource.DataSource = null;
            workerListBindingSource.DataSource = workerList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int workerID = (int)workerListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (WorkerInfo worker in workerList)
            {
                if (worker.ID == workerID)
                {
                    worker.DeleteWorker();
                }
            }
            RefreshWorkerList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int workerID = (int)workerListDataGridView.SelectedRows[0].Cells[0].Value;

            WorkerEditForm newForm = new WorkerEditForm();

            foreach (WorkerInfo worker in workerList)
            {
                if (worker.ID == workerID)
                {
                    worker.GetWorker(workerID);
                    newForm.newWorker = worker;

                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm.newWorker.UpdateWorker();
                    }
                }
            }

            RefreshWorkerList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
