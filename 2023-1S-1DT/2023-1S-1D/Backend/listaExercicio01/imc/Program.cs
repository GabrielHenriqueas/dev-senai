// Programa IMC

// Faça um programa que calcule o imc de uma pessoa recebendo ow dados
// no console, ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine(@$"
|-------------------|
|   Programa para   |
|   calcular o IMC  |
|-------------------|
");

Console.ResetColor();

Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());


float imc = peso / ((float)Math.Pow(altura,2));

// concatenação
//System.Console.WriteLine("O paciente " + nome + " tem o IMC igual a: " + imc);

// interpolação
Console.WriteLine($"O paciente {nome} tem o imc igual á {imc}");


Console.WriteLine(@$"
                                                                             ...'',;::cclllloodddddddddddddddooolllc:;,''..                                                                             
                                                                     ..',;:clodddddddoooooooooodddddddddddddxxxxxxxxkkkkkkxdlc;,'..                                                                     
                                                                ..,:loddxxddddoooooooooooooooooodddddddddddddxxxxxxxxxxkkkkkOOOOkxdol:'.                                                                
                                                           .':ldxxkxxdddoooooooooooooooooooooooooooddddddddddddxxxxxxxxxxxkkkkOOOOOOO00Odl:,.                                                           
                                                       .;cdk0OOkxxdddooooooooooooooooooooooooooooooodddddddddddddxxxxxxxxxxkkkkkkOOOOOO00000Odc;.                                                       
                                                   .;lxO0K0OkkxdddoooooooolllllllooooooooooooooooooooooodddddddddddddxxxxxxxkkkkOOkOOOkO00000000Oxl;.                                                   
                                               .'cdO000000OkxxddooolllllllllllllllllloooooooooooooooooooooooddddddddddxxxxxxkkkkkkkOOOOOOO0000000000Odc'.                                               
                                            .,lx000000000OkxddoooollllllllllllllllllllllooooooooooooooooooooodddddddddxxxxxkkkkkkkkkkOOOOOOO000000000000xl,.                                            
                                         .,lk0000000000OkxxdoooolllllllcccccccllllllllllloooooooooooooooooooooodddddddxxxxxkkkkkkkkkOOkkOOkOO00000000000000kl,.                                         
                                       'lx000000000000OkxxdoooollllllccccccccccllllllllllloooooooooooooooooooooodddddddxxxxkkkkkkkkkOOOOkkOkOO0000000000000000xl'.                                      
                                    .:d00000000000000kxxddooolllllcccccccccccccclllllllllllooooooooooooooooooooooddddddxxxxkkkkkkkkOOkkkkkOOOOO0000000000000K0000d:.                                    
                                  'lk0000000000000K0kxxxdooollllcccccccccccccccccccllllllllooooooooooooooooooooooodddddxxxxkkkkkkOOOOkkkkkkOOkO00000000000000000000kl,                                  
                               .,dO0000000000000000kxxddooolllcccccccccccccccccccccclllllllloooooooooooooooooooooodddddxxxxkkkkkOOOOOOkkkkkkOOOOO00000000000000000000Od,                                
                             .;d0K00K0000000000000kxxddooolllcccccc:::::cccccccccccllllllllloooooooooooooooooooooodddddxxxxkkkkkkOOOOOOkkkkkkOOkkO000000000000000000000Od;.                             
                           .;x0K00000000000000000Oxxxdooolllcccccc:::::::::cccccccclllllllllooooooooooooooooooodoodddddxxxxkkkkkkkOOOOOkkkkkkkOOkk0K0000000000000000000000x;.                           
                          ,d00000000000000000000Oxdddooollcccccc:::::::::::::ccccccllllllllloooooooooooooooooooooodddddxxxxxkkkkkkkkkkkkkkkkkkkOOOO00000000000000000000000K0d,                          
                        ,d0000000000000000000000Oxddooollccccc:::::::::::::::cccccllllllllllooooooooooooooooooooddddddddxxxxkkkkkkkkkkkkkkkkkkkOOOkO0000000000000000000000000Od,                        
                      .oO0000000000000000000000Okdddoollccc::::::::::::::::::ccccclllllllllooooooooooooooooooooooodddddxxxxxxkkkkkkkkkkkkkkkkkkOOOOO000000000000000000000000000Oo'                      
                    .ck000000000000000000000000Oxddooolccc::::::::::::::::::ccccccllllllllooooooooooooooooooooooooddddxxxxxxkkkkkkkkkkkkkkkkkkkkOOOkO0000000000000000000000000000kc.                    
                   ,x00000000000000000000000000kdddoollcc:::::::::::::::::::cccclllloooooooooooddoooooooooooooooodddddxxxxxkkkkkkkkkkkkkkkkkkkkkkOOkO00000000000000000000000000000Od,                   
                 .cO000000000000000000000000000kddooolcc::::::::::::::::::::cccccllloooooooooddddddooooooooooooodddddxxxxxkkkkkkkkkkkkkkkkkkkkOOOOOOO0000000000000000000000000000000Oc.                 
                'd00000000000000000000000000000kdoooolcc::::;:::::::::::::::cccccllllooooooooddddddoooooooooodddddddxxxxxkkkkkkkkkkkkkkkkkkkkOOOOOOOO00000000000000000000000000000K000d.                
               ;k0K000K000000000000000000000000kdooollcc::::::::::::ccccc::cccccclllllooooooodddddddooooooooooddddddxxxxxkkkkkkkkkkkkkkkkkkkkkOOOOOOO00000000000000000000000000000000K0k;               
             .cO0000000000000000000000000000000kdooolccccc::::::ccccccccccccccccccllllllooooooddddddoooooooooddddddddxxxxxkkkkkkkkkkkkkkkkkkkkkOOOOOO00000000000000000000000000000000000Oc.             
            .o000000000000000000000000000000000kdoollccccccccccccccccccccccccccccccllllllloooooooooooooooooooddoodddddxxxxxkkkkkkkkkkkkkkkkkkkkOOOOOO0000000000000000000000000000000000000o.            
           .d0000000000000000000000000000000000kdoollclccc::::::::::::::::::ccccccccclllllloooooooooooooooooooooooodddddddxxxxxkkkkkkkkkkkkkkkkkOOOOk00000000000000000000000000000000000000d.           
          .d00000000000000000000000000000000000kdoolcc:;;,,''......'',,;;;;;::::::cccccccllllllllooooolllloollllllllllllooooooodddddddddddxxkkkkkOOOk000000000000000000000000000000000000000d'          
         .x000000000000000000000000000000000000kdooc:,'.......  .  ........''',,;;;;;;::::ccllllllooolllllllcc::::::;;;;,,,,,,,,,,,,,,,,;;:cloxkkOOkO0000000000000000000000000000000000000000x.         
        .dK000000000000000000000000000000000000Odol:,'.....               ...........'',,;::ccccccllllllcccc:;,,,,,,''..................'',;;:coxkOkO00000000000000000000000000000000000000000d.        
       .dK0000000000000000000000000000000000000Odol:,'................           .......',,;;::::cclllllc::;;''',,'''....  ..........',,,,;::::loxOkO0000000000000000000000000000000000000000K0d.       
      .o000000000000000000000000000000000000000Odol:;,''''''''''''.........       ........',,;;;::cclllllc:;,'',,,,'.......''',,;:::cccccccccccllxkO00000000000000000000000000000000000000000000o.      
      c0000000000000000000000000000000000000000Oxol:;;,,,,''..............................'',,;;::clllooolc::;;;;,,,''''',,;;;:ccccllloodddddooloxkk0000000000000000000000000000000000000000000K0c      
     ;OK00000000000000000000000000000000Oxdddxkkdolc:;;;;,,''''''''''''''.................'',;;::clloodddollc::;,,,'''...'',,;;::cccllodddddddoddxkOO0000000000000000000000000000000000000000000KO;     
    .xK000000000000000000000000000000000Oocccclllllcc:;;;;;;;,,''''................  .....',,;:cclloodddddolc:;,'.........'',,;;:cllllllooddddxxxkkxxxkO00000000000000000000000000000000000000000Kx.    
   .l000000000000000000000000000000000000xc:cccccllc::;,;;;;'....         .  .............',,;:cclloodddddoc:;,'.........    ....',;:lodooodxxxkkOkxxxxkO00000000000000000000000000000000000000000Kl.   
   ;O000000000000000000000000000000000000Odc::ccllcc:;;,,,'..  ...       .. ..'...........',;::clllooodddooc:;;'.....''.     ......''..;loodxxxkOOOkkkkO0000000000000000000000000000000000000000000O,   
  .dK0000000000000000000000000000000000000Oo::clllcc::;,,'....',;,..        .;;,..........',;:cclllooddxddolc:;,....,;;.  .  ....;lll:,',:ldxkkOOOOOkkO00000000000000000000000000000000000000000000Kd.  
  ;O000000000000000000000000000000000000000xc;cllllcc::;,,,;,'.',,,'........,,'..........',;::cccllooddxxddoc::;''''',;,.. ....,cdxxxdoollodxkOOOOOOkO0000000000000000000000000000000000000000000000O;  
 .dK000000000000000000000000000000000000000Oo:clllcc:::;;;;;,,'...''''...''''''.........',;::ccclloodddxxxddolcc:,,,,,;;,,''',:ldddoooodddxxkOOOOOkO000000000000000000000000000000000000000000000000Kd. 
 ;O00000000000000000000000000000000000000000xcllllccc::;;;;;,,''.....................''',;::ccclllooddxxkxxxdoolc:;;;;;;;;:::ccllllooddxxxkkkOOOOOkO0000000000000000000000000000000000000000000000000O; 
 lK00000000000000000000000000000000000000000kollllcccc:;;;;;;,,,'''.............'''''',,;::cccllloodddxxkkkkxxdoolc::::;;;::::ccllodddxkkkkkkOOOOOkO00000000000000000000000000000000000000000000000000l 
.xK00000000000000000000000000000000000000000Odccllcccc:::;;;;;,,,,,,''''''''''''''',,,;;:::cccllloodddxkkkkkkkxdddollcccccccclllooddxxxkkkkkkOOOOOkO0000000000000000000000000000000000000000000000000Kx.
:0000000000000000000000000000000000000000000Oo:clllcccc:::;;;;;;,,,,,,'''''''''',,,,,;;;:::ccclllodddxxkkkkkkkkxxxxddoollllloooodddxxxkkkkkkOOOOOOkO000000000000000000000000000000000000000000000000000:
o0000K00000000000000000000000000000000000000Ol:clllcccc::::;;;;;;;,,,,,,,,,,,,,,,,,;;;;:::::ccllloddxxxkkkkkkkkkkkxxxxddooooooddddxxxkkkkkkOOOOO0OkO000000000000000000000000000000000000000000000000000l
dK000000000000000000000000000000000000000000Odcccllcccc:::::;;;;;;;;,,,,,,,,;;;;;;;;;;::::::cclloodddxxxxxxkkkkOOkkkkkxxxddddddddxxxxxkkkkOOOOO00OkO00000000000000000000000000000000000000000000000000Kd
xK0000000000000000000000000000000000000000000kollllcccc::::::;;;;;;;;;;;;;;;;;;;;;;;;;;;:::cccllooodddxxxxxxkkOOOOkkkkkxxxxxxddddddxxxkkkOOO0000OOO0000000000000000000000000000000000000000000000000000x
k000000000000000000000000000000000000000000000xolllccccc::::::;;;;;;;;;;::::::::;;;;;;;:::ccccllooodddxkkxxxkkkkOkkkkkkkkxxxxxxxxxxxxxkkOOO00000OkO0000000000000000000000000000000000000000000000000000k
O000000000000000000000000000000000000000000000Odollccccc::::::::;;;;:::::::::::;;;;;;;::::ccclllooooddxxkkkxkkkkkkkkkkkkkkkkkkxxxxxxkkkkOOO000O0OkO0000000000000000000000000000000000000000000000000000O
00000000000000000000000000000000000000000000000kollccccccc:::::::::::::::::::::;;;;;;::cccccclllllloooddxkkxkkkkkxxxxxxxxkkkkkkkkkkkkkOOOOOO000Okk000000000000000000000000000000000000000000000000000000
00000000000000000000000000000000000000000000000Oxoccccccccc:::::::::::::::::::;;;;;::::c::cccllllllllloodkOkkkkkkkxdddxxxxkkkkkkkkkkkOOOOO0OO0Okk0000000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000Oxoccccccccc:::::::::::::::::;;;;;:c::::::::cclllllllloodxkkkkkOOkkxdddddxxxkkkkkkkkOOO0OO0OOOOkO0000000000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000000000Odcccccccccc:::::::::::::::;;;;;:c::::;;;;::ccllllllooodxxxxxkkOOOkddooddxxxxkkkkkkOOO00OOOOOOO00000000000000000000000000000000000000000000000000000000
O0000000000000000000000000000000000000000000000000xlcc:::cccc::::::::::::::::;;:::::::;;,,,:::ccclllloodddooodxxkkkkxddooddxxxxkkkkOOOOO0OOOOOkO0000000000000000000000000000000000000000000000000000000O
k0000000000000000000000000000000000000000000000000klcc::::cc::::::::::::::::::::;;;;;;,'...,;::cccllloodoc,',:codxxxxxxdddddxxxkkkkOOOOOOOOOOkkO0000000000000000000000000000000000000000000000000000000k
dK000000000000000000000000000000000000000000000000Oocc:::::c:::::::::::::::::::::;,,''''...',;:::cclllooolc:ccclodxxxxxxxddxxxxkkkkkOOOOOOOOOkO0000000000000000000000000000000000000000000000000000000Kd
oK0000000000000000000000000000000000000000000000000dccc::::::::::::::;;;;;;::::::;;,,'...'''',;;::clllooooddddooodxkkkkkkxxxxxxkkkkkOOOOOOOOOkO0000000000000000000000000000000000000000000000000000000Ko
c00000000000000000000000000000000000000000000000000xlcc:::::::::::;;;;;;;;;;;;;;;;;;,'''.''''',,,;;:cclloodxxdddxxxkkkkkkkkxxxxkkkkkkOOOOOOOkk000000000000000000000000000000000000000000000000000000000c
,OK000000000000000000000000000000000000000000000000koc:::::::::::;;;;;;;;;;;;;;,,;,,,''''''',,,;,,',;;:cllodddddxxxxxxxkkkkkkkkkkkkkkkOOOOOOkO0000000000000000000000000000000000000000000000000000000Kk,
.o0000000000000000000000000000000000000000000000000Oxc:::::::::::;;;;;;;;;;,,,,,,,,'''''''',,;;;,'.'',;:clooooddddddxxxxxxxkkkkkkkkkkkOOOOOkk00000000000000000000000000000000000000000000000000000000Ko.
 :00000000000000000000000000000000000000000000000000klc:::::::::::;;;;;;;,,,,,'''''''''''',,;;;;,,'''',;:cloooooooodddddddxxkkkkkkkkkkOOOOOkO0000000000000000000000000000000000000000000000000000000K0: 
 'kK000000000000000000000000000000000000000000000000Odc::::::::::::;;;;,,,,,''''''''''',,,,;:::;;,,'',,;:clooooooooooooooddxxxxkkkkkkOOOOOOkO0000000000000000000000000000000000000000000000000000000Kk' 
  c00000000000000000000000000000000000000000000000000koc:::::::::::;;;,,,,,'',,,,,,,,,;;;;;:cccc:;;;;,,:cloodddddddddooooodddxxkkkkkkOOOOOkO000000000000000000000000000000000000000000000000000000000c  
  'kK0000000000000000000000000000000000000000000000000xl:::::::::::;;,,,,,,,,,,,,,;;;;;;;;::ccllcccc::::cloddxxxxxxxddooooodddxxkkkkOOOOOkk00000000000000000000000000000000000000000000000000000000Kk'  
   c00000000000000000000000000000000000000000000000000Odc:::::::::;;;,,,,,,,,,,,,,,'''''''',,;;:cccccccc:::cccloodxxxddooloooodxxkkOOOOOkkO000000000000000000000000000000000000000000000000000000000c   
   .xK0000000000000000000000000000000000000000000000000Odc::::::::;;,,,,'''...................''',,;;;,,,,,,,,,;;;:clllc:::cclodxxkkkkOkkO00000000000000000000000000000000000000000000000000000000Kx.   
    ;OK0000000000000000000000000000000000000000000000000Odc;::::::;;,,'''........................''''''''',,,,;:::::;;;;,,,;:clodxkkkkkkk00000000000000000000000000000000000000000000000000000000KO;    
    .l000000000000000000000000000000000000000000000000000Odc;:::;;;,,,,'''.''''............'''',,,,,,,,,;;::cclloddolodddlccccloodxxkkkkO000000000000000000000000000000000000000000000000000000000l.    
     .d00000000000000000000000000000000000000000000000000Oxc;;;;;;,,,,,,,''''','''...''''''',,;;;;;;;;;;:::clooooddddxxxxddoooooodxxkkkO000000000000000000000000000000000000000000000000000000000d.     
      'k000000000000000000000000000000000000000000000Okdc;..,;;;;,,''',,,,,,',,,,'''''''''',,;;;;::;;;;::ccllooooddxxxxxxxxxdddddddxxocldkO00000000000000000000000000000000000000000000000000000k,      
       ;OK00000000000000000000000000000000000000000kl;'..  '::;,,,,'''',,,,,,,,,,,,,''''''',,;;;;;:;;;:::ccllooodddxxxxxxxxxxddddddxx; ..,cdO0000000000000000000000000000000000000000000000000KO;       
        :O0K000000000000000000000000000000000000Oxc'.  .  ':::;,,,,'''''',,,,,,,,,,,,,,,,,,,,,,;;;;;;;;;:::cclloooddxxxxxxxxxddddddxx:. ...';dO00000000000000000000000000000000000000000000000O:        
         :O00000000000000000000000000000000OkOkdc'.      .;::;;,,,'''''''''',,,,,,,,,,,,,,,,,,,,,,,,,,;;;;;::cllooddxxxxxxxxdddddddkx:.. .....:okO0000000000000000000000000000000000000000000O:         
          cO000000000000000000000000000000o;''...        .;:;;,,,'''''''''''',,,,,,,,,,;;;,,,,,,,,,;;;;::::cclloooddxxddxxxxddddddxOx;.. ...  .';:ldkO000000000000000000000000000000000000000c          
           :OK0000000000000000000000000OOd'              .;;;,,,,'''''''''''''',,,,,,,,,,,,;;;;::::ccclllllllooooddddddddxxxxddddxkOx,......   ...'',:codxkkO000000000000000000000000000000O:           
            ;k000000000000000000000Oxoc;'..              .,;;,,,,,''..''''''''',,,,,,,,,,;;;;:::cccllloodddddddddddddxxxxxxxddddxkkkx;... ..   ..........',;cokO00000000000000000000000000O;            
             ,x0000000000000000Oxl;'..                   .',,,,,,,,''....'''.''',,,,,,,,,;;;;:::cccllloodddxxxxxxdddddxxxxdddodxkkkkx,.......  ...............;cloxO000000000000000000000x,             
              .d00000OOOO0000ko;..                        .,,,,,,,,,''.....'''''',,,,,,,,,;;;;:::cccclloodddxxxxxxddddddddddddxkkkkOd'.......  .. .......    ..'''',:oxO0000000000000000d.              
               .cxxl:;'',;::;'.                           .',,,,,,,,,'''....''''''',,,,,,;;;;;;:::cccclloooddxxxxxddddddddddxxkkkkkkc........  ..  .... .     ........';cloxkO00000000Ol.               
                 ...                                       .',,,,,,,,,,''.......''''',,,,;;;;;;:::ccccccllooodddddddoooooodxxkkkkkkd'.... .......   ....      ......   ....',;codxxkkx;                 
                                                            .',,,,,,,,,,,''.....''''''',,,,,;;;;:::::cccccllooooooooooooodxkkkkkkkx;..... ......     ...      .......     .......''''.                  
                                                             .',,,,,,,,,,,,'........''',,,,,;;;;;;::::::::ccloooollllloodxxkkkkkkx:.....  ......     ..        .... .      ........                     
                                                              .',,,,,,,,,,,,,''........'',,,;;;;;;;;;;;;:::ccllccccclodxxkkkkkkkd;.....  ......                ....        .......                      
                                                                .',,,,,,,,,;;,,''........''',,,,',,,,,,;;;::cccccllodxxxxkkkkkxl'. ..    ......                ....         ....                        
                                                                  ..',,,,,,;;;;,,,'''''''''''''''',,,,;;;:cccclllloddxxxxkkkko;.....    .......                ....         ..                          
                                                                    ..',,,;;;;;;;;,,,,'''''''''',,;;;;;;:ccccccllooddxxxxxkd:.        ........                 ....                                     
                                                                       ..',;;;;;;;;;;,,,,,'''''',,,;;;;;::cccclllodddddxxo:.         ......                     ...                                     
                                                                           ..,;;:::;;;;;;;,,,,,,'',,,,;;;::cclllooooddol;.          .......                     ...                                     
                                                                               ...,,;;:;;;;;;,,,,,,;;;;;:::ccllllollc;..           .....                        ...                                     
                                                                                    ......'',,,,,;;;;;;;;::::;;;,'..               ...   .                      ...                                     
                                                                                                ...........                                                                                             
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        

");

