using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class DayList<T>
    {
        T[] days;
        //constructor
        // days isimli bir dizi oluşturdum.
        // Constructor metodu içinde, sıfır elemanlı olacak şekilde new'lenecek.
        public DayList() 
        {
            days = new T[0];
        }
        //Add metodum ile istediğim Day değerini ekliyorum. 
        public void Add(T day)
        {
            T[] tempArray = days;
            days = new T[days.Length + 1];
            // days array'imin referansını, tempArray'e atıyoruz ve sıfır elemanlı bir tempArray oluşturuyoruz.
            // days dizimiz farklı bir referans alıp, dizi uzunluğuna bir değerlik boşluk ekliyoruz.
            // new'lendiğinde bir elemanlı days dizisi oluşuyor.
            // new'lendiğinde önceki elemanlar da gidiyor. 
            // for döngüsü ile tempArray'de tuttuğum değerlerimi geri alıyorum.
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                days[i] = tempArray[i];
            }

            days[days.Length-1] = day;
            //day değerini, days dizimin toplam uzunluğunun bir eksiği, yani boş olarak oluşturduğumuz değer yerine ekliyoruz.
        }

    }
}
