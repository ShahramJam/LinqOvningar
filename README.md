# LinqOvningar

Ett enkelt C#-projekt för att öva på LINQ med en lista av studenter.

## Syfte

Projektet visar hur man använder vanliga LINQ-metoder för att:

- filtrera data med `Where`
- välja data med `Select`
- sortera data med `OrderBy` och `OrderByDescending`
- räkna poster med `Count`
- ta ut ett visst antal element med `Take`
- hitta unika värden med `Distinct`
- kontrollera villkor med `Any` och `All`
- hämta specifika element med `FirstOrDefault`, `Last` och `Single`
- gruppera data med `GroupBy`
- summera och beräkna värden med `Sum`, `Average`, `Min` och `Max`

## Struktur

- `LinqOvningar/Program.cs` – huvudprogram med exempeldata och LINQ-övningar
- `LinqOvningar/LinqOvningar.csproj` – .NET projektfil
- `LinqOvningar.slnx` – lösningsfil

## Krav

- .NET SDK 10.0 eller senare

## Så kör du projektet

Från projektets rotmapp:

```bash
dotnet run --project LinqOvningar/LinqOvningar.csproj
```

## Exempel på innehåll

Programmet innehåller exempel för:

- studenter äldre än 20
- studenter med mer än 80 poäng
- sortering efter ålder och poäng
- antal studenter totalt och i klass A
- unika klassnamn och åldrar
- kontroll om någon student har 100 poäng
- första student i klass B
- sista student i listan
- gruppindelning per klass
- totalpoäng, medelpoäng, lägsta och högsta poäng

## Licens

Projektet är avsett för övnings- och lärandeformål.