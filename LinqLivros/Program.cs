using LinqLivros.Linqs;
using LinqLivros.Models;

class Program
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>
        {
            new Livro("Journey to the Stars", "John Smith", 2010),
            new Livro("The Forgotten Realm", "Emily Johnson", 2015),
            new Livro("Mysteries of the Deep", "Robert Brown", 2008),
            new Livro("Whispers in the Wind", "Lisa Davis", 2012),
            new Livro("The Lost Treasure", "Michael Wilson", 2016),
            new Livro("Echoes of the Past", "Sarah Miller", 2019),
            new Livro("Shadows of the Night", "David Taylor", 2011),
            new Livro("Beyond the Horizon", "Jennifer Anderson", 2013),
            new Livro("Secrets of the Forest", "Chris Martinez", 2018),
            new Livro("Guardians of Time", "Laura Hernandez", 2014),
            new Livro("Wonders of the World", "Daniel Thompson", 2009),
            new Livro("Legends Untold", "Mary White", 2017),
            new Livro("Adventures in Space", "Kevin Clark", 2020),
            new Livro("Mystic Waters", "Jessica Lewis", 2011),
            new Livro("Dreams of Tomorrow", "Steven Walker", 2014),
            new Livro("The Enchanted Isle", "Amanda Hall", 2015),
            new Livro("Tales of the Unknown", "Brian Allen", 2007),
            new Livro("Voyage to the Unknown", "Karen Young", 2013),
            new Livro("The Hidden Valley", "Eric King", 2016),
            new Livro("Legends of the Sky", "Susan Wright", 2012),
            new Livro("Echoes from the Future", "Frank Scott", 2009),
            new Livro("The Secret Garden", "Patricia Green", 2018),
            new Livro("Mystical Realms", "George Baker", 2020),
            new Livro("The Lost Kingdom", "Linda Adams", 2011),
            new Livro("Journey through Time", "Anthony Hill", 2013),
            new Livro("The Ancient Prophecy", "Nancy Nelson", 2017),
            new Livro("Beyond the Stars", "Paul Carter", 2014),
            new Livro("The Hidden Fortress", "Shirley Roberts", 2015),
            new Livro("Whispers of the Sea", "Mark Collins", 2016),
            new Livro("Adventures in the Jungle", "Betty Stewart", 2012),
            new Livro("The Forgotten Path", "Donald Morris", 2008),
            new Livro("Guardians of the Galaxy", "Barbara Rogers", 2019),
            new Livro("Mysteries of the Mind", "Joshua Reed", 2020),
            new Livro("The Enchanted Forest", "Karen Cook", 2011),
            new Livro("Dreams of the Future", "Andrew Morgan", 2014),
            new Livro("The Hidden Temple", "Rachel Bell", 2013),
            new Livro("Voyage to the Stars", "Adam Murphy", 2017),
            new Livro("The Secret Cave", "Megan Rivera", 2015),
            new Livro("Legends of the Ocean", "Justin Howard", 2010),
            new Livro("Mystic Shores", "Tiffany Ward", 2016),
            new Livro("The Lost City", "Brandon Cooper", 2009),
            new Livro("Whispers of the Forest", "Catherine Mitchell", 2018),
            new Livro("Guardians of the Earth", "Aaron Perez", 2020),
            new Livro("Adventures in the Wild", "Valerie Roberts", 2011),
            new Livro("The Hidden Passage", "Harold Rogers", 2014),
            new Livro("Echoes of the Ocean", "Dorothy Turner", 2015),
            new Livro("Mysteries of the Night", "Peter Phillips", 2016),
            new Livro("Dreams of the Past", "Janet Morris", 2013),
            new Livro("The Ancient Ruins", "Raymond Perry", 2010),
            new Livro("Journey to the Unknown", "Cynthia Watson", 2019)
        };

        LinqWhereOrderBy.LinqLivroWhereOrderBy(livros);
    }
}
