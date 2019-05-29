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
    public partial class ParcaBilgileriniDuzenleForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public ParcaBilgileriniDuzenleForm()
        {
            InitializeComponent();
        }

        private void ParcaBilgileriniDuzenleForm_Load(object sender, EventArgs e)
        {
            var showparcas = (from x in db.Parcas select new { No = x.Parca_Id, Parca = x.Parca_Adi }).ToList();
            dataGridView1.DataSource = showparcas;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() == textBox1.Text)
                MessageBox.Show("Kayıt Güncellenmedi, girilen değerler aynı!");
            else
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var update_parca = (from x in db.Parcas where x.Parca_Id == id select x).FirstOrDefault();
                update_parca.Parca_Adi = textBox1.Text;

                db.SaveChanges();

                MessageBox.Show("Parça Kayıdı Güncellendi");

                var showparcas = (from x in db.Parcas select new { No = x.Parca_Id, Parca = x.Parca_Adi }).ToList();
                dataGridView1.DataSource = showparcas;
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
                var sil_parca = (from x in db.Parcas where x.Parca_Id == id select x).FirstOrDefault();
                db.Parcas.Remove(sil_parca);
                db.SaveChanges();


                MessageBox.Show("Parça Bilgileri Silindi");
                var showparcas = (from x in db.Parcas select new { No = x.Parca_Id, Parca = x.Parca_Adi }).ToList();
                dataGridView1.DataSource = showparcas;
            }
            catch
            {
                MessageBox.Show("Silmeye çalıştığınız parça bilgileri kullanılıyor.");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();
        }
    }
}
