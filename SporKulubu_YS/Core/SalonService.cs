using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface ISalonService
    {
        void Ekle(Salon salon);
        void Sil(int SalonId);
        void Güncelle(Salon salon);
        Salon Getir(int SalonId);
        List<Salon> Listele();
    }

    public class SalonService : ISalonService
    {
        protected SporKulubuDB db;

        public SalonService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Salon salon)
        {
            db.Salonlar.Add(salon);
            db.SaveChanges();
        }

        public void Sil(int SalonId)
        {
            var salon = db.Salonlar.Find(SalonId);
            if (salon != null)
            {
                db.Salonlar.Remove(salon);
                db.SaveChanges();
            }
        }

        public void Güncelle(Salon salon)
        {
            var eskiKayit = db.Salonlar.Find(salon.SalonId);

            eskiKayit.SalonAd = salon.SalonAd;
            eskiKayit.Kapasite = salon.Kapasite;
            eskiKayit.SalonYer = salon.SalonYer;
            eskiKayit.BransId = salon.BransId;

            db.Salonlar.Update(eskiKayit);
            db.SaveChanges();
        }

        public Salon Getir(int SalonId)
        {
            var salon = db.Salonlar.Find(SalonId);
            return salon;
        }

        public List<Salon> Listele()
        {
            return db.Salonlar.ToList();
        }
    }
}
