oe-reeksen-arrays-collections-adressen-start
Bijhouden van adressen in een list van arrays
# Adressenlijst
Screenshot van het resultaat
![screenshot](/images/screenshot.png)
Kies passende namen voor de controls.
## Adressen bijhouden
In List<string[]> adressen houd je de adressen bij. 

Declareer deze list op class-niveau. 

Elk adres is een array van string, met in de elementen resp.
-	Straat
-	Huisnr
-	Busnr
-	Postcode
-	Gemeente

## Methode **VoegAdresToe**
Zet in de methode *‘VoegAdresToe’* een csv-string om naar een array en voeg die toe aan adressen.
In de methode MaakAdressen voer je deze bewerking uit met de constanten adres1 - 4.
## Adressen weergeven
- Declareer de instance variabele *List<**string**> adresInfo*.
- In de methode **MaakAdresInfo** instantieer je *adresInfo*.
- Voeg aan deze list van elk adres de straat en de gemeente toe. 
- Toon deze lijst in lstAdressen.
## Details van een geselecteerd adres
Wanneer in de listbox een item geselecteerd wordt:
-	Hou je de index bij van het aangeklikt item
-	Worden de details in de resp. textboxen getoond
## Wijzigingen opslaan
Wanneer op de button Opslaan wordt geklikt, worden 
-	 de aangepaste gegevens opgeslagen in adressen
-	 de aangepaste gegevens in de listbox getoond.
## Uitbreiding
Wijzigingen annuleren
Wanneer op de button Annuleren wordt geklikt, worden de oorspronkelijke gegevens getoond in de controls

