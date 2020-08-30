/* 1. feladat:  */

CREATE DATABASE monthypyton CHARACTER SET utf8 COLLATE utf8_hungarian_ci

/* 3. feladat:  */

SELECT nev FROM `epizodok` WHERE epizodok.sorozat = "1/5" 

/* 4. feladat:  */

SELECT COUNT(*) AS "epizódok száma" FROM `epizodok` 

/* 5. feladat:  */

SELECT DISTINCT(forgatokonyv.szinesz) FROM forgatokonyv WHERE forgatokonyv.szinesz IS NOT NULL ORDER BY forgatokonyv.szinesz ASC 

/* 6. feladat:  */

SELECT reszletek FROM `forgatokonyv` WHERE szinesz LIKE "John Cleese" AND resz = "Italian lesson" 

/* 7. feladat:  */

SELECT szinesz, COUNT(*) AS bejegyzesek_szama FROM `forgatokonyv` WHERE szinesz IS NOT NULL GROUP BY szinesz ORDER BY bejegyzesek_szama DESC LIMIT 1 