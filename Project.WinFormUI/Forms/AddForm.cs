using Project.BLL.DesingPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinFormUI
{
    public partial class AddForm : Form
    {
        // LocationRepository nesnesi
        LocationRepository locationRepo = new LocationRepository();
        Location location;

        // PhotographerRepository nesnesi
        PhotographerRepository photographerRepo = new PhotographerRepository();
        Photographer photographer;

        // AlbumRepository nesnesi


        public AddForm()
        {
            InitializeComponent();
            LoadLocations();
            LoadPhotographers();
        }

        //Location
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol et
            // Girdi kontrolü: Boş alanlar
            if (string.IsNullOrWhiteSpace(txtLocationName.Text) ||
                string.IsNullOrWhiteSpace(txtLocationAddress.Text) ||
                string.IsNullOrWhiteSpace(txtLocationDistrict.Text) ||
                string.IsNullOrWhiteSpace(txtLocationCity.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Aynı isimde bir lokasyon olup olmadığını kontrol et
                if (locationRepo.IsLocationExists(txtLocationName.Text))
                {
                    MessageBox.Show("Bu isimde bir çekim alanı zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni bir Location nesnesi oluştur ve doldur
                location = new Location
                {
                    Name = txtLocationName.Text,
                    Address = txtLocationAddress.Text,
                    District = txtLocationDistrict.Text,
                    City = txtLocationCity.Text,
                    Description = txtLocationDescription.Text
                };

                // Veritabanına ekle
                locationRepo.Add(location);
                MessageBox.Show("Çekim alanı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile
                LoadLocations();

                // Giriş alanlarını temizle
                LocationTextBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LocationTextBoxlariTemizle()
        {
            txtLocationName.Text = "";
            txtLocationAddress.Text = "";
            txtLocationDistrict.Text = "";
            txtLocationCity.Text = "";
            txtLocationDescription.Text = "";
        }

        private void LoadLocations()
        {
            try
            {
                // Tüm çekim alanlarını getir
                List<Location> locations = locationRepo.GetAll();

                // ListBox'a çekim alanı isimlerini ekle
                lstCekimAlanlari.Items.Clear();
                foreach (Location item in locations)
                {
                    lstCekimAlanlari.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çekim alanları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Photographer
        private void btnPhotographerAdd_Click(object sender, EventArgs e)
        {
            // Girdi kontrolü: Boş alanlar
            if (string.IsNullOrWhiteSpace(txtPhotographerFirstName.Text) ||
         string.IsNullOrWhiteSpace(txtPhotographerLastName.Text) ||
         string.IsNullOrWhiteSpace(txtPhotographerPhone.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Telefon numarası doğrulama
                if (!photographerRepo.ValidatePhoneNumber(txtPhotographerPhone.Text))
                {
                    MessageBox.Show("Telefon numarası 11 haneli olmalıdır ve yalnızca rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Aynı telefon numarasının kayıtlı olup olmadığını kontrol et
                if (photographerRepo.IsPhoneNumberExists(txtPhotographerPhone.Text))
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                photographer = new Photographer
                {
                    FirstName = txtPhotographerFirstName.Text,
                    LastName = txtPhotographerLastName.Text,
                    PhoneNumber = txtPhotographerPhone.Text
                };

                photographerRepo.Add(photographer);
                MessageBox.Show("Fotoğrafçı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhotographers();

                PhotographerTextBoxlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PhotographerTextBoxlariTemizle()
        {
            txtPhotographerFirstName.Text = "";
            txtPhotographerLastName.Text = "";
            txtPhotographerPhone.Text = "";
        }

        private void LoadPhotographers()
        {
            try
            {
                // Tüm fotoğrafçıları getir
                List<Photographer> photographers = photographerRepo.GetAll();

                // ListBox'a ad, soyad ve telefon bilgilerini ekle
                lstFotografcilar.Items.Clear();
                foreach (var photographer in photographers)
                {
                    lstFotografcilar.Items.Add($"{photographer.FirstName} {photographer.LastName} - {photographer.PhoneNumber}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fotoğrafçılar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
