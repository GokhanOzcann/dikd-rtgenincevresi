﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdörtgenincevresi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal birinci, ikinci,ucuncu;
            birinci = Convert.ToInt32(textBox1.Text);
            ikinci = Convert.ToInt32(textBox2.Text);
            ucuncu = (birinci + ikinci)/2;
            if (birinci > 100 || ikinci > 100)
            {
                MessageBox.Show("Not girişleri 100 den büyük olamaz.");
            }
            else
            {
                MessageBox.Show("Not ortalaması başarıyla hesaplandı ve listeye eklendi.");
                listBox1.Items.Add(ucuncu
                );
            }
            
        }


    }
    }

