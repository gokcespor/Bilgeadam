using SOLID_Homework.SRP.Entity;
using SOLID_Homework.SRP.Examples;

Doktor doktor = new Doktor() { Ad = "Recep Ali", Soyad = "Brohi", HastaneAdi = "Atılım Üniversitesi", HireDate = new DateTime(2022, 07, 10) };
GenelCerrahi.InsertGenelCerrahi(doktor);
Kardiyoloji.InsertKardiyoloji(doktor);
