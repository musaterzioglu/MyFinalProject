using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //Property'ler iki noktada kullanılabiliyordu
        //Getter'lar okumak için
        //Setter'lar yazmak için
        bool Success { get; } // Setter yapamıyoruz. o zaman nasıl yazacağız constructorda bir hareket yaparak.
        string Message { get; }

    }
}
