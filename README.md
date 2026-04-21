# Sportson Portal – Grupparbete Reflektion

## Om projektet
Vi har ett grupparbete där vi bygger ett intranät för Sportson. Det är ett internt system som anställda ska använda. Gruppen har 10 personer från olika kurser: testare, .NET Cloud och .NET som jag pluggar nu. Vi fick en produktbeskrivning och ett Swagger API-dokument med testdata från Sportson. Projektet pågår från vecka 14 till vecka 18.

---

## Agilt arbetssätt
Vi jobbar agilt med en Scrum Master och använder Azure DevOps för att planera backlog och sprints. Första veckan lärde vi känna varandra och planerade schemat tillsammans.

I Sprint 1 diskuterade vi User Stories och fördelade ansvar. Jag tog ansvar för att bygga mappstrukturen i backend och skapa GET-endpoints för Nyheter och Viktiga Datum som visas på landningssidan.

Efter Sprint 1 hade vi en retrospektiv där vi pratade om vad som gick bra och vad som kunde bli bättre. Vi märkte att tasks och mål var otydliga i Sprint 1. I Sprint 2 förbättrade vi det och nu har vi tydligare mål och bättre struktur.

---

## Vad jag lärde mig tekniskt

**API-struktur**
En av mina största lärdomar var att förstå hur backend hänger ihop:
```
Controller → Service → Repository → Entity (Databas)
```
Det är en sak att lära sig det på lektioner – en helt annan sak att bygga det själv. Nu förstår jag hur varje del har ett eget ansvar.

**Azure**
Jag lärde mig att sätta upp Azure Blob Storage för att spara bilder och PDF-filer via API. Det väckte mitt intresse för Azure – speciellt CI/CD, Pipelines och Azure App Service.

**Git**
Innan grupparbetet jobbade jag mest direkt mot main lokalt. Nu jobbar vi med:
```
Main → Development → Feature branches
```
Jag lärde mig att alltid göra PULL innan man skapar en ny branch för att undvika konflikter. Det är väldigt kul att många kan jobba i samma repository samtidigt.

**Frontend**
Jag jobbade också lite i frontend. Jag byggde designen för Viktiga Datum och kopplade den mot backend med Axios. Det gav mig en bättre helhetsbild av hur frontend och backend kommunicerar.

---

## Samarbete och kommunikation
Att jobba i ett team med personer man inte känner var lärorikt. Jag lärde mig att respektera andras idéer och lyssna på andra. Det är viktigt att fokusera på det man själv kan kontrollera.

Kommunikation var avgörande – jag synkade hela tiden med frontend-utvecklarna om fältnamn, funktioner och design. Azure DevOps hjälpte mycket – man kunde följa varandras kod och progress i realtid.

---

## Sammanfattning
Det här projektet har gett mig mycket erfarenhet både tekniskt och som lagspelare. Jag tar med mig kunskaper inom agilt arbetssätt, API-utveckling, Azure, Git och vikten av kommunikation i ett team.
Det som överraskade mig mest är att jag blev mer och mer nyfiken på hur saker fungerar. Jag kunde sitta långa dagar utan att titta på klockan det känns som ett bra tecken på att jag har hittat något jag verkligen tycker om. 🙂
