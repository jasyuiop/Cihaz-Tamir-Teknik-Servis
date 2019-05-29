namespace Cihaz_Tamir_Teknik_Servis_Programi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arızaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arızaTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arızaBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parçaTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parçaBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.arızaToolStripMenuItem,
            this.parçaToolStripMenuItem,
            this.cihazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(752, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTanımlaToolStripMenuItem,
            this.müşteriBilgileriniDüzenleToolStripMenuItem});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriTanımlaToolStripMenuItem
            // 
            this.müşteriTanımlaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.müşteriTanımlaToolStripMenuItem.Name = "müşteriTanımlaToolStripMenuItem";
            this.müşteriTanımlaToolStripMenuItem.Size = new System.Drawing.Size(395, 36);
            this.müşteriTanımlaToolStripMenuItem.Text = "Müşteri Tanımla";
            this.müşteriTanımlaToolStripMenuItem.Click += new System.EventHandler(this.MüşteriTanımlaToolStripMenuItem_Click);
            // 
            // müşteriBilgileriniDüzenleToolStripMenuItem
            // 
            this.müşteriBilgileriniDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Name = "müşteriBilgileriniDüzenleToolStripMenuItem";
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(395, 36);
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Text = "Müşteri Bilgilerini Düzenle";
            this.müşteriBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.MüşteriBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // arızaToolStripMenuItem
            // 
            this.arızaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arızaTanımlaToolStripMenuItem,
            this.arızaBilgileriniDüzenleToolStripMenuItem});
            this.arızaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arızaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.arızaToolStripMenuItem.Name = "arızaToolStripMenuItem";
            this.arızaToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.arızaToolStripMenuItem.Text = "Arıza";
            // 
            // arızaTanımlaToolStripMenuItem
            // 
            this.arızaTanımlaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.arızaTanımlaToolStripMenuItem.Name = "arızaTanımlaToolStripMenuItem";
            this.arızaTanımlaToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.arızaTanımlaToolStripMenuItem.Text = "Arıza Tanımla";
            this.arızaTanımlaToolStripMenuItem.Click += new System.EventHandler(this.ArızaTanımlaToolStripMenuItem_Click);
            // 
            // arızaBilgileriniDüzenleToolStripMenuItem
            // 
            this.arızaBilgileriniDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.arızaBilgileriniDüzenleToolStripMenuItem.Name = "arızaBilgileriniDüzenleToolStripMenuItem";
            this.arızaBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(366, 36);
            this.arızaBilgileriniDüzenleToolStripMenuItem.Text = "Arıza Bilgilerini Düzenle";
            this.arızaBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ArızaBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // parçaToolStripMenuItem
            // 
            this.parçaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parçaTanımlaToolStripMenuItem,
            this.parçaBilgileriniDüzenleToolStripMenuItem});
            this.parçaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parçaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parçaToolStripMenuItem.Name = "parçaToolStripMenuItem";
            this.parçaToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.parçaToolStripMenuItem.Text = "Parça";
            // 
            // parçaTanımlaToolStripMenuItem
            // 
            this.parçaTanımlaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parçaTanımlaToolStripMenuItem.Name = "parçaTanımlaToolStripMenuItem";
            this.parçaTanımlaToolStripMenuItem.Size = new System.Drawing.Size(369, 36);
            this.parçaTanımlaToolStripMenuItem.Text = "Parça Tanımla";
            this.parçaTanımlaToolStripMenuItem.Click += new System.EventHandler(this.ParçaTanımlaToolStripMenuItem_Click);
            // 
            // parçaBilgileriniDüzenleToolStripMenuItem
            // 
            this.parçaBilgileriniDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.parçaBilgileriniDüzenleToolStripMenuItem.Name = "parçaBilgileriniDüzenleToolStripMenuItem";
            this.parçaBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(369, 36);
            this.parçaBilgileriniDüzenleToolStripMenuItem.Text = "Parça Bilgilerini Düzenle";
            this.parçaBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.ParçaBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // cihazToolStripMenuItem
            // 
            this.cihazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazTanımlaToolStripMenuItem,
            this.cihazBilgileriniDüzenleToolStripMenuItem});
            this.cihazToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cihazToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cihazToolStripMenuItem.Name = "cihazToolStripMenuItem";
            this.cihazToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.cihazToolStripMenuItem.Text = "Cihaz";
            // 
            // cihazTanımlaToolStripMenuItem
            // 
            this.cihazTanımlaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cihazTanımlaToolStripMenuItem.Name = "cihazTanımlaToolStripMenuItem";
            this.cihazTanımlaToolStripMenuItem.Size = new System.Drawing.Size(368, 36);
            this.cihazTanımlaToolStripMenuItem.Text = "Cihaz Tanımla";
            this.cihazTanımlaToolStripMenuItem.Click += new System.EventHandler(this.CihazTanımlaToolStripMenuItem_Click);
            // 
            // cihazBilgileriniDüzenleToolStripMenuItem
            // 
            this.cihazBilgileriniDüzenleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cihazBilgileriniDüzenleToolStripMenuItem.Name = "cihazBilgileriniDüzenleToolStripMenuItem";
            this.cihazBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(368, 36);
            this.cihazBilgileriniDüzenleToolStripMenuItem.Text = "Cihaz Bilgilerini Düzenle";
            this.cihazBilgileriniDüzenleToolStripMenuItem.Click += new System.EventHandler(this.CihazBilgileriniDüzenleToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(660, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(593, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Author: M.Emre Nefesli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 285);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(752, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz Tamir Teknik Servis Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arızaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arızaTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arızaBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parçaTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parçaBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cihazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cihazTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cihazBilgileriniDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

