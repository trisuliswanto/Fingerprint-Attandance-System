using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FingerPrintAttandanceSystem
{
    public partial class DataSiswa : Form
    {
        IController msgController;
        int msgValue;

        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int id;
        bool isDoubleClick = false;
        String connectString;

        public DataSiswa()
        {
            InitializeComponent();
            msgValue = 0;

            connectString = @"Data Source=" + Application.StartupPath + @"\database.sqlite;Version=3;";
        }

        public DataSiswa(IController controller): this()
        {
            this.msgController = controller;
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            this.msgController.ControllerEvent += new MessageDelegate(msgController_ControllerEvent);
            //this.FormClosing += new FormClosingEventHandler(DataSiswa_FormClosing);
            list_kelas();
            ReadData();
        }

        // this is the method being called.
        void msgController_ControllerEvent(object sender, MessageEventArgs e)
        {
            this.msgValue += 1;
            this.label1.Text = e.Message + " " + this.msgValue.ToString();
        }

        private void DataSiswa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.msgController.ControllerEvent -= msgController_ControllerEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.msgController.InvokeControllerEvent("Form2 fired the event. ");
        }

        private void list_kelas()
        {
            try
            {
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                String sql = "SELECT * from kelas";
                adapter = new SQLiteDataAdapter(sql, conn);
                DataSet ds_kelas = new DataSet();
                ds_kelas.Reset();
                adapter.Fill(ds_kelas, "Kelas");
                comboBox_kelas.DisplayMember = "nama_kelas";
                comboBox_kelas.ValueMember = "id";
                comboBox_kelas.DataSource = ds_kelas.Tables["Kelas"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void ReadData()
        {
            try
            {
                conn = new SQLiteConnection(connectString);
                conn.Open();
                cmd = new SQLiteCommand();
                String sql = "SELECT a.id, a.id, a.name, a.address, a.date_of_birth, b.nama_kelas, a.finger_id  FROM users a LEFT JOIN kelas b ON a.kelas_id = b.id WHERE level != 'admin' ";
                adapter = new SQLiteDataAdapter(sql, conn);
                ds.Reset();
                adapter.Fill(ds);
                dt = ds.Tables[0];

                int cnt = 1;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    dr.SetField(1, cnt++);  //tambahkan row number
                }

                dataGridView1.DataSource = dt;
                conn.Close();

                dataGridView1.Columns[1].HeaderText = "No.";
                dataGridView1.Columns[2].HeaderText = "Nama";
                dataGridView1.Columns[3].HeaderText = "Alamat";
                dataGridView1.Columns[4].HeaderText = "Tanggal Lahir";
                dataGridView1.Columns[5].HeaderText = "Kelas";
                dataGridView1.Columns[6].HeaderText = "Finger ID";
                dataGridView1.Columns[0].Visible = false; // kolom id
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_tambah_data_Click(object sender, EventArgs e)
        {
            textBox_nama.Enabled = true;
            textBox_nama.ReadOnly = false;

            richTextBox_alamat.Enabled = true;
            richTextBox_alamat.ReadOnly = false;

            dateTimePicker_ttl.Enabled = true;

            comboBox_kelas.Enabled = true;
        }
    }
}
