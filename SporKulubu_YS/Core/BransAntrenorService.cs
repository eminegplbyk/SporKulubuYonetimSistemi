using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface IBransAntrenorService
    {
        void Ekle(BransAntrenor bransAntrenor);
        void Sil(int BransAntrenorId);
        void Güncelle(BransAntrenor bransAntrenor);
        BransAntrenor Getir(int BransAntrenorId);
        List<BransAntrenor> Listele();
    }

    public class BransAntrenorService : IBransAntrenorService
    {
        protected SporKulubuDB db;

        public BransAntrenorService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(BransAntrenor bransAntrenor)
        {
            db.BransAntrenorler.Add(bransAntrenor);
            db.SaveChanges();
        }

        public void Sil(int BransAntrenorId)
        {
            var bransAntrenor = db.BransAntrenorler.Find(BransAntrenorId);
            if (bransAntrenor != null)
            {
                db.BransAntrenorler.Remove(bransAntrenor);
                db.SaveChanges();
            }
        }

        public void Güncelle(BransAntrenor bransAntrenor)
        {
            var eskiKayit = db.BransAntrenorler.Find(bransAntrenor.BransAntrenorId);

            eskiKayit.AntrenorId = bransAntrenor.AntrenorId;
            eskiKayit.BransId = bransAntrenor.BransId;

            db.BransAntrenorler.Update(eskiKayit);
            db.SaveChanges();
        }

        public BransAntrenor Getir(int BransAntrenorId)
        {
            var bransAntrenor = db.BransAntrenorler.Find(BransAntrenorId);
            return bransAntrenor;
        }

        public List<BransAntrenor> Listele()
        {
            return db.BransAntrenorler.ToList();
        }
    }
}
