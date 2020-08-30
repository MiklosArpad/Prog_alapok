-- 1. feladat:

CREATE DATABASE TorpeTarna
CHARACTER SET UTF8 COLLATE utf8_hungarian_ci

-- 3. feladat:

ALTER TABLE `kihol` ADD FOREIGN KEY (`torpe_id`) REFERENCES `torpek`(`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE `kihol` ADD FOREIGN KEY (`tarna_id`) REFERENCES `tarnak`(`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE `tarnak` ADD FOREIGN KEY (`kozet_id`) REFERENCES `kozetek`(`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

-- 4. feladat:

SELECT nev, magassag 
FROM torpek
ORDER BY magassag DESC LIMIT 1

-- 5. feladat:

SELECT COUNT(torpe_id) AS "Gir Lorduban dolgozó törpék száma" FROM kihol, tarnak
WHERE tarna_id = tarnak.id AND tarnak.nev LIKE "Gir Lodur"

-- 6. feladat:

SELECT tarnak.nev, SUM(kihol.kitermelt_mennyiseg) AS aranymennyiseg
FROM tarnak, kihol, kozetek
WHERE kihol.tarna_id = tarnak.id AND tarnak.kozet_id = kozetek.id AND kozetek.nev = "arany"
GROUP BY tarnak.nev
ORDER BY aranymennyiseg DESC


-- 7. feladat:

SELECT torpek.nev
FROM torpek, kihol
WHERE torpek.nem LIKE 'N' AND klan LIKE 'Vasököl' AND kihol.torpe_id = torpek.id
GROUP BY torpek.nev
ORDER by SUM(kihol.kitermelt_mennyiseg) DESC LIMIT 1


-- 8. feladat:

INSERT INTO torpek (nev, klan, nem, suly, magassag)
VALUES ('Trad Morf', 'Vasököl', 'F', 69, 136)

-- 9. feladat:

INSERT INTO kihol (torpe_id, tarna_id, kitermelt_mennyiseg)
VALUES (
    		(SELECT torpek.id FROM torpek WHERE torpek.nev LIKE "Trad Morf"),
    		(SELECT tarnak.id FROM tarnak WHERE tarnak.nev LIKE 'Gir Lodur'),
    		43
    )
	
INSERT INTO kihol (torpe_id, tarna_id, kitermelt_mennyiseg)
VALUES 
	(
        (SELECT torpek.id FROM torpek WHERE torpek.nev LIKE 'Trad Morf'),
        (SELECT tarnak.id FROM tarnak WHERE tarnak.nev LIKE 'Moldirth'),
        28
	)
	
