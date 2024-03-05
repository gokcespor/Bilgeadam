using ISP.Concrete;

var sodexo = new Sodexo();
sodexo.Sifreli();

var krediKarti = new KrediKarti();
krediKarti.Sifreli();
krediKarti.Temassiz();

var bankaKarti = new BankaKarti();
bankaKarti.Sifreli();
bankaKarti.Temassiz();
