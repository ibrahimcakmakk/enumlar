using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        Console.WriteLine(Günler.pazar);
        Console.WriteLine((int)Günler.cumartesi);

        int sıcaklık = 32;

        if (sıcaklık <= HavaDurumu.Normal)
        {
        Console.WriteLine("Dışarı çıkmak için çok sıcak");
            
        }else if(sıcaklık >= (int)HavaDurumu.Sıcak){
            
            Console.WriteLine("dışarı çıkmak için çok sıcak bir gün");

        }else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.Coksıcak){
            Console.WriteLine("Hadi Dışarı Çıkalım");
        }

    }
}

enum Günler{

    pazartesi = 1,
    salı,
    carşamba,
    perşembe,
    cuma = 23,
    cumartesi,
    pazar,
}

enum HavaDurumu{
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    Coksıcak = 30,
}
