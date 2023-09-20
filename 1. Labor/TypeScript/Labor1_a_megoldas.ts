// #region 1. FELADAT
// Konzolra kiírás
console.log('Hello World!');
console.log('Hello World Again!');

// #endregion

// --------------------------

// #region 2. FELADAT
// Kérjünk be valamit a felhasználótól és irjuk is ki azt
const n: string = prompt('Name: ') || '';
console.log(`Hello ${n}`);

// #endregion

// --------------------------

// #region 3. FELADAT
// Kérjünk be egy számot, majd szorozzuk be egy a felhasználótól bekért számmal
const number1: number = parseInt(prompt('Number 1: ') || '0');
const number2: number = parseInt(prompt('Number 2: ') || '0');
console.log(number1 * number2);

// #endregion

// --------------------------

// #region 4. FELADAT
// stringgé alakítása / Parse-olás / kasztolás
// string
const x: string = number1.toString();

// int
const y: string = "4";
const z: number = parseInt(y);

// kasztolás
const valtozo: number = 255; // byte: 0-255
const masikValtozo: number = valtozo;

// #endregion

// --------------------------

// #region 5. FELADAT
// Téglalap a és b oldalát bekérni, eltárolni egy-egy változóban
// majd a területét és kerületét kiszámolni és kiírni a következő formában:
// "Kerület={változó} [tabulátor] terület={változó}."

const aOldal: number = parseInt(prompt("Add meg az 'a' oldalt: ") || '0');
const bOldal: number = parseInt(prompt("Add meg az 'b' oldalt: ") || '0');

// kerület: (a+b)*2
const kerulet: number = (aOldal + bOldal) * 2;

// terület: a*b
const terulet: number = aOldal * bOldal;

console.log(`Kerület=${kerulet} \t Terület=${terulet}`);

// #endregion
