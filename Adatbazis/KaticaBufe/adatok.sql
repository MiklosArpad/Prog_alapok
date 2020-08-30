USE katica;

INSERT INTO kategoria(id, kategoriaNev) VALUES
  (1, 'Ételek'),
  (2, 'Italok');

INSERT INTO forgalom(id, termek, vevo, kategoriaId, egyseg, nettoar, mennyiseg, kiadva) VALUES
(246, 'Sajtos hot-dog', 'Lajos', 1, 'db', 450, 2, TRUE),
(247, 'Limonádé', 'Lajos', 2, 'dl', 100, 5, TRUE),
(248, 'Gyrostál', 'Kinga', 1, 'db', 1500, 1, TRUE),
(249, 'Ízes palacsinta', 'Kinga', 1, 'db', 350, 2, TRUE),
(250, 'Túros palacsinta', 'Kinga', 1, 'db', 270, 1, TRUE),
(251, 'Narancslé', 'Kinga', 2, 'dl', 150, 3, TRUE),
(252, 'Főtt virsli', 'Jenő', 1, 'pár', 450, 2, FALSE),
(253, 'Kenyér', 'Jenő', 1, 'szelet', 60, 2, TRUE),
(254, 'Gyrostál', 'Ági', 1, 'db', 1500, 3, FALSE),
(255, 'Málnaszörp', 'Ági', 2, 'dl', 100, 10, FALSE),
(256, 'Sajtos hot-dog', 'Lajos', 2, 'db', 450, 2, FALSE),
(257, 'Málnaszörp', 'Lajos', 2, 'dl', 100, 3, FALSE),
(258, 'Gyrostál', 'Jenő', 1, 'db', 1500, 1, FALSE);