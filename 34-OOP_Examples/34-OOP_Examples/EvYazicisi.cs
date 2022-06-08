using System;
using System.Collections.Generic;

namespace _34_OOP_Examples
{
    public class EvYazicisi : Yazici
    {
        public EvYazicisi()
        {
            //KagitHaznesi = new Dictionary<Type, int>();
            //KagitHaznesi.Add(typeof(KagitA4), 0);

            //KagitHaznesi2 = new List<YaziciHaznesi>();
            //KagitHaznesi2.Add(new YaziciHaznesi { KagitTipi = typeof(KagitA4), Adet = 0 });

            KagitHaznesi = new Dictionary<Type, List<Kagit>>();
            KagitHaznesi.Add(typeof(KagitA4), new List<Kagit>());
        }

    }
    }

