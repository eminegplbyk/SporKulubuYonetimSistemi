using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Core;

namespace SporKulubuYS_UI
{
    /// <summary>
    /// Formlarda tekrar eden işler: hata yakalama, mesajlar, tablo (DataGridView) ayarları.
    /// </summary>
    internal static class UiYardimci
    {
        /// <summary>
        /// İşlemi çalıştırır. Kural hatalarını uyarı, diğer hataları hata mesajı olarak gösterir.
        /// Başarılıysa true döner.
        /// </summary>
        public static bool Calistir(Action islem, string? basariMesaji = null)
        {
            try
            {
                islem();

                if (!string.IsNullOrEmpty(basariMesaji))
                    MessageBox.Show(basariMesaji, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (KuralHatasi ex)
            {
                Uyari(ex.Message);
            }
            catch (Exception ex)
            {
                HataGoster(ex);
            }

            return false;
        }

        public static void HataGoster(Exception ex)
        {
            string detay = ex is DbUpdateException && ex.InnerException != null
                ? ex.InnerException.Message
                : ex.Message;

            MessageBox.Show("Beklenmeyen bir hata oluştu:\n\n" + detay,
                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Uyari(string mesaj)
        {
            MessageBox.Show(mesaj, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Onayla(string mesaj)
        {
            return MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void TabloAyarla(DataGridView tablo)
        {
            tablo.ReadOnly = true;
            tablo.AllowUserToAddRows = false;
            tablo.AllowUserToDeleteRows = false;
            tablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablo.MultiSelect = false;
            tablo.RowHeadersVisible = false;
            tablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablo.BackgroundColor = SystemColors.Window;
            tablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 245);
        }

        /// <summary>
        /// Listeyi tabloya bağlar. Listedeki nesnelerin "Id" kolonu gizlenir;
        /// seçili satırın Id'si SeciliId ile okunur.
        /// </summary>
        public static void Bagla<T>(DataGridView tablo, IEnumerable<T> veri)
        {
            tablo.DataSource = veri.ToList();

            DataGridViewColumn? idKolonu = tablo.Columns["Id"];
            if (idKolonu != null)
                idKolonu.Visible = false;

            tablo.ClearSelection();
        }

        public static int SeciliId(DataGridView tablo, int satirIndex)
        {
            if (satirIndex < 0 || satirIndex >= tablo.Rows.Count)
                return 0;

            object? deger = tablo.Rows[satirIndex].Cells["Id"].Value;
            return deger == null ? 0 : Convert.ToInt32(deger);
        }

        /// <summary>ComboBox'ı (Id, Ad) listesiyle doldurur, seçimi temizler.</summary>
        public static void ComboDoldur(ComboBox combo, IEnumerable<SecimOgesi> ogeler)
        {
            combo.DisplayMember = nameof(SecimOgesi.Ad);
            combo.ValueMember = nameof(SecimOgesi.Id);
            combo.DataSource = ogeler.ToList();
            combo.SelectedIndex = -1;
        }

        public static int ComboId(ComboBox combo)
        {
            return combo.SelectedValue is int id ? id : 0;
        }
    }

    /// <summary>ComboBox'larda gösterilen basit (Id, Ad) çifti.</summary>
    internal sealed record SecimOgesi(int Id, string Ad);
}
