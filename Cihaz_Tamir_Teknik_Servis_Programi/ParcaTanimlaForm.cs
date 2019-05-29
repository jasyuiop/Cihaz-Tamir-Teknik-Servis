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
    public partial class ParcaTanimlaForm : Form
    {
        ServisEntities1 db = new ServisEntities1();

        public ParcaTanimlaForm()
        {
            InitializeComponent();
        }

        private void ParcaTanimlaForm_Load(object sender, EventArgs e)
        {
            var parcalar = (from x in db.Parcas select new { No = x.Parca_Id, Parça = x.Parca_Adi }).ToList();
            dataGridView1.DataSource = parcalar;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Parca prc = new Parca();
            prc.Parca_Adi = textBox1.Text;
            db.Parcas.Add(prc);
            db.SaveChanges();
            MessageBox.Show("Parça Kayıt Edildi");
            textBox1.Text = "";
            var parcalar = (from x in db.Parcas select new { No = x.Parca_Id, Parça = x.Parca_Adi }).ToList();
            dataGridView1.DataSource = parcalar;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
