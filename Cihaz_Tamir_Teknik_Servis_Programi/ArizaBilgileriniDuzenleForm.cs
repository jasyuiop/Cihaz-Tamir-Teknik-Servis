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
    public partial class ArizaBilgileriniDuzenleForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public ArizaBilgileriniDuzenleForm()
        {
            InitializeComponent();
        }

        private void ArizaBilgileriniDuzenleForm_Load(object sender, EventArgs e)
        {
            var showarizas = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
            dataGridView1.DataSource = showarizas;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString() == textBox1.Text)
                MessageBox.Show("Kayıt Güncellenmedi, girilen değer aynı!");
            else
            {

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var update_ariza = (from x in db.Arizas where x.Ariza_Id == id select x).FirstOrDefault();
                update_ariza.Ariza_Tanimi = textBox1.Text;
                db.SaveChanges();

                MessageBox.Show("Arıza Kayıdı Güncellendi");
                var showarizas = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
                dataGridView1.DataSource = showarizas;
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
                var sil_ariza = (from x in db.Arizas where x.Ariza_Id == id select x).FirstOrDefault();
                db.Arizas.Remove(sil_ariza);
                db.SaveChanges();


                MessageBox.Show("Arıza Bilgileri Silindi");
                var showarizas = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
                dataGridView1.DataSource = showarizas;
            }
            catch
            {
                MessageBox.Show("Silmeye çalıştığınız arıza bilgileri kullanılıyor !");
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();

        }
    }
}
