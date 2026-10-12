## 24.08.2026
In dieser Lernsession haben wir das Modul und den Klassen-Contract besprochen und uns vorgenommen, die Vereinbarungen einzuhalten. Ich habe mich daran orientiert, indem ich meine Aufgaben erledigt habe.

Im Driver-/Navigator-Team haben wir ein Scratch-Spiel nach einer vorgegebenen die Ziele erledigt, die Aufgaben verteilt und die Rollen regelmässig gewechselt. Wir haben die Bewegung der Spielfigur und die Klickreaktion programmiert. Das Spiel lief in drei aufeinanderfolgenden Durchläufen wie erwartet.

Die Fachbegriffe konnte ich an unserem Spiel zuordnen: Die Spielfigur ist ein Objekt, ihre Position ein Attribut, der Klick ein Ereignis, die Bewegung danach ein Verhalten und eine Variable.

Bei der Beurteilung nach den Kriterien ist uns ein Fehler aufgefallen: wir mussten die Screenshots reinfügen, dies haben wir leider nicht gemacht. 

Ich habe gelernt, wie wichtig Debugging wirklich ist und dass man immer in teams arbeiten aoll. Schwierig war mit Zeitdruck die Aufgaben zu erledigen.


## 31.08.2026
In dieser Lernsession habe ich die Grundlagen der Versionskontrolle erarbeitet. Versionskontrolle hilft, Änderungen an Dateien nachvollziehbar festzuhalten und bei Bedarf zu früheren Ständen zurückzukehren. Git läuft dabei lokal auf meinem Rechner, während GitHub als Plattform dient, auf der man gemeinsam an Projekten arbeitet. 

Im Microsoft-Learn-Pfad habe ich das Modul «Einführung in Git» abgeschlossen und danach mit den Grundlagen von GitHub begonnen. Praktisch habe ich ein lokales Repository geöffnet, den Status geprüft und eine abgegrenzte Änderung mit git add und git commit versioniert.

Dabei habe ich die drei Zustände einer Änderung unterschieden: Im Arbeitsverzeichnis nehme ich die Änderung vor, im Staging-Bereich wird sie für den nächsten Commit vorgemerkt, und im Repository ist sie dauerhaft gespeichert. Im GitHub-Flow ordne ich die Elemente so ein: Das Repository enthält das Projekt, ein Branch ist eine eigene Arbeitslinie, ein Commit hält einen Stand fest, ein Issue beschreibt eine Aufgabe oder ein Problem, und ein Pull Request schlägt vor, die Änderungen aus einem Branch zu übernehmen. Der Ablauf ist also: Issue erfassen, Branch erstellen, Änderungen committen, Pull Request eröffnen und nach der Prüfung zusammenführen.

Ich habe gelernt, dass zwischen git und Git Hub echt einen unterschied gibt. Unklar oder schwierig war das am anfang zu verstehen aber am Schluss binich trotzdem herausgekommen. 


## 14.09.2026
In dieser Lernsession habe ich den begonnenen Microsoft-Learn-Baustein zu GitHub abgeschlossen und den GitHub-Flow in der geführten Übung angewendet. Dabei habe ich ein Issue erfasst, einen Branch erstellt, Änderungen committet und einen Pull Request eröffnet. Die Aufgabe jedes Schritts kann ich erklären: Das Issue beschreibt, was zu tun ist, der Branch trennt meine Arbeit vom Hauptstand, der Commit hält die Änderung fest, und der Pull Request schlägt vor, sie zu übernehmen. Mein Lernfortschritt war anhand der Modulbewertung überprüfbar, da ich alles gemacht habe, was verlangt war.

Danach habe ich das Modul zur Kommunikation mit Markdown bearbeitet. Ich habe Überschriften, Listen, Links, Bilder und Codeblöcke eingesetzt und daraus ein Portfolio-README aufgebaut, in dem ich meinen ersten Lernnachweis strukturiert festgehalten habe. Die Änderung habe ich mit der Commit-Nachricht dokumentiert.

Anschliessend habe ich mein Ergebnis anhand einfacher Qualitätskriterien geprüft. Beim SelbstCheck ist mir aufgefallen, dass ich zuwenig Fragen beantwortet habe und es noch viel zu tun gab, und ich habe das verbessert. Am Ende liegt ein verständlich dokumentierter Repository-Stand vor, den ich für mein ePortfolio weiterverwenden kann.

Ich habe gelernt, wie man mit MD umgehen muss.

## 12.10.2026
1. Worum ging es heute?

Wir haben einen Praxisfall bearbeitet: In der Mensa kaufen Lernende Getränke und Snacks. Die verantwortliche Person rechnet den Gesamtpreis von Hand aus, und besonders bei mehreren gleichen Artikeln passieren Rechenfehler. Für die erste Version haben wir den Fall bewusst klein gehalten: genau ein Artikel pro Einkauf (Artikelname, Einzelpreis, Menge).

Das Ziel der Session war, den Weg vom Problem zur Lösung zu üben, noch ohne Programmcode.

2. Was habe ich gelernt?

Problem, Ziel und Lösung sind drei verschiedene Dinge.

Problem: Was läuft heute schief? («Beim manuellen Berechnen entstehen Fehler.»)
Ziel: Wie sieht der gewünschte Zustand aus? («Der Gesamtpreis wird zuverlässig bestimmt.»)
Lösung: Mit welchem Mittel erreichen wir das? («C#-Konsolenanwendung», «Console.ReadLine()».)

Aussagen wie «Einzelpreis und Menge müssen berücksichtigt werden» passen in keine der drei Kategorien sauber. Sie sind Anforderungen: Sie sagen, was die Lösung leisten muss, aber nicht, wie sie gebaut wird.

Ein Problemstatement muss lösungsneutral sein. Sobald ich Technik nenne (z.B. C#), schliesse ich andere Lösungen aus, bevor ich überhaupt verstanden habe, was gebraucht wird.

Anforderungen brauchen Akzeptanzkriterien. Ein gutes Kriterium ist so konkret, dass eine fremde Person eindeutig sagen kann: erfüllt oder nicht erfüllt. Beispiel: «Bei 2.50 CHF und Menge 3 ist das Ergebnis genau CHF 7.50.» Unklare Formulierungen wie «funktioniert gut» sind dafür unbrauchbar.

Das EVA-Modell gliedert ein Programm.

Eingabe	Verarbeitung	Ausgabe
Artikelname, Einzelpreis, Menge	Gesamtpreis = Einzelpreis × Menge	Zusammenfassung mit Gesamtpreis

Ein Trockenlauf prüft den Ablauf, bevor ich programmiere. Ich spiele den Ablauf mit konkreten Werten von Hand durch und notiere Eingaben, Zwischenergebnisse und erwartete Ausgabe:

Test	Artikel	Einzelpreis	Menge	Erwartete Ausgabe
A	Apfelschorle	CHF 2.50	3	CHF 7.50
B	Sandwich	CHF 5.80	2	CHF 11.60
3. Was habe ich konkret gemacht?
Sieben Aussagen den Kategorien Problem, Ziel und Lösung zugeordnet und mindestens drei Entscheidungen begründet. Dabei habe ich markiert, welche Aussagen nicht sauber passen.
Ein lösungsneutrales Problemstatement und ein überprüfbares Zielbild formuliert.
Vier funktionale Anforderungen abgeleitet (Eingaben erfassen, Gesamtpreis berechnen, Preis in CHF mit zwei Nachkommastellen anzeigen, verständliche Zusammenfassung ausgeben), jeweils mit Akzeptanzkriterium.
Das EVA-Modell erstellt und den linearen Ablauf beschrieben (Start → Eingabe → Verarbeitung → Ausgabe → Ende).
Beide Trockenläufe Schritt für Schritt durchgeführt und mit einer Kontrollrechnung von Hand überprüft (2.50 × 3 = 7.50 und 5.80 × 2 = 11.60).
