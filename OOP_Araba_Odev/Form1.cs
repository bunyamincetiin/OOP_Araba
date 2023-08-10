using System.Windows.Forms;

namespace OOP_Araba_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Arac>dlist= new List<Arac>();
        public void Form1_Load(object sender, EventArgs e)
        {
            cmbAracTuru.DataSource = Enum.GetValues(typeof(Aracturu));
            cmbAracTuru.SelectedIndex = -1;
            cmbAracMarkasi.DataSource = Enum.GetValues(typeof(Marka));
            cmbAracMarkasi.SelectedIndex = -1;
            cmbAracModeli.DataSource = Enum.GetValues(typeof(Model));
            cmbAracModeli.SelectedIndex = -1;
            cmbSanzimanTuru.DataSource = Enum.GetValues(typeof(SanzimanTuru));
            cmbSanzimanTuru.SelectedIndex = -1;
            cmbYakitTuru.DataSource = Enum.GetValues(typeof(YakitTuru));
            cmbYakitTuru.SelectedIndex = -1;
            cmbKasaTipi.DataSource = Enum.GetValues(typeof(KasaTipi));
            cmbKasaTipi.SelectedIndex = -1;
            
            numericUpModel.Minimum = 1950;
            numericUpModel.Maximum = DateTime.Now.Year;
            numericUpModel.Value = DateTime.Now.Year;
            numericUpMotorGucu.Minimum = 0;
            numericUpMotorGucu.Maximum = 5000;
            numericUpMotorGucu.Value = 1000;
        }

        public void btnAraciOlustur_Click(object sender, EventArgs e)
        {
            Arac yeniarac = new Arac()
            {
                AracTuru = cmbAracTuru.SelectedItem.ToString(),
                AracMarkasi = cmbAracMarkasi.SelectedItem.ToString(),
                AracModeli = cmbAracModeli.SelectedItem.ToString(),
                AracSanzimani = cmbSanzimanTuru.SelectedItem.ToString(),
                KasaTipi = cmbKasaTipi.SelectedItem.ToString(),
                YakitTipi = cmbYakitTuru.SelectedItem.ToString(),
                ModelYili = Convert.ToInt16(numericUpModel.Value),
                MotorGucu = Convert.ToInt32(numericUpMotorGucu.Value),
                Garanti = chcGarantisiVar.Checked
            };

            dlist.Add(yeniarac);
            Temizle();
            listArac.Items.Add(yeniarac);
        }

        public void btnResimEkle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "Resim Dosyalarý | *.jpg; *";
                openfiledialog.Title = "Resim seç";
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openfiledialog.FileName;
                    pictureBox1.Image = Image.FromFile(selectedFilePath);
                }
                Bitmap resim = new Bitmap(openfiledialog.FileName);
                btnResimGoster.BackgroundImageLayout = ImageLayout.Stretch;
                btnResimGoster.BackgroundImage = resim;
            }
        }

        public void lblAracRengi_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    lblAracRengi.BackColor = selectedColor;
                }
            }
        }

        public void listArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listArac.SelectedIndex >= 0)
            {
                Arac seciliArac = dlist[listArac.SelectedIndex];
                cmbAracTuru.SelectedItem = (Aracturu)Enum.Parse(typeof(Aracturu), seciliArac.AracTuru);
                cmbAracMarkasi.SelectedItem = (Marka)Enum.Parse(typeof(Marka), seciliArac.AracMarkasi);
                cmbAracModeli.SelectedItem = (Model)Enum.Parse(typeof(Model), seciliArac.AracModeli);
                cmbSanzimanTuru.SelectedItem = (SanzimanTuru)Enum.Parse(typeof(SanzimanTuru), seciliArac.AracSanzimani);
                cmbKasaTipi.SelectedItem = (KasaTipi)Enum.Parse(typeof(KasaTipi), seciliArac.KasaTipi);
                cmbYakitTuru.SelectedItem = (YakitTuru)Enum.Parse(typeof(YakitTuru), seciliArac.YakitTipi);
                numericUpModel.Value = seciliArac.ModelYili;
                numericUpMotorGucu.Value = seciliArac.MotorGucu;
                chcGarantisiVar.Checked = seciliArac.Garanti;
            }
        }
        public void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox g = item as GroupBox;
                    foreach (Control cmb in g.Controls)
                    {
                        if (cmb is ComboBox)
                        {
                            ComboBox comboBox = (ComboBox)cmb;
                            comboBox.SelectedIndex = -1;
                        }
                    }
                }
            }

        }
    }
    
}