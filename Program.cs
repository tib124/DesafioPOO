using DesafioPOO.Models;

var nokia = new Nokia("1", "C12", "356938035643809", 64);
nokia.InstalarAplicativo("Facebook");
nokia.Ligar();
nokia.ReceberLigacao();
var iphone = new Iphone("2", "13", "356938035643801", 128);
iphone.InstalarAplicativo("Youtube");
iphone.Ligar();
iphone.ReceberLigacao();