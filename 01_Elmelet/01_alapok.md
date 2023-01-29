# VS Code 
[Link lepesekre itt](https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0)

1. Installald be a `VS Code`ot [link](https://code.visualstudio.com/download)
1. .net frameworkot (> net6.0) [link](https://dotnet.microsoft.com/en-us/download)
1. `c:\users\XXX\source` konyvtarban csinalj egy `ConsoleApp` konyvtart
1. nyiss ki egy terminalt (cmd) es menj a `ConsoleApp` konyvtarba (`cd` parancsot hasznald: `cd "c:\users\XXX\source\ConsoleApp"` persze a te gepeden mashol lesz a konyvtar)
1. ird be a kovetkezo parancsot: `dotnet new console --framework net6.0` (termeszetesen, ha a net7.0-ad van, akkor `dotnet new console --framework net7.0`)
1. VSCodeban nyisd ki a konyvtart `Open Folder`, es be fogja installalni a `C# for Visual Studio Code` bovitmenyt (extension)
1. Kinyitod a `Program.cs` fajlt, lesz benne egy sor: `Console.WriteLine("Hello, World!");` CTRL+F5-tel lefuttatod.
1. Ha mindent jol csinaltal, akkor a `Debug console`ban lathatod, hogy kiirta a `Hello, World!`-ot

# Visual Studio
1. Installald be a `Visual Studio Community Editiont`ot [link](https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&includeRecommended=true&cid=2030:e179ff677b104e90ab5481585e20733d)
1. .net frameworkot (> net6.0) [link](https://dotnet.microsoft.com/en-us/download)
1. Ez az IDE egyenesen ra van kotve a C#ra, igy nem kell sokat beallitgatni
1. New Project, megadod neki a helyet, ahol szeretned, adsz neki nevet, es o a szukseges fajlokat kialakitja
1. Ha mindent jol csinaltal, akkor CTRL+F5tel lefuttatja a kodot, es megjelenik egy terminal ablak, `Hello, World!`-ot kiirva

# Alap ismeretek C#hoz

- a nyelv **tipusfuggo**, ami azt jelenti, hogy minden valtoznak, fuggveny be/kimeno parameterenek kell, hogy legyen tipusa (`int`, `float`, `string`, `DateTime`, `bool`)
- az elso sorban lattok egy szoveget, ami nem csinal semmit, zolddel van jelolve, ezt nevezzuk kommentnek. Ketfajta komment van a C#ban:
  - az egysoros `//` ezt hasznaljuk altalaban
  - tobb soros `/* kommentek, akar tobb soron keresztul */`
  - a szoveg, ami a kommentelve van, nem kerul leforditasra gepi kodra, ezt nem kell parancsnak sem lennie
  - Ha tobb sort akarsz kommentelni: jelold ki a sorokat majd a CTRL+K+C parancsot hasznald
  - Ha vissza akarod hozni a sorokat, kitorolni a kommenteket jelolo `//`: CTRL+K+U
- A kodok blokkjat zarojelbe irjuk `{}`
- Minden parancsot `;` vegzunk be

## Valtozok
Nevvel ellatott memoriaterulet. Megnevezesnek hasznaljatok ertelmes, kifejezo nevet, amit konnyu olvasni
```csharp
int gyerekekSzama = 10;
float haviFizetes = 1239.13; 
bool esettAzEsoMa = true;
string ursikloNeve = "Szojuz";
```
Ami ajanlott:
- kis kezdobetu
- minden kovetkezo szo Nagy betuvel
- int/float/string: fonev
- bool: kerdes, amire igen/nem a valasz

Amit nem lehet, ha a valtozonak adtal tipust, akkor cask abbol a tipusbol valo erteket rendelhetsz hozza
```csharp
int gyerekekSzama = 10;
gyerekekSzama = "Szojuz";
```
viszont ez mukodik, nem kell erteket adni a valtozonak mindjart, mikor letrehozod:
```csharp
int gyerekekSzama;
gyerekekSzama = 10;
```
Hogy ne kelljen mindig kiirni a tipust, a nyelv automatikusan meg tudja allapitani helyettunk, es hasznalhatjuk a `var` parancsot. A valtozo erteke nem lesz 'tipustalan', hiszen a fordito eldonti helyettunk. (Ezen a csapatok ossze szoktak veszni, hogy `var` vagy nem `var`, en szeretem hasznalni, olvashatobb a kod, foleg, hogy ha komplexszebb adatokkal (osztaly, `class`) dolgozom)
```csharp
var gyerekekSzama = 10;
var haviFizetes = 1239.13; 
var esettAzEsoMa = true;
var ursikloNeve = "Szojuz";
```
Persze, itt is ervenyes, hogy ez nem mukodik:
```csharp
var gyerekekSzama = 10;
gyerekekSzama = "Szojuz";
```
## Kiiratni a terminalra
Ahogy lattatok, ha kiirunk valamit a kepernyore, akkor `Console.WriteLine("Szoveg");`-et hasznalom. A `Console` egy osztalyk, egyelore nezzuk inkabb ugy, hogy eszkoztar, amelyiknek segitsegevel a kepernyore tudunk kiirni. Ha egy osztalybol/eszkoztarbol szeretnenk egy fuggvenyt, vagy erteket, akkor `.`-ot teszunk, igy tudja a fordito, a nyelv, hol keressen. Sokat segit az IDE, mert a pont utan felkinalja a lehetseges fuggvenyeket, ertekeket.

Beolvasni erteket a `Console.ReadLine();` fuggvennyel fogunk
### Feladat

Keszits egy programot, amelyik bekeri a neved, es kiirja a kepernyore.
```
Ird be a neved:
Tamas
Tamas
```
> `Console.ReadLine();` visszaad egy erteket, amit valtozoba kell elmenteni, majd ezt a valtozot a `Console.WriteLine();` parancsban a zarojelek kozott kell meghivni
## String-ekkel valo munka
A `string`eken (de nem csak rajtuk) muveleteket tudunk futtatni. Elso, amit megtanulunk, az az osszeadas `+`
```csharp
var greeting = "Hello," + " World!";
Console.WriteLine(greeting);
```
### Feladat
Az elobbi parancsnak a segitsegevel valtoztassatok meg a feladatot ugy, hogy udvozoljon a program:
```
Ird be a neved:
Tamas
Szerbusz, Tamas!
```
> Szinten ervenyes, hogy elmented a nevet egy valtozoba, majd csinalhatsz egy uj valtozot, udvzoles/greeting nevvel, ahol osszeadod az egyes karakterlancokat/string-eket
