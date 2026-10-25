namespace LinqOvningar
{

    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenter =
            [
                new Student { Id = 1, Namn = "Anna", Alder = 19, Klass = "A", Poang = 85 },
                new Student { Id = 2, Namn = "Bertil", Alder = 22, Klass = "B", Poang = 72 },
                new Student { Id = 3, Namn = "Cecilia", Alder = 20, Klass = "A", Poang = 91 },
                new Student { Id = 4, Namn = "David", Alder = 24, Klass = "C", Poang = 64 },
                new Student { Id = 5, Namn = "Eva", Alder = 19, Klass = "B", Poang = 85 },
                new Student { Id = 6, Namn = "Felix", Alder = 21, Klass = "A", Poang = 77 },
                new Student { Id = 7, Namn = "Gustav", Alder = 23, Klass = "C", Poang = 58 },
                new Student { Id = 8, Namn = "Hanna", Alder = 20, Klass = "B", Poang = 95 }
            ];

            Console.WriteLine("LINQ-ÖVNINGAR MED STUDENTER\n");

            // Where
            Console.WriteLine("Where");

            var äldreÄn20 = studenter.Where(s => s.Alder > 20).ToList();
            Console.WriteLine("Studenter äldre än 20:");
            foreach (var s in äldreÄn20)
                Console.WriteLine($"- {s.Namn} ({s.Alder} år)");

            var merÄn80Poang = studenter.Where(s => s.Poang > 80).ToList();
            Console.WriteLine("\nStudenter med mer än 80 poäng:");
            foreach (var s in merÄn80Poang)
                Console.WriteLine($"- {s.Namn}: {s.Poang}");

            // Select
            Console.WriteLine("\nSelect");
            var baraNamn = studenter.Select(s => s.Namn).ToList();
            Console.WriteLine("Bara namn:");
            foreach (var namn in baraNamn)
                Console.WriteLine($"- {namn}");

            var namnOchPoang = studenter.Select(s => new { s.Namn, s.Poang }).ToList();
            Console.WriteLine("\nNamn och poäng i anonym typ:");
            foreach (var item in namnOchPoang)
                Console.WriteLine($"- {item.Namn}: {item.Poang}");

            // OrderBy
            Console.WriteLine("\nOrderBy");

            var sorteradeEfterAlder = studenter.OrderBy(s => s.Alder).ToList();
            Console.WriteLine("Sorterade efter ålder:");
            foreach (var s in sorteradeEfterAlder)
                Console.WriteLine($"- {s.Namn} ({s.Alder} år)");

            var sorteradeEfterPoangDesc = studenter.OrderByDescending(s => s.Poang).ToList();
            Console.WriteLine("\nSorterade efter poäng, högst först:");
            foreach (var s in sorteradeEfterPoangDesc)
                Console.WriteLine($"- {s.Namn}: {s.Poang}");

            // Count
            Console.WriteLine("\nCount");

            var antalStudenter = studenter.Count();
            Console.WriteLine($"Antal studenter: {antalStudenter}");

            var antalIKlassA = studenter.Count(s => s.Klass == "A");
            Console.WriteLine($"Antal i klass A: {antalIKlassA}");

            // Take
            Console.WriteLine("\nTake");

            var treFörsta = studenter.Take(3).ToList();
            Console.WriteLine("De tre första studenterna:");
            foreach (var s in treFörsta)
                Console.WriteLine($"- {s.Namn}");

            var tvåBästaPoäng = studenter.OrderByDescending(s => s.Poang).Take(2).ToList();
            Console.WriteLine("\nDe två bästa poängen:");
            foreach (var s in tvåBästaPoäng)
                Console.WriteLine($"- {s.Namn}: {s.Poang}");

            // Distinct
            Console.WriteLine("\nDistinct");

            var unikaKlasser = studenter.Select(s => s.Klass).Distinct().ToList();
            Console.WriteLine("Unika klassnamn:");
            foreach (var klass in unikaKlasser)
                Console.WriteLine($"- {klass}");

            var unikaAldrar = studenter.Select(s => s.Alder).Distinct().ToList();
            Console.WriteLine("\nUnika åldrar:");
            foreach (var alder in unikaAldrar)
                Console.WriteLine($"- {alder}");

            // Any / All
            Console.WriteLine("\nAny / All");

            var finnsStudentMed100 = studenter.Any(s => s.Poang == 100);
            Console.WriteLine($"Finns det någon student med 100 poäng? {finnsStudentMed100}");

            var harAllaMinst50 = studenter.All(s => s.Poang >= 50);
            Console.WriteLine($"Har alla studenter minst 50 poäng? {harAllaMinst50}");

            // FirstOrDefault / Last / Single
            Console.WriteLine("\nFirstOrDefault / Last / Single");

            var förstaIklassB = studenter.FirstOrDefault(s => s.Klass == "B");
            Console.WriteLine($"Första studenten i klass B: {förstaIklassB?.Namn ?? "Ingen"}");

            var sistaStudenten = studenter.Last();
            Console.WriteLine($"Sista studenten i listan: {sistaStudenten.Namn}");

            var studentMedId = studenter.Single(s => s.Id == 3);
            Console.WriteLine($"Student med Id 3: {studentMedId.Namn}");

            // GroupBy
            Console.WriteLine("\nGroupBy");

            var grupperadePerKlass = studenter.GroupBy(s => s.Klass).ToList();
            foreach (var grupp in grupperadePerKlass)
            {
                Console.WriteLine($"Klass {grupp.Key}: {string.Join(", ", grupp.Select(s => s.Namn))}");
            }

            // Sum / Average / Min / Max
            Console.WriteLine("\nSum / Average / Min / Max");
            var totalPoang = studenter.Sum(s => s.Poang);
            Console.WriteLine($"Summa av alla poäng: {totalPoang}");

            var medelPoang = studenter.Average(s => s.Poang);
            Console.WriteLine($"Medelpoäng: {medelPoang}");

            var lägstaPoäng = studenter.Min(s => s.Poang);
            Console.WriteLine($"Lägsta poäng: {lägstaPoäng}");

            var högstaPoäng = studenter.Max(s => s.Poang);
            Console.WriteLine($"Högsta poäng: {högstaPoäng}");
        }
    }
}
