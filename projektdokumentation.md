# Projekt-Dokumentation



Waffel - Aeschlimann, Bielski, Bürgi, Bashiri

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | Winforms ausprobieren und Bilder herunterladen |
|       | 0.0.2    |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Unser Programm wird ein Geographie Quiz bei welchem man Hauptstädte, Flaggen, sowie Kontinent erraten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |                 |Funktional| Als ein Benutzer möchte ich das man die Hauptstädte der einzelnen Länder erraten kann |
| 2  |                 |Funktional| Als ein Benutzer möchte ich das man die Länder an ihrem Umriss erraten kann |
| 3  |                 |Funktional| Als ein Benutzer möchte ich das man die Flaggen den jeweiligen Ländern zuordnen kann |
| 4  |                 |Funktional| Als ein Beuntzer möchte ich das man zwischen den einzelen Rätsel auswählen kann |
| 5  |                 |   "   |Als ein benutzer möchte ich, dass man meinen Highscore von Antworten ohne Fehler sehen kann, damit ich mich mit anderen Benutzer Vergleichen kann.|
| 6  |                 |   "   |Als ein Benutzer möchte ich, dass ich ein Timer sehe, damit ich weiss wieviel Zeit ich für die Fragen gebraucht habe|
| 7  |                 |      |Als ein Benutzer möchte ich, dass ich mehrere Schwierigkeitsmodi haben, damit damit ich ein besseres Spiel-Ecperience habe|
| 8  |                 |      | Als ein Benutzer möchte ich, dass ich eine enter Taste habe, damit ich selber auswählen kann wann ich antworte |
| 9  |                 |      |  Als ein Benutzer möchte ich, dass ich                                  |
| 10  |                 |      |                                    |


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Programm gestartet, man kann zwischen die Modi auswählen|  Hauptstadt Modus anklicken    |   Hauptstadt Modus gestartet                |
| 2.1  |Programm gestartet, man kann zwischen die Modi auswählen|  Umriss Modus anklicken      |Umrisss modus gestartet|
| 3.1  |Programm gestartet, man kann zwischen die Modi auswählen|Flaggen Modus anklicken |Flaggen Modus gestartet|
| 4.1  |Programm gestartet|-|Auswahl zwischen den Modi|
| 5.1  |Modus gestartet|richtige Antwort|Highscore= +1|
| 6.1  |Ein Modus ausgewählt und geatrtet|richtige antworte|Timer zählt den Zeit|   
| 7.1  | Modus auswählen | Schwierigkeitsstufe 1       |     Schwierigkeitsstufe 1              |
| 8.1  |Modus ausgewählt, Antwort eingegeben|         Button enter wird angeklickt|    nächste Frage   |
| 9.1  |              |         |                   |
| 10.1 |              |         |                   |
| ...  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.
![Pap](https://i.imgur.com/Dmpsvss.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |8.12.2022||Shahir & Christian|Hauptstätte sammeln|20min|
| 1.B | ----- | --------- | Eingabebox erstellen und eine Datei mit richtigen Antworten erstellen | 45min |
| 1.C | ----- | --------- | Eingabe von User mit Eingabebox vergleichen | 45min |
| 2.A | ----- | --------- |Umrisse Sammeln |20min|
| 2.B | ----- | --------- | Eingabebox erstellen und eine Datei mit richtigen Antworten erstellen| ------------- |
| 2.C | ----- | --------- | Eingabe von User mit Eingabebox vergleichen | 45min  |
| 4.A | 15.12.2022 | --------- | Auswahl der einzelnen Quizes | 45min |
| ---- | ----- | --------- | ------------ | ------------- |
| 2.A  |8.12.2022|Kamil |Auswahl|1h| 
| 3.A  |15.12.2022| Kamil | Erstellt selber fragen| 1h|
| 4.A  |15.12.2022| Christian & Shahir| Auswahl der einzelnen Quizes | 1h | 
die drei unteren paketen werden umgeschrieben

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Wir haben und dazu entschieden mehere verschiedene Rätsel zu machen antstatt eins ausgibig zu Programmieren da man mehere besser in der Gruppe aufteilen kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
