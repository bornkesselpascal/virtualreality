# Dokumentation zum Praktikum

> Praktikum "Virtuelle Realität"  |  Pascal Julian Bornkessel  |  Flug- und Fahrzeuginformatik im 6. Semester


## Blatt 1 - "Roll a Ball" (24.03.2023)
Die Aufgaben 1 bis 6 des Teils "Roll a Ball" sowie die Aufgabe 1 des Teils "Roll a Ball VR" wurden wie beschrieben bearbeitet um das grundlegende Spiel zu erstellen. Die im Zuge der Aufgabe 2 des Teils "Roll a Ball VR" eingebauten Erweiterungen sollen im Folgenden gesondert erläutert werden. 

* **Abprallen** - Es wurde das Abprallen des Balles an den Wänden hinzugefügt. Dafür wurde ein Physical Material "Wall Bounce" erstellt, welches zu den Wänden hinzugefügt wurde. Die Bounciness der Wände wurde dabei auf 1 gesetzt.

* **"feindliche" Pick-Ups** - Einige der gelben Pick-Ups wurden in rote Pick-Ups umgewandelt. Berührt der Ball _zwei mal_ einen roten Pick-Up _hintereinander_, so ist das Spiel beendet. Dies wird realisiert, indem dem Spieler der Ball weggenommen wird.

* **Bewegung** - Für die roten Pick-Ups wurde ein Script erstellt, welches diese mit einer bestimmten Geschwindigkeit vor und zurück bewegt. Dadurch soll die Scheiwrigkeit erhöht werden. Des Weiteren wurde für die gelben und roten Pick-Ups ein Skipt erstellt, durch das diese sich mit einer bestimmten Geschwindigkeit auf dem Board im Kreis bewegen. Dies soll, gerade im Zusammenhang mit den roten Pick-Ups, die Schwierigkeit erhöhen.

* **Levels** - Zur Demonstation der unterschiedlichen Schwrierigkeitsmöglichkeiten durch die Anpassungen wurden drei Level erstellt. Zur Unterscheidung werden dabei unterschiedliche Farben des Boards verwendet.

* **Gestaltung** - Für das Material des Boards und der Wände wurde _Billardfilz_ als Textur verwendet. Für den Boden wurde eine metallische Oberfläche gewählt.

* **Cheating** -  Der Spieler kann schummeln indem er den Ball nimmt und an eine beliebige Stelle des Boards legt, sodass er die roten Pick-Ups nicht berührt.

> Das Video zur Aufgabe 1 ist [hier](https://1drv.ms/u/s!AtQYIMPjZihlgc8rKIlmhtE8WPOdaA?e=dONT6f) auf OneDrive zu finden. (https://1drv.ms/u/s!AtQYIMPjZihlgc8rKIlmhtE8WPOdaA?e=dONT6f)


## Blatt 2 - "Flugsimulator" (31.03.2023)
### Teil 1 - Auswahl des Fluggerätes
Als Fluggerät wurde sich für den _Eurofighter Typhoon_ entschieden. Das Modell wurde von [Sketchfab](https://sketchfab.com/) heruntergeladen und als Autodesk FBX-Datei in Unity importiert.

### Teil 2 - Inspektion
Die Szene zur Inspektion des Fluggerätes erfüllt alle in der Aufgabenstellung beschriebenen grundlegenden Anforderungen. Im Folgenden sollen einige Details und Erweiterungen näher beschrieben werden.

![Bild](https://i.ibb.co/SsS4Fb3/inspektion.png)

* **Verbesserungen am Flugmodell**
     * **Sound** - Es wurde eine 3D-Soundquelle für die laufenden Triebwerke eingebaut.
     * **Partikelsystem** - Es wurde ein Feuer-Partikelsystem hinzugefügt, welche den Nachbrenner darstellen sollen.
     
* **Wechsel zur Cockpit-Szene** - Da der Spieler kleiner ist als das Flugzeug und dadurch nicht das Cockpit erreichen kann wurde der Wechsel in die Cockpit-Szene durch Bewegung des rechten Carnards (vorne angebrachtes Höhenleitwerk) um 45°.

* **Szenerie**
     * **Flughafen** - Es wurde ein Flughafen mit Startbahn, Tower, Hangars und Begleitbauwerken in die Szene eingefügt.
     * **Fahrzeuge** - Um den Eindruck eines militärisch genutzten Flughafens zu verstärken, wurden zwei zusätzliche Flugzeuge (ein weiterer Eurofighter und eine Lockheed F-117) sowie weitere Fahrzeuge (militärische Transporter sowie bodengestützte Flugabwehrraketen) hinzugefügt.
     * **Sky-Box** - Es wurde eine Sky-Box hinzugefügt und die Lichtquelle verschoben, um einen Sonnenaufgang darzustellen.
     
* **Terrain**
     * **Gebirge** - In Hintergrund befindet sich ein im Neben eingehüllter Berg.
     * **Bäume und Sträucher**
     * **Wind** - Die Bäume und Sträucher bewegen sich durch den Wind aus nordwestlicher Richtung.


### Teil 3 - Cockpit

