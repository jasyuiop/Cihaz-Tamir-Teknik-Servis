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
    public partial class MusteriBilgileriniDuzenleForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public MusteriBilgileriniDuzenleForm()
        {
            InitializeComponent();
        }

        private void MusteriBilgileriniDuzenleForm_Load(object sender, EventArgs e)
        {
            var musteriler = (from x in db.Musterilers select new { No = x.Musteri_Id, Adı = x.Ad, Soyadı = x.Soyad, Telefon = x.Telno, Mail = x.Mail, Adres = x.Adres, Cihaz = x.Cihaz.Cihaz_Id, Imei = x.Imei, Arıza = x.Ariza.Ariza_Id, Parça = x.Parca.Parca_Id, Tutarı = x.Tutar, Tarih = x.Servis_Teslim }).ToList();
            dataGridView1.DataSource = musteriler;

            var cihazlar = (from x in db.Cihazs select new { No = x.Cihaz_Id, Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
            dataGridView2.DataSource = cihazlar;

            var arizalar = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi}).ToList();
            dataGridView3.DataSource = arizalar;

            var parcalar = (from x in db.Parcas select new { No = x.Parca_Id, Parça = x.Parca_Adi }).ToList();
            dataGridView4.DataSource = parcalar;
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

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var update_musteri = (from x in db.Musterilers where x.Musteri_Id == id select x).FirstOrDefault();
                update_musteri.Ad = adi;
                update_musteri.Soyad = soyadi;
                update_musteri.Telno = telno;
                update_musteri.Mail = mail;
                update_musteri.Adres = adres;
                update_musteri.Cihaz_Id= cihaz_id;
                update_musteri.Imei = imei;
                update_musteri.Ariza_Id = ariza_id;
                update_musteri.Parca_Id = parca_id;
                update_musteri.Tutar = tutar;
                update_musteri.Servis_Teslim = teslim;

                db.SaveChanges();

                MessageBox.Show("Müşteri Bilgileri Güncellendi!");

                var musteriler = (from x in db.Musterilers select new { No = x.Musteri_Id, Adı = x.Ad, Soyadı = x.Soyad, Telefon = x.Telno, Mail = x.Mail, Adres = x.Adres, Cihaz = x.Cihaz.Cihaz_Id, Imei = x.Imei, Arıza = x.Ariza.Ariza_Id, Parça = x.Parca.Parca_Id, Tutarı = x.Tutar, Tarih = x.Servis_Teslim }).ToList();
                dataGridView1.DataSource = musteriler;
            }
            catch
            {
                MessageBox.Show("Hata! Cihaz, parça, arıza no'lardan birisini yanlış girmiş olabilirsiniz.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var sil_musteri = (from x in db.Musterilers where x.Musteri_Id == id select x).FirstOrDefault();
                db.Musterilers.Remove(sil_musteri);
                db.SaveChanges();


                MessageBox.Show("Müşteri Bilgileri Silindi");
                var musteriler = (from x in db.Musterilers select new { No = x.Musteri_Id, Adı = x.Ad, Soyadı = x.Soyad, Telefon = x.Telno, Mail = x.Mail, Adres = x.Adres, Cihaz = x.Cihaz.Cihaz_Id, Imei = x.Imei, Arıza = x.Ariza.Ariza_Id, Parça = x.Parca.Parca_Id, Tutarı = x.Tutar, Tarih = x.Servis_Teslim }).ToList();
                dataGridView1.DataSource = musteriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu hata kodu /n" + ex);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].FormattedValue.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].FormattedValue.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].FormattedValue.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[10].FormattedValue.ToString();

            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[11].FormattedValue.ToString());
        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            textBox8.Text = dataGridView2.CurrentRow.Cells[0].FormattedValue.ToString();
        }

        private void DataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            textBox9.Text = dataGridView3.CurrentRow.Cells[0].FormattedValue.ToString();
        }

        private void DataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            textBox10.Text = dataGridView4.CurrentRow.Cells[0].FormattedValue.ToString();

        }
    }
    }

