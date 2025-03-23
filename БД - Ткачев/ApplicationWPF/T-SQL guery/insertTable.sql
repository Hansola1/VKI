USE BorodinaAV_2207d2;

INSERT INTO Characters (userID, species, name, level, class) VALUES
(1, 'stealth', 'Hani', 5, 'Warrior'),
(2, 'speed', 'Pipo', 3, 'Archer'),
(3, 'health', 'Lilo', 4, 'Tank');

INSERT INTO Class (title, description, mainFeatures) VALUES
('Warrior', 'Strong and resilient', 'Powerful attacks'),
('Archer', 'Fast and agile', 'Ranged attacks'),
('Tank', 'High defense', 'Damage mitigation');

INSERT INTO List (classID, characterID) VALUES
(1, 1),
(2, 2),
(3, 3);

INSERT INTO Inventory (characterID, objectID, force, title) VALUES
(1, 'bow01', 10, 'Bow'),
(2, 'sword01', 15, 'Sword'),
(3, 'axe01', 12, 'Axe');

INSERT INTO Skills (description, effect, force, classID) VALUES
('Sword Strike', 5, 10, 1),
('Arrow Shot', 7, 15, 2),
('Block', 10, 20, 3);

INSERT INTO Locations (biome, level, description) VALUES
('Forest', 1, 'Quiet and peaceful'),
('Mountains', 2, 'High cliffs and valleys'),
('Desert', 3, 'Hot and barren land'); 

INSERT INTO Quests (description, locationID, level, type) VALUES
('Kill 50 enemies', 1, 1, 'Main'),
('Collect 10 artifacts', 2, 2, 'Side'),
('Save the village', 3, 3, 'Main');

INSERT INTO NPCs (name, locationID) VALUES
('Old Sage', 1),
('Merchant on the road', 2),
('Village Guard', 3);

INSERT INTO Enemies (locationID, name, level) VALUES
(1, 'Forest Wolf', 2),
(2, 'Mountain Troll', 4),
(3, 'Desert Bandit', 5);
