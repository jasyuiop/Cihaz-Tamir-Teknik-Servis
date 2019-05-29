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
    public partial class MusteriTanimlaForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public MusteriTanimlaForm()
        {
            InitializeComponent();
        }

        private void MusteriTanimlaForm_Load(object sender, EventArgs e)
        {
            var cihazlar = (from x in db.Cihazs select new { No = x.Cihaz_Id, Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
            dataGridView1.DataSource = cihazlar;

            var arizalar = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
            dataGridView2.DataSource = arizalar;

            var parcalar = (from x in db.Parcas select new { No = x.Parca_Id, Parça = x.Parca_Adi }).ToList();
            dataGridView3.DataSource = parcalar;
        }
    private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string adi = textBox1.Text;
                string soyadi = textBox2.Text;
                string telno = textBox3.Text;
                string mail = textBox4.Text;
                string adres = textBox5.Text;
                int cihaz_id = Convert.ToInt32(textBox8.Text);
                string imei = textBox6.Text;
                int ariza_id = Convert.ToInt32(textBox9.Text);
                int parca_id = Convert.ToInt32(textBox10.Text);
                int tutar = Convert.ToInt32(textBox7.Text);
                DateTime teslim = dateTimePicker1.Value.Date;


                Musteriler musteri = new Musteriler();
                musteri.Ad = adi;
                musteri.Soyad = soyadi;
                musteri.Telno = telno;
                musteri.Mail = mail;
                musteri.Adres = adres;
                musteri.Cihaz_Id = cihaz_id;
                musteri.Imei = imei;
                musteri.Ariza_Id = ariza_id;
                musteri.Parca_Id = parca_id;
                musteri.Tutar = tutar;
                musteri.Servis_Teslim = teslim;
                db.Musterilers.Add(musteri);
                db.SaveChanges();
                MessageBox.Show("Müşteri Kayıt Edildi");
                this.Close();
            }
            catch
            {
                MessageBox.Show("verileri hatalı veya eksik girdiniz!");
                MessageBox.Show("Girdiğiniz cihaz modeli tanımlı değil ise tanımlayınız!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();

        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            textBox9.Text = dataGridView2.CurrentRow.Cells[0].FormattedValue.ToString();

        }

        private void DataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            textBox10.Text = dataGridView3.CurrentRow.Cells[0].FormattedValue.ToString();

        }
    }
}
