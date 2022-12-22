# Projekt-Dokumentation



Waffel - Aeschlimann, Bielski, Bashiri

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|1.12| 0.0.1   | Winforms ausprobieren und Bilder herunterladen |
|8.12| 0.0.2    | Projektdokumentation überarbeitet, Unterprogramme aufgeteilt |
|15.12| 1.0.0   |Teilprogramm fertiggestellt|

## 1 Informieren

### 1.1 Ihr Projekt

Unser Programm wird ein Geographie Quiz bei welchem man Hauptstädte, Flaggen, sowie Kontinent erraten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |Muss|NF| Als ein Benutzer möchte ich das man die Hauptstädte der einzelnen Länder erraten kann |
| 2  |Muss|NF| Als ein Benutzer möchte ich das man die Länder an ihrem Umriss erraten kann |
| 3  |Muss|NF| Als ein Benutzer möchte ich das man die Flaggen den jeweiligen Ländern zuordnen kann |
| 4  |Muss|NF| Als ein Beuntzer möchte ich das man zwischen den einzelen Rätsel auswählen kann |
| 5  |Kann|F|Als ein benutzer möchte ich, dass man meinen Highscore von Antworten ohne Fehler sehen kann, damit ich mich mit anderen Benutzer Vergleichen kann.|
| 6  |Kann|F|Als ein Benutzer möchte ich, dass ich ein Timer sehe, damit ich weiss wieviel Zeit ich für die Fragen gebraucht habe|
| 7  |Kann|F|Als ein Benutzer möchte ich, dass ich mehrere Schwierigkeitsmodi haben, damit damit ich ein besseres Spiel-Ecperience habe|
| 8  |Kann|F| Als ein Benutzer möchte ich, dass ich eine enter Taste habe, damit ich selber auswählen kann wann ich antworte |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Programm gestartet, man kann zwischen die Modi auswählen|  Hauptstadt Modus anklicken    |   Hauptstadt Modus gestartet                |
| 2.1  |Programm gestartet, man kann zwischen die Modi auswählen|  Umriss Modus anklicken      |Umrisss modus gestartet|
| 3.1  |Programm gestartet, man kann zwischen die Modi auswählen|Flaggen Modus anklicken |Flaggen Modus gestartet|
| 4.1  |Programm gestartet|-|Auswahl zwischen den Modi| Auswahl ist anklickbar |
| 5.1  |Modus gestartet|richtige Antwort|Highscore= +1|
| 6.1  |Ein Modus ausgewählt und gestartet|richtige antworte|Timer zählt die Zeit|   
| 7.1  | Modus auswählen | Schwierigkeitsstufe 1       |     Schwierigkeitsstufe 1              |
| 8.1  |Modus ausgewählt, Antwort eingegeben|         Button enter wird angeklickt|    nächste Frage   |

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.
![Pap](https://i.imgur.com/Dmpsvss.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1 | 01.12 | Alle | WinForms kennenlernen | 45min |
| 2 | 01.12 | Shahir | Flaggen raussuchen | 30min |
| 3 | 01.12 | Christian | Länderliste erstellen | 30min |
| 4 | 01.12 | Kamil | Länderumriss raussuchen | 30min |
| 5 | 08.12 | Christian | Flaggenquiz starten | 120min |
| 6 | 08.12 | Shahir | Hauptstädte starten | 120min |
| 7 | 08.12 | Kamil | Kontinente starten | 120min |
| 8 | 08.12 | Christian | Quiz auswahl | 45min |
| 9 | 08.12 | Shahir | Score | 45min |
| 10 | 08.12 | Kamil | Leaderbord | 45min |
| 11 | 15.12 | Christian | Flaggenquiz fertig | 120min |
| 12 | 15.12 | Shahir | Hauptstädte fertig | 120min |
| 13 | 15.12 | Kamil | Kontinente fertig | 120min |
| 14 | 15.12 | Kamil | Vortrag | 120min |
| 15 | 22.12 | Christian | Programm feinschliff | 45min |
| 16 | 22.12 | Shahir | Programm testen | 45min |
| 17 | 22.12 | Alle | Lernbericht | 180min |


Wir haben und dazu entschieden mehere verschiedene Rätsel zu machen antstatt eins ausgibig zu Programmieren da man mehere besser in der Gruppe aufteilen kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |01.12|Alle|45min|120min|
| 2.A  |01.12|Shahir|30min|20min|
| 3.A  |01.12|Christian|30min|20min|
| 4.A  |01.12|Kamil|30min|20min|
| 5.A  |08.12|Christian|120min|180min|
| 6.A  |08.12|Shahir|120min|180min|
| 7.A  |08.12|Kamil|120min|180min|
| 8.A  |08.12|Christian|45min|----|
| 9.A  |08.12|Shahir|45min|70min|
| 10.A  |08.12|Kamil|45min|----|
| 11.A  |15.12|Christian|120min|----|
| 12.A  |15.12|Shahir|120min|100min|
| 13.A  |15.12|Kamil|120min|----|
| 14.A  |15.12|Kamil|120min|120min|
| 15.A  |22.12|Christian|45min|45min|
| 16.A  |22.12|Shahir|45min|40min|
| 17.A  |22.12|Alle|180min|150min|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |22.12| Negativ|Christian|
| 2.1  |22.12|Negativ|Christian|
| 3.1  |22.12|Negativ|Christian|
| 4.1  |22.12|Negativ|Christian|
| 5.1  |22.12|Positiv|Christian|
| 6.1  |22.12|Negativ|Christian|
| 7.1  |22.12|Negativ|Christian|
| 8.1  |22.12|Positiv|Christian|


Nach einen ein bisschen holpriger Start in das Projekt durch das verlassen der Schule eines underen Gruppenmitglied gerieten wir in rückstand, als wir uns dann noch übernommen haben was die Arbeit angeht, würde ich sagen ist es trotzdem eub gutes Endergebnis obwohl wir nicht alles geschafft haben was geplant war. Das nächste mal müssen wir definitiv schauen das wir die Komunikation besser hinbekommen damit alles strukturierter ist.

## 6 Auswerten

[Link zum Lernbericht](https://github.com/Entlino/LA1300/blob/main/Lernbericht.md)
