/* 1. feladat*/

CREATE DATABASE verseny CHARACTER SET utf8 COLLATE utf8_hungarian_ci

/* 3. feladat*/
SELECT nev FROM `versenyzo` ORDER BY eletkor DESC 

/* 4. feladat*/

SELECT COUNT(*) AS palyak_szama FROM `palya` 
/* 5. feladat*/

SELECT csapat.nev AS csapat, versenyzo.nev AS versenyzo
FROM versenyzo, csapat
WHERE versenyzo.csapatid = csapat.id AND csapat.nev LIKE '%z%'
ORDER BY csapat

/* 6. feladat*/
SELECT palya.nev AS "palyanev", versenyzo.nev AS "versenyzonev", korido.korido AS "korido"
FROM korido, palya, versenyzo
WHERE palya.id = korido.palyaid AND versenyzo.id = korido.versenyzoid AND palya.orszag = "Olaszország"
AND korido.kor = 1
