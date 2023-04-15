# Feladat

Ebben a feladatban prímszámokkal fogtok dolgozni, kiírjátok őket egy adott intervallumban a következő szabályok szerint:
 1. A felhasználótól megkérdezitek, mit szeretne kiíratni:
	 1. **csak** a prímszámokat
	 2. csak **nem** a prímszámokat, és hozzá kiír egy tetszőleges szorzatot, amiből az adott szám áll
	 3. **minden** számot, amihez kiírja, hogy az adott szám **prímszám**, vagy ha **nem** prímszám, kiír egy tetszőleges szorzatot, amiből az adott szám áll
1. Utána felszólítja a felhasználót, hogy adja meg az intervallum felső határát, az intervallum zárt: 1től a felső határig
## Leadás
- Mindenki kapott egy névreszóló projektet a `spskn_api_csharp_1/Megoldasok/XXX/02_PrimeNumber` könyvtárban
- Használjátok a pull parancsot a `main` ágban
- Készítsetek egy saját ágat `feature\primeNumber_vezetekNev_nev`
	- ebben oldjátok meg a feladatot, használjátok a `commit` és `push` parancsokat
	- ha készen vagytok, hozzatok létre egy _pull request_-et
## Megjegyzések
_Prímszám: olyan szám, ami csak 1-gyel és önmagával osztható_

_Zárt intervallum: az intervallumba beletartozik az alsó és felső határ is_

# Example
## 1- Just primes
```
This program will find the prime numbers for you. You can choose:
1- just the prime numbers
2- numbers that are not prime numbers
3- both
- 1
Give the upper border: 20
2, is a prime number
3, is a prime number
5, is a prime number
7, is a prime number
11, is a prime number
13, is a prime number
17, is a prime number
19, is a prime number
```

## 2- Just not primes
```
This program will find the prime numbers for you. You can choose:
1- just the prime numbers
2- numbers that are not prime numbers
3- both
- 2
Give the upper border: 20
4 equals 2*2
6 equals 2*3
8 equals 2*4
9 equals 3*3
10 equals 2*5
12 equals 2*6
14 equals 2*7
15 equals 3*5
16 equals 2*8
18 equals 2*9
20 equals 2*10
```
## 3- Both
This program will find the prime numbers for you. You can choose:
```
1- just the prime numbers
2- numbers that are not prime numbers
3- both
- 3
Give the upper border: 29
2, is a prime number
3, is a prime number
4 equals 2*2
5, is a prime number
6 equals 2*3
7, is a prime number
8 equals 2*4
9 equals 3*3
10 equals 2*5
11, is a prime number
12 equals 2*6
13, is a prime number
14 equals 2*7
15 equals 3*5
16 equals 2*8
17, is a prime number
18 equals 2*9
19, is a prime number
20 equals 2*10
21 equals 3*7
22 equals 2*11
23, is a prime number
24 equals 2*12
25 equals 5*5
26 equals 2*13
27 equals 3*9
28 equals 2*14
29, is a prime number
```
