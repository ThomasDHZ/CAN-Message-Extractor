namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DLCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte0C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte1C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte2C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte3C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte4C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte5C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte6C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte7C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.LoadRowsBackGround = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.WriteFilebutton = new System.Windows.Forms.Button();
            this.Chopping = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDC,
            this.TriggerC,
            this.DLCC,
            this.Byte0C,
            this.Byte1C,
            this.Byte2C,
            this.Byte3C,
            this.Byte4C,
            this.Byte5C,
            this.Byte6C,
            this.Byte7C});
            this.dataGridView1.Location = new System.Drawing.Point(3, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(750, 477);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            // 
            // IDC
            // 
            this.IDC.HeaderText = "Can";
            this.IDC.MaxInputLength = 2;
            this.IDC.Name = "IDC";
            this.IDC.Width = 40;
            // 
            // TriggerC
            // 
            this.TriggerC.HeaderText = "Flag";
            this.TriggerC.MaxInputLength = 8;
            this.TriggerC.Name = "TriggerC";
            this.TriggerC.Width = 55;
            // 
            // DLCC
            // 
            this.DLCC.HeaderText = "DLC";
            this.DLCC.Name = "DLCC";
            // 
            // Byte0C
            // 
            this.Byte0C.HeaderText = "Byte 0";
            this.Byte0C.MaxInputLength = 2;
            this.Byte0C.Name = "Byte0C";
            this.Byte0C.Width = 65;
            // 
            // Byte1C
            // 
            this.Byte1C.HeaderText = "Byte 1";
            this.Byte1C.MaxInputLength = 2;
            this.Byte1C.Name = "Byte1C";
            this.Byte1C.Width = 65;
            // 
            // Byte2C
            // 
            this.Byte2C.HeaderText = "Byte 2";
            this.Byte2C.MaxInputLength = 2;
            this.Byte2C.Name = "Byte2C";
            this.Byte2C.Width = 65;
            // 
            // Byte3C
            // 
            this.Byte3C.HeaderText = "Byte 3";
            this.Byte3C.MaxInputLength = 2;
            this.Byte3C.Name = "Byte3C";
            this.Byte3C.Width = 65;
            // 
            // Byte4C
            // 
            this.Byte4C.HeaderText = "Byte 4";
            this.Byte4C.MaxInputLength = 2;
            this.Byte4C.Name = "Byte4C";
            this.Byte4C.Width = 65;
            // 
            // Byte5C
            // 
            this.Byte5C.HeaderText = "Byte 5";
            this.Byte5C.MaxInputLength = 2;
            this.Byte5C.Name = "Byte5C";
            this.Byte5C.Width = 65;
            // 
            // Byte6C
            // 
            this.Byte6C.HeaderText = "Byte 6";
            this.Byte6C.MaxInputLength = 2;
            this.Byte6C.Name = "Byte6C";
            this.Byte6C.Width = 65;
            // 
            // Byte7C
            // 
            this.Byte7C.HeaderText = "Byte 7";
            this.Byte7C.MaxInputLength = 2;
            this.Byte7C.Name = "Byte7C";
            this.Byte7C.Width = 65;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(302, 98);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(131, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Search CAN Message";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            this.ImportButton.MouseHover += new System.EventHandler(this.ImportButton_MouseHover);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(456, 98);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(75, 20);
            this.SearchText.TabIndex = 16;
            // 
            // LoadRowsBackGround
            // 
            this.LoadRowsBackGround.WorkerReportsProgress = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "con";
            this.saveFileDialog1.Filter = "Condensed File (.con)|*.con";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // WriteFilebutton
            // 
            this.WriteFilebutton.Location = new System.Drawing.Point(648, 101);
            this.WriteFilebutton.Name = "WriteFilebutton";
            this.WriteFilebutton.Size = new System.Drawing.Size(103, 23);
            this.WriteFilebutton.TabIndex = 21;
            this.WriteFilebutton.Text = "Save Search";
            this.WriteFilebutton.UseVisualStyleBackColor = true;
            this.WriteFilebutton.Click += new System.EventHandler(this.WriteFilebutton_Click);
            this.WriteFilebutton.MouseHover += new System.EventHandler(this.WriteFilebutton_MouseHover);
            // 
            // Chopping
            // 
            this.Chopping.Location = new System.Drawing.Point(12, 7);
            this.Chopping.Name = "Chopping";
            this.Chopping.Size = new System.Drawing.Size(136, 23);
            this.Chopping.TabIndex = 25;
            this.Chopping.Text = "Condense Source File";
            this.Chopping.UseVisualStyleBackColor = true;
            this.Chopping.Click += new System.EventHandler(this.Chopping_Click);
            this.Chopping.MouseHover += new System.EventHandler(this.Chopping_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text File  (.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Open Condensed File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Condensed File Path:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(417, 36);
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 32;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Source File Path:";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "hst";
            this.saveFileDialog2.Filter = "hst File (.hst)|*.hst";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "con";
            this.openFileDialog2.Filter = "Condensed File  (.con)|*.con";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(417, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(334, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Save Condensed File Path:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(768, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(785, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 40;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(887, 127);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(77, 23);
            this.Addbutton.TabIndex = 41;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(887, 156);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(77, 23);
            this.Removebutton.TabIndex = 42;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 624);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Chopping);
            this.Controls.Add(this.WriteFilebutton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.ComponentModel.BackgroundWorker LoadRowsBackGround;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button WriteFilebutton;
        private System.Windows.Forms.Button Chopping;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte0C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte1C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte2C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte3C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte4C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte5C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte6C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte7C;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removebutton;


    }
}

