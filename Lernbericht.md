# Lern-Bericht
Gruppe - Waffle
Kamil Bielski, Christian Aeschlimann, Mohammad Shahir Bashiri

## Einleitung

Unser Programm wird ein Geographie Quiz bei welchem man Hauptstädte, Flaggen, sowie Kontinent erraten kann.

## Was habe ich gelernt?

Das Ding, das wir alle 3 gelernt haben, ist, wie man ein UI in Winforms erstellt. 
Es begann schlecht, wie es meistens der Fall ist, aber im Laufe der Zeit wurden wir alle besser darin, 
die uns zur Verfügung stehenden Funktionen besser zu nutzen.

## Beschreibung

Wir haben Winforms zum Erstellen von UIs gelernt, indem wir uns online Tutorials angesehen und Beispiel-Code ausprobiert haben.
Da alle unsere Programme sehr ähnlich sind, mussten wir dasselbe lernen. Das Wichtigste war, die Knöpfe zu 
programmieren, auf unsere Klicks zu reagieren. Da alle unsere Programme sehr ähnlich sind, mussten wir dasselbe lernen. Das 
Wichtigste war die Programmierung der Knöpfe, die auf unsere Klicks reagieren. Nachdem wir das herausgefunden hatten, bestand der nächste 
Schritt darin, die Klicks auf die Schaltfläche zu programmieren, um die vom Benutzer gegebene Antwort zu korrigieren.

![image](https://user-images.githubusercontent.com/111045708/209092384-5d58bdca-0a9b-417f-97a6-1b3311c6ef0b.png)

Hier sieht man, dass ich auf die falsche Antwort geklickt habe und das Programm hat das erkannt und mir gesagt, dass ich die falsche Antwort bekommen habe.

```
button1.Text = correctAnswer;
            button2.Text = "Incorrect Answer 1";
            button3.Text = "Incorrect Answer 2";
            button4.Text = "Incorrect Answer 3";

            currentCountry = "";
            correctAnswer = "";
            currentCountry = countries.Keys.ElementAt(rng.Next(countries.Count));

            correctAnswer = countries[currentCountry];

            lblQuestion.Text = "Was ist die Hauptstadt von " + currentCountry + "?";

            List<string> answers = new List<string>() { correctAnswer };
            while (answers.Count < 4)
            {
                string incorrectAnswer = countries.Values.ElementAt(rng.Next(countries.Count));
                if (!answers.Contains(incorrectAnswer))
                {
                    answers.Add(incorrectAnswer);
                }
            }

            answers = answers.OrderBy(x => rng.Next()).ToList();

            button1.Text = answers[0];
            button2.Text = answers[1];
            button3.Text = answers[2];
            button4.Text = answers[3];
```

Dieser Teil des Codes gibt den Knöpfen die Funktion, die Antworten zu überprüfen und zu korrigieren.


## Verifikation

Wir haben gelernt, wie man eine Benutzeroberfläche in Winforms erstellt. Das Wichtigste, was wir für unsere Programme gelernt haben, waren die Knöpfe und ihre Funktionen nach dem Anklicken.

# Reflexion zum Arbeitsprozess

Ein Teil des Programms funktioniert und läuft einwandfrei.

Wir konnten nicht alle Funktionen implementieren, die wir wollten, hauptsächlich aufgrund von Unerfahrenheit.

**VBV**: 
Einige Verbesserungsmöglichkeiten für unser nächstes Projekt bestehen darin, die Aufgabenteilung besser zu besprechen und während der Arbeit besser zu kommunizieren. Was noch verbesserungswürdig ist, ist die Selbstüberschätzung mit den Funktionen, die wir implementieren wollen. Eine Möglichkeit, dies zu beheben, könnte darin bestehen, am Anfang mehr zu recherchieren, um herauszufinden, was wir programmieren können und was nicht.
