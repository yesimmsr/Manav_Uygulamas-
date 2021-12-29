using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] urunler = { "Domates", "Patlıcan", "Kabak", "Biber", "Elma", "Armut", "Üzüm", "Salatalık", "Marul" };
        decimal[] fiyatlar = new decimal[0];

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form ekranı gelirken bu event tetiklenir.
            FormFill();

        }

        void FormFill()
        {//Form açıldığında combobox dolu gelsin diye
            //ürünler doldurulur.

            for (int i = 0; i < urunler.Length; i++)
            {
                cmbUrun.Items.Add(urunler[i]);
            }
        }

        void FormClear()
        {
            cmbUrun.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        void fiyatEkle(decimal toplamFiyat)
        {
            Array.Resize(ref fiyatlar, fiyatlar.Length + 1;
            fiyatlar[fiyatlar.Length - 1] = toplamFiyat;

        }

        Decimal toplamFiyatlar()
        {
            decimal toplamFiyat = 0;
            for(int i=0; i<fiyatlar.Length; i++)
            {
                toplamFiyat += toplamFiyatlar
            }
        }

        void toplamLabelGuncelle()
        {
            int toplamKg = fiyatlar.Length;
            decimal toplamFiyat =
            lblOzet.Text = $"Toplam {toplamKg} adet ürün {toplamFiyat} TL";
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (cmbUrun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz");
                cmbUrun.Focus();//cmb seçili hale getirir.
                return; //Kodu burada keser aşağıya devam etmez.
            }

            string urunAdi = cmbUrun.SelectedIndex.ToString();

            decimal fiyat = numericUpDown1.Value;
            decimal kg = numericUpDown2.Value;
            decimal toplamFiyat = fiyat * kg;

            string eklenecekUrun = $"{urunAdi} {fiyat}*{kg}={toplamFiyat}TL ";
            //Toplamfiyat ayrı bir dizide tutuyorum.
            FiyatlariEkle(toplamFiyat);
            lstSepet.Items.Add(eklenecekUrun);
            toplamLabelGuncelle();

            FormClear(); //formu temizler
            cmbUrun.Focus(); //Ürüne fokusları kullanı


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //int secim = lstSepet.SelectedIndex;
            //if (secim != -1)
            //{
            //    lstSepet.Items.RemoveAt(secim);
            //}
            //else
            //{
            //    MessageBox.Show("Silinecek ürünü seçiniz.");
            //}

            DialogResult result = MessageBox.Show("Seçilen ürünü silmek istiyor musunuz?", "Manav", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                lstSepet.Items.RemoveAt();
            }
            else
            {

            }

        }

        private void btnSiparisiBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblToplamFiyat.Text);
            FormClear();
            lstSepet.Items.Clear();
            fiyatlar = new decimal[0];
        }
    }
}
