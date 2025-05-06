using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface ISporcuBransService
    {
        void Ekle(SporcuBrans sporcuBrans);
        void Sil(int SporcuBransId);
        void Güncelle(SporcuBrans sporcuBrans);
        SporcuBrans Getir(int SporcuBransId);
        List<SporcuBrans> Listele();
    }

    public class SporcuBransService : ISporcuBransService
    {
        protected SporKulubuDB db;

        public SporcuBransService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(SporcuBrans sporcuBrans)
        {
            db.SporcuBranslar.Add(sporcuBrans);
            db.SaveChanges();
        }

        public void Sil(int SporcuBransId)
        {
            var sporcuBrans = db.SporcuBranslar.Find(SporcuBransId);
            if (sporcuBrans != null)
            {
                db.SporcuBranslar.Remove(sporcuBrans);
                db.SaveChanges();
            }
        }

        public void Güncelle(SporcuBrans sporcuBrans)
        {
            var eskiKayit = db.SporcuBranslar.Find(sporcuBrans.SporcuBransId);

            eskiKayit.SporcuId = sporcuBrans.SporcuId;
            eskiKayit.BransId = sporcuBrans.BransId;

            db.SporcuBranslar.Update(eskiKayit);
            db.SaveChanges();
        }

        public SporcuBrans Getir(int SporcuBransId)
        {
            var sporcuBrans = db.SporcuBranslar.Find(SporcuBransId);
            return sporcuBrans;
        }

        public List<SporcuBrans> Listele()
        {
            return db.SporcuBranslar.ToList();
        }
    }
}
