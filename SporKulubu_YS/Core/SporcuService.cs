using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKulubuYS_Service.Core
{
    public interface ISporcuService
    {
        void Ekle(Sporcu sporcu);
        void Sil(int SporcuId);
        void Güncelle(Sporcu sporcu);
        Sporcu Getir(int SporcuId);
        List<Sporcu> Listele();
    }

    public class SporcuService : ISporcuService
    {
        protected SporKulubuDB db;

        public SporcuService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Sporcu sporcu)
        {
            db.Sporcular.Add(sporcu);
            db.SaveChanges();
        }

        public void Sil(int SporcuId)
        {
            var sporcu = db.Sporcular.Find(SporcuId);
            if (sporcu != null)
            {
                db.Sporcular.Remove(sporcu);
                db.SaveChanges();
            }
        }

        public void Güncelle(Sporcu sporcu)
        {
            var eskiKayit = db.Sporcular.Find(sporcu.SporcuId);

            eskiKayit.SporcuAd = sporcu.SporcuAd;
            eskiKayit.SporcuSoyad = sporcu.SporcuSoyad;
            eskiKayit.SporcuDogumTarihi = sporcu.SporcuDogumTarihi;
            eskiKayit.Cinsiyet = sporcu.Cinsiyet;
            eskiKayit.Eposta = sporcu.Eposta;

            db.Sporcular.Update(eskiKayit);
            db.SaveChanges();
        }

        public Sporcu Getir(int SporcuId)
        {
            var sporcu = db.Sporcular.Find(SporcuId);
            return sporcu;
        }

        public List<Sporcu> Listele()
        {
            return db.Sporcular.ToList();
        }
    }
}


