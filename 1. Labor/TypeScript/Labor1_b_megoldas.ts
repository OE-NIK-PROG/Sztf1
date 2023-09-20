// #region 1. FELADAT
// Közös feladat - Zuhanó tusfürdős flakon
// Számoljuk ki, hogy egy valamennyi másodpercig zuhanó tusfürdős flakon hány km/h sebességgel ért földet a zuhanyzóban. Az másodpercek értékét kérjük be a konzolról.
console.log("Hány másodpercig zuhant?");
const resp: string = prompt() || '';
const time: number = parseFloat(resp);
const G: number = 10.0;
const velocity_mps: number = G * time;
const velocity_kmph: number = velocity_mps * 3.6;
console.log(`A tusfürdő ${velocity_kmph} km/h sebességgel ért földet.`);

console.log("\n");

// #endregion

// --------------------------

// #region 2. FELADAT
// Önálló feladat - Százlábú sebessége
// Ha egy száz lábú százlábú 10 mm/s sebességgel közlekedik és a sebessége a lábai számával
// egyenesen arányos, milyen gyorsan halad egy olyan százlábú, amelynek valamennyi lába leszakadt? 
// A leszakadt lábak számát kérjük be a konzolról.
console.log("Hány lába szakadt le?");
const legs: number = 100 - parseInt(prompt() || '0');
const full_speed: number = 10;
const actual_speed: number = (full_speed / 100) * legs;
console.log(`Ez a ${legs}-lábú ${actual_speed} mm/s sebességgel képes menni.`);

// #endregion

// --------------------------

// #region 3. FELADAT
// Önálló feladat - Vehet-e alkoholt?
// Kérjük be egy illető nevét, ill. születési évét, majd névre szólóan írjuk ki, 
// hogy kiadják-e neki az alkoholt a boltban. A születési hónappal, nappal ne törődjünk.

console.log("Hogy hívnak?");
const na: string = prompt() || '';
console.log("Melyik évben születtél?");
const year: number = parseInt(prompt() || '0');
const adult: boolean = 2020 - year >= 18;
console.log(`${na} kaphat-e a boltban alkoholt: ${adult}`);

console.log("\n");

// #endregion

// --------------------------


// #region 4. FELADAT
// Önálló feladat - Pizza hasznos része
// Kérjük be egy pizza átmérőjét és a pereme szélességét, majd számoljuk ki, hogy a pizza felületének hány százalékán van feltét.
console.log("Hány cm a pizza átmérője?");
const diam: number = parseFloat(prompt() || '0');
console.log("Hány cm széles a pizza pereme?");
const edge: number = parseFloat(prompt() || '0');
const total_area: number = Math.PI * Math.pow(diam / 2, 2);
const filled_area: number = Math.PI * Math.pow((diam / 2) - edge, 2);
const filling_rate: number = (filled_area / total_area) * 100;
console.log(`A pizza ${filling_rate} százalékán van feltét.`);

console.log("\n");

// #endregion

// --------------------------

// #region 5. FELADAT
// Önálló feladat - Jegyzet besatírozás
// Egy ceruzával 4 darab A4-es oldalt lehet besatírozni, mielőtt elfogyna. 
// Kérjünk be egy színt a konzolról, és számoljuk ki, hány ceruza kell ahhoz, 
// hogy teljesen besatírozzuk az Sztf1 jegyzetnek mind a 292 oldalát ezzel a színnel.
console.log("Milyen színű a ceruza?");
const color: string = prompt() || '';
const pencils: number = Math.ceil(292.0 / 4.0);
console.log(`Csak ${pencils} db ceruza kellett hozzá, de az egész jegyzet szép ${color} lett.`);

// #endregion
