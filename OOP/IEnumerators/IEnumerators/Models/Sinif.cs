using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerators.Models
{
    public class Sinif : IEnumerable
    {
        private Ogrenci[] Ogrenciler { get; set; }
        public Sinif(params Ogrenci[] ogrenciler)
        {
            Ogrenciler = ogrenciler;
        }

        public int YaslarinToplami()
        {
            int toplam = 0;
            IEnumerator sayac = Ogrenciler.GetEnumerator();
            while (sayac.MoveNext())
            {
                toplam += ((Ogrenci)sayac.Current).Yas;
            }
            return toplam;
        }

        public IEnumerator GetEnumerator()
        {
            return new OgrenciEnumerator(Ogrenciler);
        }
    }
    class OgrenciEnumerator : IEnumerator
    {
        // 1) Aktarılacak Dizi
        private Ogrenci[] _ogrenciler;

        // 2) Enumerator class ı içerisindeki _ogrenciler adlı dizinin içinin dolması için constructor da parametre olarak bir öğrenci dizisi alıp bunu içerdeki _ogrenciler adlı private bir field a aktardık.
        public OgrenciEnumerator(Ogrenci[] ogrenciler)
        {
            _ogrenciler = ogrenciler;
        }

        // 3) Dönmeye kaçıncı index ten başlayalım 
        int index = -1;

        // Current => 0 dan turnikeden geçen elemanı size verir.
        public object Current { get { return _ogrenciler[index]; } }

        // MoveNext => Önce index i arttırır, daha sonra eleman var mı yok mu diye kontrol eder.
        public bool MoveNext()
        {
            index++;
            return this.index < _ogrenciler.Length;
        }

        // MoveNext methodu false döndüğü an index i sıfırlayarak, döngüyü bitirir.
        public void Reset()
        {
            index = -1;
        }
    }
}
