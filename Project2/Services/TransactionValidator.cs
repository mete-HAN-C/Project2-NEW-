using Project2.Models;
using System;

namespace Project2.Services
{
    public static class TransactionValidator
    {
        public static void Validate(tblTransaction t)
        {
            // TransactionType kontrolü: SQL'deki CHECK(TransactionType IN (0,1,2))
            // C# 9.0 ve sonrası desen eşleştirme (pattern matching)
            if (t.TransactionType is not (0 or 1 or 2))
            {
                throw new ArgumentException("İşlem türü geçersiz! Sadece 0 (Gider), 1 (Gelir) veya 2 (Diğer) olabilir.");
            }

            // Tutar kontrolü: Negatif olamaz
            if (t.TransactionAmount < 0)
            {
                throw new ArgumentException("İşlem tutarı 0'dan küçük olamaz.");
            }

            // PersonID kontrolü: Bir kişiye bağlı olmalı
            if (t.PersonID <= 0)
            {
                throw new ArgumentException("Bu işlem geçerli bir kişiye atanmalıdır.");
            }

            // Tarih kontrolü: Geleceğe işlem girilemez (Opsiyonel kural, istersen kaldırabilirsin)
            if (t.TransactionDate > DateTime.Now.AddDays(1))
            {
                // AddDays(1) tolerans payıdır, saat farkları için.
                throw new ArgumentException("Gelecek tarihli işlem girilemez.");
            }
        }
    }
}