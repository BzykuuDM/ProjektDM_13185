/*Administracja*/
INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Administracja', 'Kierownik działu', 10000);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Administracja', 'Menedżer', 7500);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Administracja', 'Pracownik biurowy', 3800);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Administracja', 'Wsparcie wewnętrzne', 4200);


/*Wsparcie klienta*/
INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Obsługa klienta', 'Kierownik działu', 9000);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Obsługa klienta', 'Menedżer', 6800);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Obsługa klienta', 'Wsparcie klienta', 3100);


/*Transport*/
INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Transport', 'Kierownik działu', 9000);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Transport', 'Menedżer', 6800);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Transport', 'Kierowca', 4000);

INSERT INTO Dzial (dzial, stanowisko, wyplata)
	VALUES ('Transport', 'Pracownik magazynowy', 3200);

SELECT * FROM Dzial;


/*DNI URLOPOWE*/

INSERT INTO Dni_urlopowe (dni_url)
VALUES (1);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (2);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (3);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (4);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (5);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (6);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (7);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (8);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (9);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (10);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (11);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (12);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (13);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (14);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (15);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (16);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (17);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (18);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (19);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (20);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (21);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (22);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (23);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (24);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (25);
INSERT INTO Dni_urlopowe (dni_url)
VALUES (26);

SELECT * FROM Dni_urlopowe;

/* KRAJ */

INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Polska');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Ukraina');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Białoruś');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Węgry');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Czechy');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Niemcy');
INSERT INTO Kraj_pochodzenia (kraj)
VALUES ('Francja');

SELECT * FROM Kraj_pochodzenia;