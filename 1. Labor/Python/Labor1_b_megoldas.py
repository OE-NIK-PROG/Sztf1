import math

# region 1. FELADAT
# Közös feladat - Zuhanó tusfürdős flakon
# Számoljuk ki, hogy egy valamennyi másodpercig zuhanó tusfürdős flakon hány km/h sebességgel ért földet a zuhanyzóban. Az másodpercek értékét kérjük be a konzolról.
print("Hány másodpercig zuhant?")
resp = input()
time = float(resp)
G = 10.0
velocity_mps = G * time
velocity_kmph = velocity_mps * 3.6
print(f"A tusfürdő {velocity_kmph} km/h sebességgel ért földet.")

print("\n")

# endregion
# ---------------------

# region 2. FELADAT
# Önálló feladat - Százlábú sebessége
# Ha egy száz lábú százlábú 10 mm/s sebességgel közlekedik és a sebessége a lábai számával
# egyenesen arányos, milyen gyorsan halad egy olyan százlábú, amelynek valamennyi lába leszakadt? 
# A leszakadt lábak számát kérjük be a konzolról.
print("Hány lába szakadt le?")
legs = 100 - int(input())
full_speed = 10
actual_speed = full_speed / 100 * legs
print(f"Ez a {legs}-lábú {actual_speed} mm/s sebességgel képes menni.")

# endregion
# ---------------------

# region 3. FELADAT
# Önálló feladat - Vehet-e alkoholt?
# Kérjük be egy illető nevét, ill. születési évét, majd névre szólóan írjuk ki, 
# hogy kiadják-e neki az alkoholt a boltban. A születési hónappal, nappal ne törődjünk.
print("Hogy hívnak?")
name = input()
print("Melyik évben születtél?")
year = int(input())
adult = 2020 - year >= 18
print(f"{name} kaphat-e a boltban alkoholt: {adult}")

print("\n")

# endregion
# ---------------------

# region 4. FELADAT
# Önálló feladat - Pizza hasznos része
# Kérjük be egy pizza átmérőjét és a pereme szélességét, majd számoljuk ki, és írjuk ki,
# hogy a pizza felületének hány százalékán van feltét.
print("Hány cm a pizza átmérője?")
diam = float(input())
print("Hány cm széles a pizza pereme?")
edge = float(input())
total_area = math.pi * (diam / 2) ** 2
filled_area = math.pi * ((diam / 2) - edge) ** 2
filling_rate = filled_area / total_area * 100
print(f"A pizza {filling_rate} százalékán van feltét.")

print("\n")

# endregion
# ---------------------

# region 5. FELADAT
# Önálló feladat - Jegyzet besatírozás
# Egy ceruzával 4 darab A4-es oldalt lehet besatírozni, mielőtt elfogyna. 
# Kérjünk be egy színt a konzolról, és számoljuk ki, hány ceruza kell ahhoz, 
# hogy teljesen besatírozzuk az Sztf1 jegyzetnek mind a 292 oldalát ezzel a színnel.
print("Milyen színű a ceruza?")
color = input()
pencils = math.ceil(292.0 / 4.0)
print(f"Csak {pencils} db ceruza kellett hozzá, de az egész jegyzet szép {color} lett.")

# endregion
