using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting; 
// 0:20:00
// 2:00:00
// 2:00:00
// 2:00:00
// 5:00:00
// 3:00:00
// 1:50:00
// 2:53:58
namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        bool CanceledFlag = false;
        int Check;
        const int columns = 11;
        const int IDcolumn = 1;
        int WorkingCounter = 0;
        private List<string> DataStorage = new List<string>();
        private List<string> SearchDataStorage = new List<string>();
        List<string> SearchList = new List<string>();
        string file = "";
        int counter = 0;
        public Form1()
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.dataGridView1.CellValueNeeded += new DataGridViewCellValueEventHandler(dataGridView1_CellValueNeeded);
            toolTip1.SetToolTip(Chopping, "Condense an open CAN log text file so it may be searched.");
            toolTip1.SetToolTip(button2, "Open a previously saved condensed file for searching.");
            toolTip1.SetToolTip(ImportButton, "Search for specific CAN message. A list of every instance of message in the log file will be created.");
            toolTip1.SetToolTip(WriteFilebutton, "Save list of messages to .hst file for replay in CAN King.");
            
            // this.SearchDataGridView.CellValueNeeded += new DataGridViewCellValueEventHandler(SearchDataGridView_CellValueNeeded);

        }
        public Form1(string filename)
        {
            file = filename;
            InitializeComponent();
        }
        private void Chopping_Click(object sender, EventArgs e)
        {
            Check = 0;
            MessageBox.Show("Open File");
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                MessageBox.Show("Save File");
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox2.Text = saveFileDialog1.FileName;
                    


                    label1.Text = saveFileDialog1.FileName;
                    saveFileDialog1.DefaultExt = ".chp";
                    StartThread();
                }
            }
                
            
        }
        private void ImportButton_Click(object sender, EventArgs e)
        {
            Check = 1;
                        StartThread();

                
        }
        private void WriteFilebutton_Click(object sender, EventArgs e)
        {
            Check = 2;
            if (saveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StartThread();
            }
        }
        public void CountLines(
        System.ComponentModel.BackgroundWorker worker,
        System.ComponentModel.DoWorkEventArgs e)
        {
            int sf = -1;
            while (sf == -1)
            {
                //toolStripStatusLabel2.Text = counter.ToString();
                int dfv = 34;
            }
            int df = 34;
        }
        public void StartThread()
        {
            counter = 0;
            Threading UC = new Threading();
            backgroundWorker1.RunWorkerAsync(UC);
             form2.Show();
             form2.StartProgressBarBackgroundWorkerThread();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            if (Check == 0)
            {
                System.ComponentModel.BackgroundWorker worker;
                worker = (System.ComponentModel.BackgroundWorker)sender;
                Threading UC = (Threading)e.Argument;
                UC.ChopeFile(textBox1.Text, saveFileDialog1.FileName, worker, e);
                
            }
            else if (Check == 1)
            {
                System.ComponentModel.BackgroundWorker worker;
                worker = (System.ComponentModel.BackgroundWorker)sender;
                Threading UC = (Threading)e.Argument;
                UC.SearchFile(label1.Text, SearchList, worker, e);
            }
            else
            {
                System.ComponentModel.BackgroundWorker worker;
                worker = (System.ComponentModel.BackgroundWorker)sender;
                Threading UC = (Threading)e.Argument;
                UC.SaveFile(saveFileDialog2.FileName, DataStorage, worker, e);
            }
            
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {       
            Threading.CurrentState state = (Threading.CurrentState)e.UserState;
           form2.SetCount(state.LinesCounted);
           int df = 34;
            if(form2.SendCancelMessage() == true)
            {
                CancelIt();
            }
           // toolStripStatusLabel2.Text = "Lines: " + state.LinesCounted.ToString();
            DataStorage = state.DataStorage;
            dataGridView1.RowCount = state.DataStorage.Count / columns;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void dataGridView1_CellValueNeeded(object sender, System.Windows.Forms.DataGridViewCellValueEventArgs e)
        {

            int temp = (e.RowIndex * columns) + e.ColumnIndex;
            e.Value = DataStorage[temp];

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
        private void CancelIt()
        {
            backgroundWorker1.CancelAsync();
            form2 = new Form2();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = openFileDialog2.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

          //  toolTip1.SetToolTip(button3, "Tool Tip MESSAGE");

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {

        }

        private void Chopping_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void ImportButton_MouseHover(object sender, EventArgs e)
        {

        }

        private void WriteFilebutton_MouseHover(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
            SearchList.Add(textBox3.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //form2.StopProcess();
        }

    }
    class Threading
    {
        const int columns = 11;
        string[] TempRow = new string[13];
        List<string> TempDataStorage = new List<string>();
        public class CurrentState
        {
            public int LinesCounted;
            public List<string> DataStorage = new List<string>();
        }
        public Threading()
        {
            int sdf = 34;
        }
        //public void 
        public void ChopeFile(string OPFile, string SVFile, System.ComponentModel.BackgroundWorker worker,
        System.ComponentModel.DoWorkEventArgs e)
        {
            CurrentState state = new CurrentState();
            bool flag = false;
           // Check = false;
            List<String> TempList = new List<string>();
            int FileCounter = 0;
            int tempint = 0;
            int counter = 0;
            string ReadLine;
            int SizeCheck = 0;
            int HexCounter = 0;
            string TextSent = "";
            string tempTxt = "";
            //SVFile.DefaultExt = ".txt";
            //e.Value = DataStorageY[e.ColumnIndex][e.RowIndex];

                    System.IO.StreamReader sz = new System.IO.StreamReader(OPFile);
                    using (FileStream fs = File.Open(OPFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (BufferedStream bs = new BufferedStream(fs))
                    using (StreamReader sr2 = new StreamReader(bs))
                    {
                        
                        for (int read = 0; read <= 23; read++)
                        {
                            ReadLine = sr2.ReadLine();
                        }
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(SVFile, false))
                        {
                            while ((ReadLine = sr2.ReadLine()) != null)
                            {
                                if ((worker.CancellationPending == true))
                                {
                                    e.Cancel = true;
                                    worker.Dispose();
                                    worker = null;
                                    GC.Collect();
                                    MessageBox.Show("Canceled");
                                    break;
                                }
                                bool RFlag = false;
                                int TempCounter = 0;
                                string TempString = "";
                                for (int x = 0; x <= ReadLine.Length - 1; x++)
                                {
                                    if (ReadLine[x] == 'R')
                                    {
                                        ReadLine = ReadLine.Replace('R',' ');
                                        int df = 34;
                                        RFlag = true;
                                    }
                                    int dffs = 34;
                                }
                                if (RFlag == false)
                                {
                                    for (int x = 0; x <= ReadLine.Length - 1; x++)
                                    {
                                        char df = ReadLine[x];
                                        if (ReadLine[x] != ' ')
                                        {
                                            while (ReadLine[x] != ' ')
                                            {
                                                TempString += ReadLine[x];
                                                if (x != ReadLine.Length - 1)
                                                {
                                                    x++;
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                            if (TempString == "416")
                                            {
                                                flag = true;
                                                break;
                                            }
                                            else
                                            {
                                                flag = false;
                                            }
                                            if (TempCounter == 2 && TempString != "X")
                                            {
                                                TempRow[TempCounter] = "";
                                                TempCounter++;
                                                TempRow[TempCounter] = TempString;
                                            }
                                            else
                                            {
                                                TempRow[TempCounter] = TempString;
                                            }
                                            if (TempCounter == 3)
                                            {
                                                tempint = Convert.ToInt16(TempString);
                                                SizeCheck = 8 - Convert.ToInt16(TempString);
                                            }
                                            if (SizeCheck != 0)
                                            {
                                                if (4 + tempint == TempCounter)
                                                {
                                                    for (int Rows = 0; Rows < SizeCheck; Rows++)
                                                    {
                                                        TempRow[TempCounter] = "";
                                                        TempCounter++;
                                                    }
                                                }
                                            }
                                            TempCounter++;
                                            TempString = "";
                                        }
                                    }
                                }
                                if (TempRow[12] == "183")
                                {
                                    int dsd = 34;
                                }
                                if (flag == false)
                                {
                                    TextSent = TempRow[1] + "," + TempRow[3] + "," + TempRow[4] + "," + TempRow[5] + "," + TempRow[6] + "," + TempRow[7] + "," + TempRow[8] + "," + TempRow[9] + "," + TempRow[10] + "," + TempRow[11];
                                    file.WriteLine(TextSent);
                                    //label1.Name = "Lines Saved: " + TempRow[12];
                                    for (int x = 0; x <= 12; x++)
                                    {
                                        TempRow[x] = "";
                                    }
                                }
                                counter++;
                                if (counter % 100 == 0)
                                {
                                    state.LinesCounted = counter;
                                    worker.ReportProgress(0, state);
                                }
                            }
                            
                        }
                        
            }
                    if (worker != null)
                    {
                        MessageBox.Show("Finished condensing the file.");
                    }
        }
        public void SearchFile(string FileName, List<string> Search, System.ComponentModel.BackgroundWorker worker,
        System.ComponentModel.DoWorkEventArgs e)
        {

            CurrentState state = new CurrentState();
            int counter = 0;
            List<String> TempList = new List<string>();
            int tempint = 0;
            string ReadLine;
            int SizeCheck = 0;
            int HexCounter = 0;
           
            using (FileStream fs = File.Open(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {


                while ((ReadLine = sr.ReadLine()) != null)
                {

                    if ((worker.CancellationPending == true))
                    {
                        e.Cancel = true;
                        worker.Dispose();
                        worker = null;
                        GC.Collect();
                        MessageBox.Show("Canceled");
                        break;
                    }
                    

                    bool RFlag = false;
                    int TempCounter = 0;
                    string TempString = "";

                    for (int x = 0; x <= ReadLine.Length - 1; x++)
                    {
                        char df = ReadLine[x];
                        if (ReadLine[x] != ',')
                        {
                            while (ReadLine[x] != ',')
                            {
                                TempString += ReadLine[x];
                                if (x != ReadLine.Length - 1)
                                {
                                    x++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (TempCounter == 0)
                            {

                                foreach(string search in Search)
                                {
                                  //  Search.GetSelected(0)
                                   // string txt = Search.Text.ToString();
                                    if (search == TempString)
                                    {
                                        if (TempCounter == 1 && TempString != "X")
                                        {
                                            TempDataStorage.Add("");
                                            TempCounter++;
                                            TempDataStorage.Add(TempString);
                                        }
                                        else
                                        {
                                            TempDataStorage.Add(TempString);
                                        }
                                        if (TempCounter == 2)
                                        {
                                            tempint = Convert.ToInt16(TempString);
                                            SizeCheck = 8 - Convert.ToInt16(TempString);
                                        }
                                        if (SizeCheck != 0)
                                        {
                                            if (2 + tempint == TempCounter)
                                            {
                                                for (int Rows = 0; Rows < SizeCheck; Rows++)
                                                {
                                                    TempDataStorage.Add("");
                                                    TempCounter++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            
                            counter++;
                            if (counter % 100 == 0)
                            {
                                state.LinesCounted = counter;
                                state.DataStorage = TempDataStorage;
                                worker.ReportProgress(0, state);
                            }
                            
                            TempCounter++;
                            TempString = "";
                        }
                    }
                }
                if (worker != null)
                {
                    MessageBox.Show("Finished searching the file.");
                }
            }
           
        }
        public void SaveFile(string SVFile, List<string> Data, System.ComponentModel.BackgroundWorker worker, System.ComponentModel.DoWorkEventArgs e)
        {
            CurrentState state = new CurrentState();
            int counter = 0;
            string TextSent = "";
            string tempTxt = "";
            // SVFile.DefaultExt = ".txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(SVFile, false))
            {
                
                for (int y = 0; y <= Data.Count - 1; )
                {
                    if ((worker.CancellationPending == true))
                    {
                        e.Cancel = true;
                        worker.Dispose();
                        worker = null;
                        GC.Collect();
                        MessageBox.Show("Canceled");
                        break;
                    }
                    TextSent = "";
                    for (int x = 0; x <= columns - 1; x++)
                    {
                        if (x + y != Data.Count)
                        {
                            TextSent += Data[y + x] + "  ";
                        }
                    }
                    TextSent = Data[y] + " " + Data[y + 1] + " " + Data[y + 2] + " " + Data[y + 3] + " " + Data[y + 4] + " " + Data[y + 5] + " " + Data[y + 6] + " " + Data[y + 7] + " " + Data[y + 8] + " " + Data[y + 9] + " " + Data[y + 10];
                    file.WriteLine(TextSent);
                    y += columns;
                    counter++;
                    if (counter % 100 == 0)
                    {
                        state.LinesCounted = counter;
                        state.DataStorage = Data;
                        worker.ReportProgress(0, state);
                    }
                }
            }
            if (worker != null)
            {
                MessageBox.Show("Finished saving the file.");
            }

        }
    }
}
