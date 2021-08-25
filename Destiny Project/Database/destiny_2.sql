USE master
GO

--drop database if it exists
IF DB_ID('destiny_2') IS NOT NULL
BEGIN
	ALTER DATABASE destiny_2 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE destiny_2;
END

CREATE DATABASE destiny_2
GO

USE destiny_2
GO

--create tables
CREATE TABLE rarity (
	rarity_id int IDENTITY(1,1) NOT NULL,
	rarity_name varchar(50) NOT NULL,
	CONSTRAINT PK_rarity_id PRIMARY KEY (rarity_id),
)

CREATE TABLE weapon_type (
	weapon_type_id int IDENTITY(1,1) NOT NULL,
	weapon_type_name varchar(50) NOT NULL,
	CONSTRAINT PK_weapon_type_id PRIMARY KEY (weapon_type_id),
)

CREATE TABLE slot_ammo (
	slot_ammo_id int IDENTITY(1,1) NOT NULL,
	slot_name varchar(50) NOT NULL,
	ammo_name varchar(50) NOT NULL,
	CONSTRAINT PK_slot_ammo_id PRIMARY KEY (slot_ammo_id),
)

CREATE TABLE damage_type (
	damage_type_id int IDENTITY(1,1) NOT NULL,
	damage_type_name varchar(50)  NOT NULL,
	CONSTRAINT PK_damage_type_id PRIMARY KEY (damage_type_id),
)

CREATE TABLE guns (
	gun_id int IDENTITY(1,1) NOT NULL,
	gun_name varchar(50) NOT NULL,
	rarity int NOT NULL,
	weapon_type int NOT NULL,
	slot int NOT NULL,
	ammo int NOT NULL,
	damage_type int NULL,
	CONSTRAINT PK_gun_id PRIMARY KEY (gun_id),
	CONSTRAINT FK_rarity_id FOREIGN KEY (rarity) REFERENCES rarity (rarity_id),
	CONSTRAINT FK_weapon_type_id FOREIGN KEY (weapon_type) REFERENCES weapon_type (weapon_type_id),
	CONSTRAINT FK_slot_id FOREIGN KEY (slot) REFERENCES slot_ammo (slot_ammo_id),
	CONSTRAINT FK_ammo_id FOREIGN KEY (ammo) REFERENCES slot_ammo (slot_ammo_id),
	CONSTRAINT FK_damage_type_id FOREIGN KEY (damage_type) REFERENCES damage_type (damage_type_id),
)

CREATE TABLE gun_stats (
	gun_stats_id int IDENTITY(1,1) NOT NULL,
	gun_id int NOT NULL,
	impact int NOT NULL,
	range int NOT NULL,
	stability int NOT NULL,
	handling int NOT NULL,
	reload_speed int NOT NULL,
	rounds_per_minute int NOT NULL,
	magazine_size int NOT NULL,
	exotic_perk varchar(1000) NULL,
	CONSTRAINT PK_gun_stats_id PRIMARY KEY (gun_stats_id),
	CONSTRAINT FK_gun_id FOREIGN KEY (gun_id) REFERENCES guns (gun_id),
)

--populate default data for rarity
INSERT INTO rarity (rarity_name) VALUES ('Exotic'), ('Legendary'), ('Rare'), ('Common'), ('Basic')

--populate default data for weapon_type
INSERT INTO weapon_type(weapon_type_name) VALUES ('Auto Rifle'), ('Scout Rifle'), ('Pulse Rifle'), ('Hand Cannon'), ('Bow'), ('Sidearm'), ('Submachine Gun'), ('Sniper Rifle'), ('Shotgun'), ('Fusion Rifle'), ('Grenade Launcher'), ('Machine Gun'), ('Rocket Launcher'), ('Sword')

--populate default data for slot_ammo
INSERT INTO slot_ammo(slot_name, ammo_name) VALUES ('Kinetic', 'Primary'), ('Energy', 'Special'), ('Power', 'Heavy')

--populate default data for damage_type
INSERT INTO damage_type(damage_type_name) VALUES ('Arc'), ('Solar'), ('Void'), ('Stasis')

--populate default data for guns
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Cerebus+1', 1, 1, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Monte Carlo', 1, 1, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('SUROS Regime', 1, 1, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Sweet Business', 1, 1, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Hard Light', 1, 1, 2, 1, 3)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Tommy''s Matchbook', 1, 1, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Dead Mans''s Tale', 1, 2, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('MIDA Multi-Tool', 1, 2, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('The Jade Rabbit', 1, 2, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Polaris Lance', 1, 2, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Skyburner''s Oath', 1, 2, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Symmetry', 1, 2, 2, 1, 1)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Bad Juju', 1, 3, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('No Time To Explain', 1, 3, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Outbreak Perfected', 1, 3, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Vigilance Wing', 1, 3, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Graviton Lance', 1, 3, 2, 1, 3)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Ace of Spades', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Crimson', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Hawkmoon', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Lumina', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Malfeasance', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Sturm', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('The Last Word', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Thorn', 1, 4, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Eriana''s Vow', 1, 4, 2, 2, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Sunshot', 1, 4, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Wish-Ender', 1, 5, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Le Monarque', 1, 5, 2, 1, 3)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Ticuu''s Divination', 1, 5, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Trinity Ghoul', 1, 5, 2, 1, 1)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Leviathans''s Breath', 1, 5, 3, 3, 3)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Cryosthesia 77K', 1, 6, 1, 1, 4)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Rat King', 1, 6, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Traveler''s Chosen', 1, 6, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Devil''s Ruin', 1, 6, 2, 1, 2)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('The Huckleberry', 1, 7, 1, 1, NULL)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Riskrunner', 1, 7, 2, 1, 1)
INSERT INTO guns(gun_name, rarity, weapon_type, slot, ammo, damage_type) VALUES ('Tarrabah', 1, 7, 2, 1, 2)

--populate default data for stats
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (1,33,10,32,39,42,360,31,'Shoots erratic bullets from all gun barrels at the same time.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (2,21,50,60,64,81,600,43,'Dealing damage with this weapon reduces your melee cooldown and grants a chance to fully charge your melee ability with each kill.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (3,21,50,49,68,67,600,25,'The bottom half of each magazine deals bonus damage and has a chance to return health on kill.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (4,18,37,46,10,10,360,45,'Larger magazine. Increased accuracy when firing from the hip. Picking up ammo for this weapon immediately reloads it.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (5,21,46,68,75,68,600,49,'Rounds fired from this weapon have reduced damage falloff, overpenetrate targets, and ricochet off hard surfaces. Projectile damage increases after bounce.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (6,18,49,50,62,28,720,72,'Sustained fire with this weapon overheats it, increasing damage but burning the user.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (7,67,64,37,55,55,120,14,'Chaining precision hits grants bonus damage and quickens reload speed.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (8,60,42,37,82,82,200,16,'This weapon boosts move speed. Radar stays active while aiming down sights.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (9,67,82,46,29,59,150,10,'Chain body shots to gain bonus damage on your next precision shot and return ammo to the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (10,67,73,55,36,40,150,14,'Precision hits return ammo to the mag. Landing 4 precision hits loads a delayed Solar explosive round for your next shot.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (11,60,46,55,64,55,200,15,'This weapon lobs large, explosive, seeking slugs when you''re firing from the hip. When you''re aiming down sights, the slugs travel fast and straight, with higher damage and a lower rate of fire. This weapon is Full Auto, does extra damage to Cabal, and penetrates Phalanx shields.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (12,45,28,54,38,24,260,20,'[Alternate Weapon Action] : Swap to Arc Seeker mode. Arc Seekers track toward combatants you target. Precision hits build up Dynamic Charge. Swapping to Arc Seeker mode increases damage and partially reloads the magazine based on the number of charges.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (13,27,42,66,47,52,450,27,'Kills refill the magazine, increase damage for a short duration, and grant Super energy based on the strength of String of Curses. Fires full-auto.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (14,33,73,60,48,64,340,24,'Precision shots and shots against combatants slowed or frozen by Stasis will return to the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (15,27,50,43,50,50,450,34,'This weapon creates SIVA nanite swarms on rapid hits and precision kills.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (16,33,64,64,40,46,530,30,'This weapon fires a 5-round burst. When a nearby ally is killed, gain health regeneration and increased movement speed. Improved weapon performance and greatly increased recovery when its wielder is the last living member of a fireteam.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (17,29,55,100,59,61,257,31,'Second shot of a burst rips a hole through space-time, doing high damage and recoil with no falloff. Kills with this weapon cause enemy targets to detonate and spawn Void projectiles that track targets')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (18,84,78,46,46,48,140,13,'Reloading after a kill loads magazine with a few extra-damage bullets. Grants radar while aiming down sights.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (19,92,60,82,50,64,415,14,'This weapon fires a 3-round burst. Kills with this weapon heal the wielder. Precision kills also refill the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (20,78,57,67,74,63,140,8,'Final blows and precision hits with Hawkmoon grant stacks of Paracausal Charge. The final round in the magazine deals bonus damage based on the number of stacks. Stowing Hawkmoon on the final round removes this bonus.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (21,84,44,46,74,65,140,13,'Kills with this weapon leave behind Remnants. Absorbing a Remnant converts your next hipfired shot into an ally-seeking Noble Round and partially refills the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (22,78,46,82,36,82,180,14,'Shoot tainted slugs that burrow into the enemy. Stacking enough slugs causes them all to explode. Bonus damage against Taken enemies and Gambit invaders.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (23,92,64,56,46,55,120,9,'Kills with this weapon fill the magazine of the equipped Energy weapon from reserves.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (24,78,28,46,28,82,225,8,'This weapon fires full auto. Hip-fire shots deal bonus precision damage while increasing reload speed and accuracy.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (25,84,41,60,68,46,140,11,'Rounds pierce targets and deal damage over time. Kills with this weapon leave behind Remnants. Absorbing a Remnant strengthens Mark of the Devourer and partially refills the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (26,100,100,37,31,32,90,6,'Bonus damage when aiming down sights on the opening shot of an attack. This bonus is preserved if the shot deals precision damage or strikes an elemental shield. This weapon fires special shield-piercing ammunition. It comes with a scope. Strong against [Shield-Piercing] Barrier Champions.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (27,80,38,46,83,75,150,12,'This weapon fires explosive rounds and highlights targets that take damage from Sunshot. Targets killed with Sunshot explode in Solar energy.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (28,92,72,91,46,37,792,1,'While aiming down sights with a fully-drawn bow, enemies behind walls are highlighted.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (29,76,81,51,59,46,684,1,'Arrows fired quickly after a full draw become poison arrows. Precision hits with poison arrows spread poison to nearby enemies.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (30,68,52,57,69,64,612,1,'Hipfiring this weapon fires multiple tracking projectiles. Targets marked by these projectiles explode upon death, or when struck by another Sacred Flame''s explosion.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (31,80,86,55,58,55,720,1,'Fires an arrow that splits when released. Aiming down sights and fully drawing the bow both decrease the spread. Precision kills grant the next shot chain-lightning capabilities.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (32,60,75,10,10,10,1328,1,'Fires a massive heavy bolt that stuns unshielded combatants. Strong against [Stagger] Unstoppable Champions. When fully drawn, the bolt creates a large concussive blast that knocks combatants back.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (33,51,75,47,43,42,260,12,'Variable Trigger: Press and release to fire individual shots. Hold to fire a Charged Shot when Liquid Cooling is active.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (34,49,37,46,46,46,300,15,'This fully automatic weapon becomes stronger when nearby allies also have it equipped. Stacks up to 6 times.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (35,49,82,68,59,46,300,15,'Final blows with this weapon grant stacks of Gathering Light. [Alternate Weapon Action] : Consume stacks, granting melee, grenade, and class ability energy based on the number of stacks.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (36,49,46,68,54,24,300,15,'Charge Time 1000. Variable trigger. Press and release to fire individual shots. Hold to charge up a high-powered, [Stagger] stunning laser. Strong against Unstoppable Champions.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (37,22,53,42,60,10,750,37,'Increased rate of fire and recoil while you'' holding down the trigger. Kills with this weapon reload a portion of the magazine.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (38,20,55,60,51,42,900,37,'When taking Arc Damage, this weapon becomes more powerful and resists incoming Arc Damage. Kills extend the time in this overcharged state.')
INSERT INTO gun_stats(gun_id, impact, range, stability, handling, reload_speed, rounds_per_minute, magazine_size, exotic_perk) VALUES (39,22,49,28,55,42,750,31,'This weapon stores power when dealing or receiving damage. [Alternate Weapon Action] : Unleashes the beast when full.')