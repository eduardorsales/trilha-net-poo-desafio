using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia celularNokia = new(numero: "999998888", modelo: "NokiaTijolão",
                          imei: "IMEI12301i23-21i30", memoria: 128);

celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("Blaze");

Console.WriteLine("\n");

Iphone celularIphone = new(numero: "999911111", modelo: "Iphone15Plus",
                         imei: "IMEI1-0321-3012i0-wi0-i0", memoria: 128);

celularIphone.Ligar();
celularNokia.ReceberLigacao();
celularIphone.InstalarAplicativo("Carteira de Trabalho Digital");