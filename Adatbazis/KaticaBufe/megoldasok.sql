/* 1. feladat:  */
CREATE DATABASE katica CHARACTER SET utf8 COLLATE utf8_hungarian_ci
/* 3. feladat:  */
ALTER TABLE `kategoria` ADD PRIMARY KEY( `id`); 
/* 4. feladat:  */
ALTER TABLE `forgalom` ADD FOREIGN KEY (`kategoriaId`) REFERENCES `kategoria`(`id`) ON DELETE NO ACTION ON UPDATE NO ACTION; 
/* 6. feladat:  */
INSERT INTO kategoria (id, kategoriaNev) VALUES (3, 'Ajándéktárgyak') 
/* 7. feladat:  */
UPDATE forgalom SET termek = "Gyros tál" WHERE termek = "Gyrostál"
/* 8. feladat:  */
SELECT forgalom.termek, forgalom.vevo
FROM forgalom
WHERE kiadva LIKE 0
ORDER BY vevo
/* 9. feladat:  */
SELECT kategoria.kategoriaNev , SUM(forgalom.nettoar * forgalom.mennyiseg) AS "Nettó bevétel",
SUM(forgalom.nettoar * forgalom.mennyiseg) * 0.27 AS "Forgalmi adó"
FROM forgalom, kategoria
WHERE forgalom.kategoriaId = kategoria.id
GROUP BY kategoria.kategoriaNev
