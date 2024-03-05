using AdapterPattren.Concrete;
using AdapterPattren.Interface;

Bagdastirici bagdastirici = new Bagdastirici();

IHedef hedef = new Adapter(bagdastirici);

Console.WriteLine("Bağdaştırıcı interface, istemci ile uyumsuz. ");
Console.WriteLine("Ancak adaptör yardımı ile GetRequest methoduna bağdaştırıcıdaki GetSpecificRequest methodunun değerleri aktarılabildi.");
Console.WriteLine(hedef.GetRequest());