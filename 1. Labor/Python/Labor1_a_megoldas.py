# region 1. FELADAT
# Konzolra kiírás
print('Hello World!')
print('Hello World Again!')

# endregion

# ---------------------

# region 2. FELADAT
# Kérjünk be valamit a felhasználótól és irjuk is ki azt
name = input('Name: ')
print(f'Hello {name}')

# endregion

# ---------------------

# region 3. FELADAT
# Kérjünk be egy számot, majd szorozzuk be egy a felhasználótól bekért számmal
number1 = int(input('Number 1: '))
number2 = int(input('Number 2: '))
print(number1 * number2)

# endregion

# ---------------------

# region 4. FELADAT
# stringgé alakítása / Parse-olás / kasztolás
# string
x = str(number1)

# int
y = "4"
z = int(y)

# kasztolás
valtozo = 255  # byte: 0-255
masik_valtozo = valtozo  # No need for explicit casting in Python

# endregion
# ---------------------

# region 5. FELADAT
# Téglalap a és b oldalát bekérni, eltárolni egy-egy változóban
# majd a területét és kerületét kiszámolni és kiírni a következő formában:
# "Kerület={változó} [tabulátor] terület={változó}."

a_oldal = int(input("Add meg az 'a' oldalt: "))
b_oldal = int(input("Add meg az 'b' oldalt: "))

# kerület: (a+b)*2
kerulet = (a_oldal + b_oldal) * 2

# terület: a*b
terulet = a_oldal * b_oldal

print(f'Kerület={kerulet} \t Terület={terulet}')

# endregion
