using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        ThreadingTwo UC = new ThreadingTwo();
        int count = 0;
        bool CancelMessage = false;
        public class CurrentState
        {
            public int LinesCounted;
        }
        public Form2()
        {
            InitializeComponent();
        }
        public void LineUpdate(System.ComponentModel.BackgroundWorker worker, System.ComponentModel.DoWorkEventArgs e)
        {
            int df = 34;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateCount()
        {
        }
        public void StartProgressBarBackgroundWorkerThread()
        {
            
            ProgressBarBackgroundWorker.RunWorkerAsync(UC);
        }
        private void ProgressBarBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;
            ThreadingTwo UC = (ThreadingTwo)e.Argument;
            UC.UpdateCount(worker, e);
            //UC.Lin(worker, e);
        }
        private void ProgressBarBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ThreadingTwo.CurrentState state = (ThreadingTwo.CurrentState)e.UserState;
            label1.Text = "Lines: " + state.LinesCounted.ToString();
        }

        private void ProgressBarBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        public void StopProcess()
        {
            UC.flag = true;
        }
        public void SetCount(int counter)
        {
            UC.count = counter;
        }
        public bool SendStopMessage()
        {
            return true;
        }
        public bool SendCancelMessage()
        {
            return CancelMessage;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelMessage = true;
            this.Hide();
        }
    }
    class ThreadingTwo
    {
        public bool flag = false;
        public int count = 0;
        CurrentState state = new CurrentState();
        public class CurrentState
        {
            public int LinesCounted;
        }
        public ThreadingTwo()
        {
            int sdf = 34;
        }
        public void UpdateCount(System.ComponentModel.BackgroundWorker worker, System.ComponentModel.DoWorkEventArgs e)
        {
            int temp = 0;
            //while (temp != 9999999999999)
            //{
                temp+= 1;
           // while (flag == false)
           // {
                state.LinesCounted = count;
                worker.ReportProgress(0, state);
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    worker.Dispose();
                    worker = null;
                    GC.Collect();
                    MessageBox.Show("Canceled");
                   // break;
                }
           // }
        }
    }
}
