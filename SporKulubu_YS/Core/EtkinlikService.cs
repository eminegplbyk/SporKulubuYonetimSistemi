using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{

    public interface IEtkinlikService
    {
        void Ekle(Etkinlik etkinlik);
        void Sil(int EtkinlikId);
        void Güncelle(Etkinlik etkinlik);
        Etkinlik Getir(int EtkinlikId);
        List<Etkinlik> Listele();
    }

    public class EtkinlikService : IEtkinlikService
    {
        protected SporKulubuDB db;

        public EtkinlikService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Etkinlik etkinlik)
        {
            db.Etkinlikler.Add(etkinlik);
            db.SaveChanges();
        }

        public void Sil(int EtkinlikId)
        {
            var etkinlik = db.Etkinlikler.Find(EtkinlikId);
            if (etkinlik != null)
            {
                db.Etkinlikler.Remove(etkinlik);
                db.SaveChanges();
            }
        }

        public void Güncelle(Etkinlik etkinlik)
        {
            var eskiKayit = db.Etkinlikler.Find(etkinlik.EtkinlikId);

            eskiKayit.EtkinlikAd = etkinlik.EtkinlikAd;
            eskiKayit.EtkinlikYer = etkinlik.EtkinlikYer;
            eskiKayit.EtkinlikTarih = etkinlik.EtkinlikTarih;
            eskiKayit.EtkinlikAciklama = etkinlik.EtkinlikAciklama;
            eskiKayit.BransId = etkinlik.BransId;

            db.Etkinlikler.Update(eskiKayit);
            db.SaveChanges();
        }

        public Etkinlik Getir(int EtkinlikId)
        {
            var etkinlik = db.Etkinlikler.Find(EtkinlikId);
            return etkinlik;
        }

        public List<Etkinlik> Listele()
        {
            return db.Etkinlikler.ToList();
        }
    }
}
    

