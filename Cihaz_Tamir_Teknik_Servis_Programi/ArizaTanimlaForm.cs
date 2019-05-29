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
    public partial class ArizaTanimlaForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public ArizaTanimlaForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Ariza arz = new Ariza();
            arz.Ariza_Tanimi = textBox1.Text;

            db.Arizas.Add(arz);
            db.SaveChanges();

            var showarizas = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
            dataGridView1.DataSource = showarizas;

            MessageBox.Show("Arıza bilgileri kayıt edildi!");
            textBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ArizaTanimlaForm_Load(object sender, EventArgs e)
        {
            var showarizas = (from x in db.Arizas select new { No = x.Ariza_Id, Arıza = x.Ariza_Tanimi }).ToList();
            dataGridView1.DataSource = showarizas;
        }
    }
}
