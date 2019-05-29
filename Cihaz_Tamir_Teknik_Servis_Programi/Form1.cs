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
    public partial class Form1 : Form
    {
        ServisEntities1 db = new ServisEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var musteriler = (from x in db.Musterilers select new { Adı = x.Ad, Soyadı = x.Soyad, Telefon = x.Telno, Cihaz = x.Cihaz.Cihaz_Model, Mail = x.Mail, Adres = x.Adres, Imei = x.Imei, Arıza = x.Ariza.Ariza_Tanimi, Parça = x.Parca.Parca_Adi, Tutarı = x.Tutar, Tarih = x.Servis_Teslim }).ToList();
            dataGridView1.DataSource = musteriler;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var musteriler = (from x in db.Musterilers select new { Adı = x.Ad, Soyadı = x.Soyad, Telefon = x.Telno, Cihaz = x.Cihaz.Cihaz_Model, Mail = x.Mail, Adres = x.Adres, Imei = x.Imei, Arıza = x.Ariza.Ariza_Tanimi, Parça = x.Parca.Parca_Adi, Tutarı = x.Tutar, Tarih = x.Servis_Teslim }).ToList();
            dataGridView1.DataSource = musteriler;
        }

        private void MüşteriTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriTanimlaForm frm = new MusteriTanimlaForm();
            frm.Show();
        }

        private void MüşteriBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriBilgileriniDuzenleForm frm = new MusteriBilgileriniDuzenleForm();
            frm.Show();
        }

        private void ArızaTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArizaTanimlaForm frm = new ArizaTanimlaForm();
            frm.Show();
        }

        private void ArızaBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArizaBilgileriniDuzenleForm frm = new ArizaBilgileriniDuzenleForm();
            frm.Show();
        }

        private void ParçaTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcaTanimlaForm frm = new ParcaTanimlaForm();
            frm.Show();
        }

        private void ParçaBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParcaBilgileriniDuzenleForm frm = new ParcaBilgileriniDuzenleForm();
            frm.Show();
        }

        private void CihazTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CihazTanimlaForm frm = new CihazTanimlaForm();
            frm.Show();
        }

        private void CihazBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CihazBilgileriniDuzenleForm frm = new CihazBilgileriniDuzenleForm();
            frm.Show();
        }
    }
}
