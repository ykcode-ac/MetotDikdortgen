using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotDikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan gelen girdiler
                double kisaKenar = Convert.ToDouble(txtKisaKenar.Text);
                double uzunKenar = Convert.ToDouble(txtUzunKenar.Text);

                // Metotlar çağırılıyor
                double alan = AlanHesapla(kisaKenar, uzunKenar);
                double cevre = CevreHesapla(kisaKenar, uzunKenar);

                // Sonuçlar etiketlere yazılıyor
                lblAlan.Text = $"Alan: {alan} birim²";
                lblCevre.Text = $"Çevre: {cevre} birim";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Alan hesaplama metodu
        private double AlanHesapla(double kisaKenar, double uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }

        // Çevre hesaplama metodu
        private double CevreHesapla(double kisaKenar, double uzunKenar)
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }
}
