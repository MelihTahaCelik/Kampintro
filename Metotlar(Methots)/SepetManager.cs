﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_Methots_
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi:"+urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi:" + urunAdi);
        }
    
    
    
    }
}
