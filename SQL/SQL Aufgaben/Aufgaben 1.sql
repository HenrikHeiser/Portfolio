/*
SQL-Stoff. --- Abfragen mit SELECT ---
*/
## Um alle Aufgaben bearbeiten zu können, importieren Sie bitte die Datenbanken:
## world, sakila, personal, flowerpower
## Arbeiten Sie länger mit einer DB, dann setzen Sie diese als Default (Rechtklick auf DB).


##### Ganze Tabellen ausgeben.
-- Select * from [Tabelle]
-- Bsp: 
-- Geben Sie alle Informationen (alle Spalten) der Tabelle 'city' aus.
select * from city;

-- Aufgaben:
-- Geben Sie alle Inhalte der Tabellen aus der DB world aus. Verwenden Sie einzelne SQL-Statements.
select * from world;

##### Nur die Spalten ausgeben, die interessieren (Ressoucen schonen)
-- Select [Spaltenname], [Spaltenname], ... from [Tabelle]
-- Bsp:
-- Geben Sie alle Länder und deren Kontinente aus.
select  name, Continent from country;

-- Aufgaben:
-- Geben Sie ID, Name und Vorname aller Mitarbeiter der DB personal aus.
select ID, Name, Vorname from personal;

-- Von wann bis wann blühen welche Pflanzen? Bitte Pflanze, Blühbeginn und Blühende ausgeben. DB flowerpower.


##### Ausgabe sortieren, begrenzen
-- order by, asc, desc, limit x
-- Bsp:
-- Geben Sie alle Länder der Erde nach Namen sortiert, aufsteigend aus. 
select  name from country order by name;
-- oder optional mit 'asc', ist aber immer default.

-- Aufgabe
-- Geben Sie alle Länder der Erde nach Namen absteigend sortiert aus. Angabe von 'desc' zwingend notwendig.
select name from country order by name desc;
-- Aufgabe
-- Sortieren Sie obige Tabelle zuerst nach Kontinent und dann nach Name.
select Continent, name from world order by Continent, Name;

##### Formatierte Ausgabe date_format('tt-mm-jj' oder 'tt/mm/jj')
-- 1.5	Arbeiten mit Datum und Zeitwerten:
-- Informieren Sie sich unter http://www.w3schools.com über die unten gezeigten Konvertierungsfunktionen.
-- now =Systemzeit
-- DAY(<Datum>)
-- WEEKDAY (<Datum >)
-- MONTH (<Datum >)
-- YEAR(<Datum >)
-- Welche Funktion übernimmt das Schlüsselwort AS (Alias)? Betrachten Sie hierzu den Spaltenname der SQL-Ausgabe in den folgenden Aufgaben.

-- Aufgabe
-- Geben Sie die Eintritts-Jahre aller Mitarbeiter aus.


-- Aufgabe
-- Geben Sie das Eintrittsjahr im Format tag.monat.jahr aus.



-- Bsp
-- Geben Sie der Ausgabespalte für das Eintrittsjahr einen aussagekräftigen Namen.
select *, year(eintrittsdatum) as Eintrittsjahr from tblpersonal;



##### Bedingungen für die Auswahl, Auswahl eingrenzen mit WHERE.
-- Select ... WHERE ... mit
-- Bedingungen: is, =, not, <, >, like, 'text', <> (ungleich), NULL als Wert
-- Verknüpfungen: AND, OR, in (entspricht ODER), between ... AND ...

-- Bsp für =, < und >:
-- In welchen Städten der Welt leben mehr als 7 Mio. Einwohner? Ordnen Sie die Ausgabe absteigend.
select * from city where population > 7000000 order by population desc;

/*Virus!!! --> SQL-Code-Injection*/
/*select * from users where status = 'admin';*/

--Aufgabe
-- Welche Pflanzen bleiben kleiner als 2,5m?


--Aufgabe:
-- Stellen Sie alle Personalinformationen von Herrn Frau Abele dar.


-- Bsp für NULL-Wert:
-- Welcher Angesteller hat keine Telefonnummer?
Select * from tblpersonal where isnull(Tel);
Select * from tblpersonal where Tel is NULL;

-- Aufgabe:
-- Welche Mitarbeiter sind keiner Abteilung zugeordnet?


-- Aufgabe
-- Geben Sie die Mitarbeiter aus, die einer Abteilung zugeordnet sind. (not null)


-- Aufgabe
-- Von welchen Ländern ist das Unabhängigkeitsjahr unbekannt (null)?


-- like --> Mustersuche
-- Bsp:
-- Gibt es einen Schauspieler mit den Buchstaben 'ivi' im Nachnamen?
SELECT * FROM sakila.actor where last_name like '%ivi%';


-- Bsp:
-- Gibt es einen Schauspieler dessen Vorname auf 'er' endet?
SELECT * FROM sakila.actor where first_name like '%er';

-- Aufgabe
-- Suchen Sie unter http://www.w3schools.com weitere Informationen für "wildcards".
-- Wildcards: '_' , '%'

-- Aufgabe:
-- Welche Bedeutung hat das '_' / '%'? Geben Sie ein Beispiel.
-- 

-- Aufgabe:
-- Suchen nach Namen, die mit dem Buchstaben B beginnen.


-- Aufgabe:
-- Welche Schauspieler haben ein "e" an dritter Stelle im Nachnamen?



------------------- AND
-- Beispiel: Verwendung von AND
-- In welchen Ländern (Ländercode ausgeben) ist Spanisch die offizielle Amtssprache?*/
select
	countrycode,
    language,
    isofficial
from countrylanguage
where
	language = 'spanish'
	AND
	isofficial = 'T'
;
-- Aufgabe
-- Welche Mitarbeiterinnen wurden nach dem 1.1.1990 eingestellt UND
-- haben ein Grundgehalt von mehr als 2000 €?




-- Bsp:
-- Welche Pflanzen können Sie einem Kunden empfehlen, der Pflanzen sucht,
-- die zwischen 1m und 1,5m groß sind?
select * from pflanze where phöhe between 125 and 150; -- Grenzen inclusive
select * from pflanze where 100 <= phöhe AND phöhe <= 150;



-- Aufgabe
-- Bei welchen Mitarbeitern liegt das Grundgehalt zwischen 2500 und 3000 €?



-- Bsp
-- Welche Mitarbeiter verdienen genau 2000, 2500 und 2900 €?
select * from tblpersonal where grundgehalt in (2000, 2500, 2900);

-- Aufgabe
-- Welche Pflanzen blühen weiß oder blau oder rot?



-- Aufgabe
-- Welche Mitarbeiter wurden 1988 oder 1990 oder 1993 eingestellt?






-- Aufgabe
-- Wie heißen die Abteilungsleiter?
-- (Oder: Welche IDs in der tblpersonal passen zu den IDs der Abteilungsleiter in der Tabelle tblabtleiter?)


################################################## Einzelwerte berechnen
-- Funktionen min, max avg, count

-- Aufgabe:
-- Wieviele Datensätze befinden sich in der Tabelle world.city?


-- Aufgabe
-- Warum zeigt Workbench nur die ersten 1000 Rows an?
-- Geben Sie nur die ersten 10 Datensätze der Tabelle world.city aus.

-- Aufgabe "Paging"
-- Wie realisieren Webseiten die Ansicht von vielen Artikeln? 
-- Untersuchen Sie das SQL-Schlüsselwort OFFSET.


-- Aufgabe:
-- Von wievielen Ländern ist die Lebenserwartung unbekannt?
-- Überprüfen Sie das Ergebnis.



-- Aufgabe
-- Wie hoch ist der Maximalsverdienst eines Mitarbeiters? Wie hoch der Minimalsverdienst?
-- Führen Sie die Ergebnisse in einem Ergebnis zusammen? -> UNION

-- Aufgabe
-- Um wen handelt es sich dabei?


-- Aufgabe
-- Wie hoch ist das durchschnittliche Grundgehalt?


-- Aufgabe
-- Wie hoch ist der durchschnittliche Preis der Pflanzen?



################################# Rechnen im SQL-Statement
-- Bsp:
-- Wie hoch wären die Grundgehälter der einzelnen Mitarbeiter, wenn jeder eine Gehaltserhöhung von 7,3% bekäme?

-- Aufgabe
-- Stellen Sie die Summe aller Gehälter ohne und mit Gehaltserhöhung, sowie deren Differenz dar.

-- Aufgabe
-- Wie lange sind die Mitarbeiter schon im Betrieb?


