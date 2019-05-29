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
    public partial class CihazBilgileriniDuzenleForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public CihazBilgileriniDuzenleForm()
        {
            InitializeComponent();
        }

        private void CihazBilgileriniDuzenleForm_Load(object sender, EventArgs e)
        {
            var showcihazs = (from x in db.Cihazs select new { Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
            dataGridView1.DataSource = showcihazs;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString() == textBox1.Text && dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() == textBox2.Text)
                    MessageBox.Show("Kayıt Güncellenmedi, girilen değerler aynı!");
                else
                {
                    string model = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    var update_cihaz = (from x in db.Cihazs where x.Cihaz_Model == model select x).FirstOrDefault();
                    db.Cihazs.Remove(update_cihaz); // aynı nesneyi birden fazla kez referans aldırdığım için silmeden update olmuyor.
                    db.SaveChanges();

                    Cihaz chz = new Cihaz();
                    chz.Cihaz_Marka = textBox1.Text;
                    chz.Cihaz_Model = textBox2.Text;
                    db.Cihazs.Add(chz);
                    db.SaveChanges();
                    MessageBox.Show("Cihaz Bilgileri Güncellendi");

                    var showcihazs = (from x in db.Cihazs select new { Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
                    dataGridView1.DataSource = showcihazs;

                }
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

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string model = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                var sil_cihaz = (from x in db.Cihazs where x.Cihaz_Model == model select x).FirstOrDefault();
                db.Cihazs.Remove(sil_cihaz);
                db.SaveChanges();


                MessageBox.Show("Cihaz Bilgileri Silindi");
                var showcihazs = (from x in db.Cihazs select new { Marka = x.Cihaz_Marka, Model = x.Cihaz_Model }).ToList();
                dataGridView1.DataSource = showcihazs;
            }
            catch
            {
                MessageBox.Show("Silmeye çalıştığınız cihaz bilgileri kullanılıyor !");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
        }
    }
}
