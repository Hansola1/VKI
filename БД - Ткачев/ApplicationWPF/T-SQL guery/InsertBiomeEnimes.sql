USE BorodinaAV_2207d2

INSERT INTO Locations (biome, level, description) VALUES
('Forest', 1, 'A dense forest filled with ancient trees and wildlife.'),
('Cave', 2, 'A dark and damp cave inhabited by various creatures.'),
('Desert', 3, 'A vast desert with scorching heat and hidden dangers.'),
('Mountain', 4, 'A high mountain range with treacherous paths and snow.'),
('Swamp', 2, 'A murky swamp full of dangerous creatures and quicksand.');

INSERT INTO Enemies (locationID, name, level) VALUES
(1, 'Forest Goblin', 1),
(1, 'Wild Boar', 2),
(2, 'Cave Bat', 2),
(2, 'Stone Golem', 4),
(3, 'Sand Scorpion', 3),
(3, 'Desert Bandit', 3),
(4, 'Mountain Troll', 4),
(4, 'Snow Leopard', 3),
(5, 'Swamp Witch', 2),
(5, 'Swamp Beast', 3);
