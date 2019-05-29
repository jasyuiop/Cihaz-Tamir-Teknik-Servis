using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cihaz_Tamir_Teknik_Servis_Programi
{
    public partial class CihazTanimlaForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public CihazTanimlaForm()
        {
            InitializeComponent();
        }

        private void CihazTanimlaForm_Load(object sender, EventArgs e)
        {
            var cihazlar = (from x in db.Cihazs select new { Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
            dataGridView1.DataSource = cihazlar;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cihaz chz = new Cihaz();
                chz.Cihaz_Marka = textBox1.Text;
                chz.Cihaz_Model = textBox2.Text;
                db.Cihazs.Add(chz);
                db.SaveChanges();
                MessageBox.Show("Cihaz Kayıt Edildi");
                textBox1.Text = "";
                textBox2.Text = "";

                var cihazlar = (from x in db.Cihazs select new { Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
                dataGridView1.DataSource = cihazlar;
            }
            catch
            {
                MessageBox.Show("Aynı isime sahip cihaz modeli, HATA! Sayfa kapanıyor..");
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
