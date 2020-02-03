﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_othodov
{
    public partial class Otdely : Form
    {
        MySqlOperations MySqlOperations = null;
        MySqlQueries MySqlQueries = null;
        string ID = string.Empty;

        public Otdely()
        {
            InitializeComponent();
        }

        public Otdely(MySqlOperations mySqlOperations, MySqlQueries mySqlQueries, string iD)
        {
            InitializeComponent();
            MySqlOperations = mySqlOperations;
            MySqlQueries = mySqlQueries;
            ID = iD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlOperations.Insert_Update(MySqlQueries.Insert_Otdely, null, textBox1.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlOperations.Insert_Update(MySqlQueries.Update_Otdely, ID, textBox1.Text);
            this.Close();
        }
    }
}
