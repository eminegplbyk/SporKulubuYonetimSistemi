using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface IAntrenorService
    {
        void Ekle(Antrenor antrenor);
        void Sil(int AntrenorId);
        void Güncelle(Antrenor antrenor);
        Antrenor Getir(int AntrenorId);
        List<Antrenor> Listele();
    }

    public class AntrenorService : IAntrenorService
    {
        protected SporKulubuDB db;

        public AntrenorService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Antrenor antrenor)
        {
            db.Antrenorler.Add(antrenor);
            db.SaveChanges();
        }

        public void Sil(int AntrenorId)
        {
            var antrenor = db.Antrenorler.Find(AntrenorId);
            if (antrenor != null)
            {
                db.Antrenorler.Remove(antrenor);
                db.SaveChanges();
            }
        }

        public void Güncelle(Antrenor antrenor)
        {
            var eskiKayit = db.Antrenorler.Find(antrenor.AntrenorId);

            eskiKayit.AntrenorAd = antrenor.AntrenorAd;
            eskiKayit.AntrenorSoyad = antrenor.AntrenorSoyad;
            eskiKayit.Uzmanlık = antrenor.Uzmanlık;
            eskiKayit.AntrenorDogumTarihi = antrenor.AntrenorDogumTarihi;
            eskiKayit.Ulke = antrenor.Ulke;

            db.Antrenorler.Update(eskiKayit);
            db.SaveChanges();
        }

        public Antrenor Getir(int AntrenorId)
        {
            var antrenor = db.Antrenorler.Find(AntrenorId);
            return antrenor;
        }

        public List<Antrenor> Listele()
        {
            return db.Antrenorler.ToList();
        }
    }


    
}
