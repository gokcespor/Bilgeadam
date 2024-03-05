using TheChainOfResponsibility.Abstract;
using TheChainOfResponsibility.Concrete;


// Zincirlerin halkalarını tanımladık
PlayerHandler aviPlayer = new HandlerAVI();
PlayerHandler mp3Player = new HandlerMP3();
PlayerHandler mp4Player = new HandlerMP4();

// Zinciri oluşturuyoruz
mp3Player.NextHandler = mp4Player;
mp4Player.NextHandler = aviPlayer;

// İsteklerimizi zincirin ilk halkası olan mp3Player a gönderilir.
mp3Player.Player("gore.avi");
mp3Player.Player("hayaletsevgilim.mp3");
mp3Player.Player("tarkan-kuzu kuzu.mp4");
mp3Player.Player("resim.png");