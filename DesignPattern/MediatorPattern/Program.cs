using MediatorPattern.Concrete;
using MediatorPattern.Interface;
using MediatorPattern.Mediator.Concrete;
using MediatorPattern.Mediator.Interface;

IChatMediator chatMediator = new ChatMediator();   

IUser sina = new GoldUser("atmaca", chatMediator);
IUser efe = new BasicUser("no: 21", chatMediator);
IUser melis = new GoldUser("prenses_su", chatMediator);
IUser gokce = new BasicUser("Hizli_fisek", chatMediator);

chatMediator.AddUser(gokce);
chatMediator.AddUser(melis);
chatMediator.AddUser(efe);
chatMediator.AddUser(sina);
sina.SendMessage("Siz beni delirtmek mi istiyorsunuz!!");