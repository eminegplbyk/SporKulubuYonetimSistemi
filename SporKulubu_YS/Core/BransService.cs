using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface IBransService
    {
        void Ekle(Brans brans);
        void Sil(int bransId);
        void Güncelle(Brans brans);
        Brans Getir(int bransId);
        List<Brans> Listele();
    }

    public class BransService : IBransService
    {
        protected SporKulubuDB db;

        public BransService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Brans brans)
        {
            db.Branslar.Add(brans);
            db.SaveChanges();
        }

        public void Sil(int bransId)
        {
            var brans = db.Branslar.Find(bransId);
            if (brans != null)
            {
                db.Branslar.Remove(brans);
                db.SaveChanges();
            }
        }

        public void Güncelle(Brans brans)
        {
            var eskiKayit = db.Branslar.Find(brans.BransId);
            if (eskiKayit != null)
            {
                eskiKayit.BransAd = brans.BransAd;
                eskiKayit.BransAntrenorler = brans.BransAntrenorler;
                eskiKayit.Etkinlikler = brans.Etkinlikler;
                eskiKayit.Salonlar = brans.Salonlar;
                eskiKayit.SporcuBranslar = brans.SporcuBranslar;

                db.Branslar.Update(eskiKayit);
                db.SaveChanges();
            }
        }

        public Brans Getir(int bransId)
        {
            var brans = db.Branslar.Find(bransId);
            return brans;
            
        }

        public List<Brans> Listele()
        {
            return db.Branslar.ToList();
        }


    }
}
