using System;
using System.Collections.Generic;

namespace _34_OOP_Examples
{
    public abstract class Yazici
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        //protected Dictionary<Type, int> KagitHaznesi { get; set; }
        //protected List<YaziciHaznesi> KagitHaznesi2 { get; set; }
        protected Dictionary<Type, List<Kagit>> KagitHaznesi { get; set; }
        //protected Dictionary<Type, Stack<Kagit>> KagitHaznesi { get; set; }

        //public bool AcikMi { get; set; }
        public YaziciDurum Durumu { get; private set; }


        public void Ac()
        {
            Durumu = YaziciDurum.Acik;
        }

        public void Kapat()
        {
            Durumu = YaziciDurum.Kapali;
        }

        public void KagitEkle(Type kagitTipi, int adet)
        {
            if (KagitHaznesi.ContainsKey(kagitTipi) == false)
            {
                throw new Exception($"Yazıcı {kagitTipi} isimli kağıt tipini desteklemiyor.");
            }

            //KagitHaznesi[kagitTipi] += adet;

            for (int i = 0; i < adet; i++)
            {
                KagitHaznesi[kagitTipi].Add((Kagit)Activator.CreateInstance(kagitTipi));
            }
        }

        public void KagitEkle<T>(int adet) where T : Kagit, new()
        {
            if (KagitHaznesi.ContainsKey(typeof(T)) == false)
            {
                throw new Exception($"Yazıcı bu kağıt tipini desteklemiyor.");
            }

            for (int i = 0; i < adet; i++)
            {
                KagitHaznesi[typeof(T)].Add(new T());
            }
        }

        public void KagitCikar(Type kagitTipi, int adet)
        {
            if (KagitHaznesi.ContainsKey(kagitTipi) == false)
            {
                throw new Exception($"Yazıcı {kagitTipi} isimli kağıt tipini desteklemiyor.");
            }

            //if (KagitHaznesi[kagitTipi] - adet < 0)
            //{
            //    throw new Exception($"Yazıcı {kagitTipi} isimli haznede yeterli kağıt bulunmuyor.");
            //}

            //KagitHaznesi[kagitTipi] -= adet;


            if (KagitHaznesi[kagitTipi].Count - adet < 0)
            {
                throw new Exception($"Yazıcı {kagitTipi} isimli haznede yeterli kağıt bulunmuyor.");
            }

            KagitHaznesi[kagitTipi].RemoveRange(0, adet);
        }

        public void KagitCikar<T>(int adet) where T : Kagit, new()
        {
            if (KagitHaznesi.ContainsKey(typeof(T)) == false)
            {
                throw new Exception($"Yazıcı bu kağıt tipini desteklemiyor.");
            }

            if (KagitHaznesi[typeof(T)].Count - adet < 0)
            {
                throw new Exception($"Yazıcı da yeterli kağıt bulunmuyor.");
            }

            KagitHaznesi[typeof(T)].RemoveRange(0, adet);
        }

        public Kagit Yazdir(Type kagitTipi)
        {
            if (Durumu == YaziciDurum.Kapali)
            {
                throw new Exception($"Yazıcı kapalı. Lütfen yazıcıyı açınız.");
            }

            if (KagitHaznesi.ContainsKey(kagitTipi) == false)
            {
                throw new Exception($"Yazıcı {kagitTipi} isimli kağıt tipini desteklemiyor.");
            }

            //if (KagitHaznesi[kagitTipi] == 0)
            //{
            //    throw new Exception($"Yazıcı {kagitTipi} isimli kağıttan bulunmuyor.");
            //}

            //KagitHaznesi[kagitTipi] -= 1;
            //return null;

            if (KagitHaznesi[kagitTipi].Count == 0)
            {
                throw new Exception($"Yazıcı da kağıt bulunmuyor.");
            }

            Kagit kagit = KagitHaznesi[kagitTipi][0];
            KagitHaznesi[kagitTipi].RemoveAt(0);

            return kagit;
        }

        public Kagit Yazdir<T>()
        {
            if (Durumu == YaziciDurum.Kapali)
            {
                throw new Exception($"Yazıcı kapalı. Lütfen yazıcıyı açınız.");
            }

            if (KagitHaznesi.ContainsKey(typeof(T)) == false)
            {
                throw new Exception($"Yazıcı {typeof(T)} isimli kağıt tipini desteklemiyor.");
            }

            if (KagitHaznesi[typeof(T)].Count == 0)
            {
                throw new Exception($"Yazıcı da kağıt bulunmuyor.");
            }

            Kagit kagit = KagitHaznesi[typeof(T)][0];
            KagitHaznesi[typeof(T)].RemoveAt(0);

            return kagit;
        }
    }
}


