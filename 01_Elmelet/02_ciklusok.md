# Ciklusok
Egy kicsit tobbet talaltok [itt](https://www.w3schools.com/cs/cs_for_loop.php), akar a bongeszoben is ki lehet probalni a muveleteket.

Ketfele ciklus van a C#ban:
- szamolt (`for`, `foreach`)
- szamolatlan (`while`, `do-while`)

# Szamolt ciklusok
## C# For ciklus
```csharp
for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}
```

**Statement 1** egyszer fut le, mielott a kod blokjaba lepne

**Statement 2** definialja a feltetelt, hogy meddig menjen a ciklus

**Statement 3** minden egyes ciklusban vegrehajtodik a blokk utan

### Pelda
```csharp
for (int i = 0; i < 5; i++) 
{
  Console.WriteLine(i);
}
```
Kiirja a kepernyore a szamokat 0-tol 4-ig. 
>Az elso allitas beallitja a valtozo erteket a ciklus elott (`int i = 0`). 
A masodik feltetelt szab (`i<5`). Amig a feltetel igaz, addig vegrehajtodik a ciklus. Minden egyes elvegzett blokk utan az `i` erteke novelve lesz 1-gyel

### Pelda
```csharp
for (int i = 0; i <= 10; i = i + 2) 
{
  Console.WriteLine(i);
}
```
Ez kiir minden paros szamot <0;10> kozott (10et is beleertve)

>Megjegyzes az intervallumokhoz: <a;b> zart intervallum mindket iranybol, a es b is beletartozik. (a;b) nyitott intervallum mindket iranybol, a es b nem tartozik bele. 
### Ciklus a ciklusban
```csharp
// Outer loop
for (int i = 1; i <= 2; ++i) 
{
  Console.WriteLine("Outer: " + i);  // Executes 2 times

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}
```

## Foreach ciklus
Ezt tomboknel hasznaljuk, olyan elemeknel, amelyek orokolnek az `IEnumerable<T>` osztalytol. Kicsit kesobb fogunk ezzel foglalkozni, de legalabb bemutatom.

```csharp
var gyumolcsok = new[]{"alma", "korte", "banan"};
foreach(var gyumolcs in gyumolcsok)
{
    Console.WriteLine(gyumolcs);
}
```
Ez is szamolt ciklus, hiszen mar a legelejen tudjuk, maximum hanyszor fog lefutni. Egyet nem lehet csinalni benne: a ciklus valtozot (ebben az esetben `gyumolcs` erteket megvaltoztatni, nem lehet az egyenlosegjel bal oldalan)
```csharp
var gyumolcsok = new[]{"alma", "korte", "banan"};
foreach(var gyumolcs in gyumolcsok)
{
    gyumolcs = gyumolcs.ToUpper();
    Console.WriteLine(gyumolcs);
}
```

# Szamolatlan ciklusok
[itt](https://www.w3schools.com/cs/cs_while_loop.php) is megtekinthetitek, kirpobalhatjatok az egyes ciklusokat online.

A szamolatlan ciklusokhoz tartozik a `while` es a `do-while` ciklus. Magyarra leforditva: 
- `while` amig a feltetel igaz, csinald
- `do-while` csinald, amig a feltetel igaz

A ketto kozott egy arnyalatnyi kulonbseg van, hogy a `do-while` ciklus **legalabb egyszer** lefut, hiszen a feltetelt a kodblokk vegen ertekeli ki

## While ciklus
```csharp
while (condition) 
{
  // code block to be executed
}
```
Amig a feltetel igaz, addig vegrehajtja a muveletet a blokkban. 
### Pelda
Irjuk ki a szamokat <0;5) intervallumban
```csharp
int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
```
Amint latjatok, itt is letrehozunk egy ciklusszamlalot `i`, itt is van feltetel `i<5`, es itt is novelni kell a ciklusszamlalo erteket `i++`. Persze, ez csak ebben az esetben. Ha fajlbol olvasunk ki, akkor a feltetel a kovetkezo `van-e meg olvasni valo sor`, vagy `jon-e meg adat a beolvasashoz`. 
>Nem kell mindnig ciklusszamlalonak lennie a feltetelben!

## Do-while ciklus
```csharp 
do 
{
  // code block to be executed
}
while (condition);
```
> Ezt akkor hasznaljatok, ha **legalabb egyszer** le akarjatok futtatni a kodot. 

### Pelda
A fenti pelda igy nezne ki `do-while` ciklussal: 
```csharp
int i = 0;
do 
{
  Console.WriteLine(i);
  i++;
}
while (i < 5);
```

# Ciklus parancsok
Ciklusok ket paranccsal is rendelkeznek, ez mindegyikre ervenyes fuggetlenul attol, hogy szamolt-e vagy szamolatlan: `break` es `continue`.
- `break` megszakitja az **egesz ciklus** futasat
- `continue` megszakitja az **az adott blokk** futasat
## break
Ezzel a paranccsal 'kiugrassz' a ciklusbol
```csharp
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}
```
Amint eleri az `i` erteke a 4et, kilep a ciklusbol, tobbet nem ir ki

## continue
Ezzel a paranccsal az adott blokkot szakitod meg, es mesz a kovetkezore
```csharp
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}
```
>Figyeld meg, milyen kulonbseg van a ketto kozott!

# Feladatok

## Feladat
Írj egy, amely bekér egy 20-nál nem nagyobb pozitív egész számot a felhasználótól és kiírja a képernyőre a **START** szót úgy, hogy előtte annyi szóköz legyen amennyi a megadott szám értéke!
## Feladat
Irj programot, amelyik a kovetkezo matrixot irja ki a kepernyore:
```
I****
I****
I****
I****
I****
```
> `Console.WriteLine()` -> tesz uj sort a kiirt szoveg utan `Console.Write()` nem tesz

## Feladat
Irj programot, amelyik a kovetkezo matrixot irja ki a kepernyore:
```
**I**
**I**
**I**
**I**
**I**
```
## Feladat
Irj programot, amelyik a kovetkezo matrixot irja ki a kepernyore:
```
I****
*I***
**I**
***I*
****I
```
## Feladat
Irj programot, amelyik a kovetkezo matrixot irja ki a kepernyore:
```
*****
*****
**o**
*****
*****
```
## Feladat 
Írj egy programot, amely bekér **két pozitív egész számot** a felhasználótól és kiírja a képernyőre azokat a 3-mal osztható egész számokat, amelyek a két adott érték közötti **zárt** intervallumban találhatóak!
1. Pelda: a billentyuzetrol beolvasott ertekek 13 es 28, kiírja: A 3mal oszthato szamok a 13-28 kozotti intervallumbol: 15 18 21 24 27
1. Pelda: a billentyuzetrol beolvasott ertekek 19 es 2, kiírja: A 3mal oszthato szamok a 2-19 kozotti intervallumbol: 3 6 9 12 15 18
> `%` a maradekos osztas jele: `9 % 3== 0`, `10 % 7== 3`, `21 % 6 == 5`

## Feladat
Írj egy programot, amely bekér **egy pozitív egész számot** a felhasználótól és kiírja a képernyőre azokat a pozitív 5tel osztható számokat, amelyek kisebbek az adott számnál!
1. Példa: a billentyűzetről beolvasott érték 19, kíírja: Az 5tel oszthato es (0;19> intervallumban elhelyezkedo szamok a kovetkezok: 5 10 15 
2. Példa: a billentyűzetről beolvasott érték -1, a felhasznalonak megjeleniti, hogy a -1 az nem pozitiv szam
