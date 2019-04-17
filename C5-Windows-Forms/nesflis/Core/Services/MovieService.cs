using System.Collections.Generic;
using Core.Entities;
using System.Linq;

namespace Core.Services
{
    public static class MovieService
    {
        private static ICollection<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Code = 1,
                Name = "Dumbo",
                Description = "La nueva recreación de la película DUMBO dirigida por Tim Burton cuenta con Colin Farrel como Holt Farrier quien con ayuda de sus hijos Milly y Joe se dedican a cuidar a un elefante recién nacido cuyas orejas gigantes le hacer ser el hazmerreír en un Circo que no pasa por su mejor momento.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/duvp1mgeVYs1vUknW8KXxhnVhzh.jpg",
                Genres = new Genre[] { Genre.ADVENTURE, Genre.FAMILY, Genre.FANTASY },
                Actors = new string[] { "Colin Farrell", "Michael Keaton", "Danny DeVito" },
                PercentageRate = 68,
            },
            new Movie()
            {
                Code = 2,
                Name = "Cómo entrenar a tu Dragón 3",
                Description = "Mientras Hipo (Jay Baruchel) logra su sueño de lograr una utopía pacífica entre los dragones, la aparición de una pareja sin domar hace que Desdentao, el furia nocturna, se aleje. Cuando el peligro aumente en casa y el reinado de Hipo como líder sea puesto a prueba, ambos deberán tomar decisiones imposibles para salvar a los suyos.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/bIDRyNDCrupfDdzP1AlsCYjGXE3.jpg",
                Genres = new Genre[] { Genre.ANIMATION, Genre.FAMILY, Genre.ADVENTURE },
                Actors = new string[] { "Jay Baruchel", "America Ferrera", "Cate Blanchett" },
                PercentageRate = 76,
            },
            new Movie()
            {
                Code = 3,
                Name = "Capitana Marvel",
                Description = "La historia sigue a Carol Danvers mientras ella se convierte en uno de los héroes más poderosos del universo cuando la Tierra se encuentre atrapada en medio de una guerra galáctica entre dos razas alienígenas.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/lsQWAoT3IERwQkQNFTkIeZk2R1S.jpg",
                Genres = new Genre[] { Genre.ACTION, Genre.ADVENTURE, Genre.SCIENCE_FICTION },
                Actors = new string[] { "Brie Larson", "Samuel L. Jackson", "Jude Law" },
                PercentageRate = 72,
            },
            new Movie()
            {
                Code = 4,
                Name = "¡Shazam!",
                Description = "Todos llevamos un superhéroe dentro, solo se necesita un poco de magia para sacarlo a la luz. Cuando Billy Batson, un niño de acogida de 14 años que ha crecido en las calles, grita la palabra 'SHAZAM!' se convierte en el Superhéroe adulto Shazam, por cortesía de un antiguo mago.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/8LzNq62JzcNtGkNb1Iqf3Q3lpCJ.jpg",
                Genres = new Genre[] { Genre.ACTION, Genre.COMEDY, Genre.ADVENTURE, Genre.FANTASY },
                Actors = new string[] { "Zachary Levi" },
                PercentageRate = 74,
            },
            new Movie()
            {
                Code = 5,
                Name = "La Milla Verde",
                Description = "En el sur de los Estados Unidos, en plena Depresión, Paul Edgecomb es un vigilante penitenciario a cargo de la Milla Verde, un pasillo que separa las celdas de los reclusos condenados a la silla eléctrica. Esperando su ejecución está John Coffey, un gigantesco negro acusado de asesinar brutalmente a dos hermanas de nueve años. Tras una personalidad ingenua, Coffey esconde un don sobrenatural prodigioso.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/9jfxlPX4nJvpBC3QxcqXvyBteaK.jpg",
                Genres = new Genre[] { Genre.FANTASY, Genre.DRAMA, Genre.CRIME },
                Actors = new string[] { "Tom Hanks", "Michael Clarke Duncan" },
                PercentageRate = 84,
            },
            new Movie()
            {
                Code = 6,
                Name = "Star Wars: El Imperio Contraataca",
                Description = "Tras un ataque sorpresa de las tropas imperiales a las bases camufladas de la alianza rebelde, Luke Skywalker, en compañía de R2D2, parte hacia el planeta Dagobah en busca de Yoda, el último maestro Jedi, para que le enseñe los secretos de la Fuerza.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/eU7KcNAOeZj9PBIcGUMSsuJz8qj.jpg",
                Genres = new Genre[] { Genre.ADVENTURE, Genre.ACTION, Genre.SCIENCE_FICTION },
                Actors = new string[] { "Mark Hamill", "Harrison Ford", "Carrie Fisher" },
                PercentageRate = 83,
            },
            new Movie()
            {
                Code = 7,
                Name = "Green Book",
                Description = "Años 60. Cuando Tony Lip (Viggo Mortensen), un rudo italoamericano del Bronx, es contratado como chófer del virtuoso pianista negro Don Shirley (Mahershala Ali), durante una gira de conciertos por el Sur de Estados Unidos, deberá confiar en 'El libro verde', una guía de los pocos establecimientos seguros para los afroamericanos, para encontrar alojamiento.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/6yo3zLs8eGcdX8eS6DHcjC8U7eY.jpg",
                Genres = new Genre[] { Genre.DRAMA, Genre.COMEDY, Genre.MUSIC },
                Actors = new string[] { "Viggo Mortensen", "Mahershala Ali" },
                PercentageRate = 83,
            },
            new Movie()
            {
                Code = 8,
                Name = "Reservoir Dogs",
                Description = "Una banda organizada formada por seis individuos es contratada para dar un golpe. Anteriormente varios de los miembros no se conocían entre sí, por lo que entre ellos usan nombres en clave. El objetivo: atracar una empresa para llevarse unos diamantes.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/hxmJqXFFnXLlvPIdCW2k3UGLCgZ.jpg",
                Genres = new Genre[] { Genre.CRIME, Genre.SUSPENSE },
                Actors = new string[] { "Harvey Keitel", "Tim Roth", "Steve Buscemi" },
                PercentageRate = 82,
            },
            new Movie()
            {
                Code = 9,
                Name = "Misery",
                Description = "Un escritor llamado Paul Sheldon (James Caan) lleva años malgastando su talento con unas románticas historias, de gran éxito comercial, cuya protagonista es una mujer llamada Misery. Decidido a acabar con esta situación, mata al personaje y se refugia en Colorado para escribir una novela seria. Terminado su trabajo, emprende el regreso, pero en una carretera de montaña, pierde el control de su coche y sufre un grave accidente.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/pY9Us6mOhEzZeWnDr5D5HWImzDU.jpg",
                Genres = new Genre[] { Genre.DRAMA, Genre.SUSPENSE },
                Actors = new string[] { "James Caan", "Kathy Bates" },
                PercentageRate = 77,
            },
            new Movie()
            {
                Code = 10,
                Name = "Fargo",
                Description = "Un hombre apocado y tímido, casado con la hija de un millonario que le impide disfrutar de su fortuna, decide contratar a dos delincuentes para que secuestren a su mujer con el fin de montar un negocio propio con el dinero del rescate. Pero, por una serie de azarosas circunstancias, al secuestro se suman tres brutales asesinatos, lo que obliga a la policía a intervenir.",
                PosterUrl = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/80FO9rH82FiJyLtGMDnGQnDQx0z.jpg",
                Genres = new Genre[] { Genre.CRIME, Genre.DRAMA, Genre.SUSPENSE },
                Actors = new string[] { "William H. Macy", "Frances McDormand", "Steve Buscemi" },
                PercentageRate = 78,
            }
        };

        public static ICollection<Movie> FetchAllMovies() => movies;

        public static ICollection<Movie> FetchMoviesWithGenre(int genre) => movies.Where(movie => movie.Genres.Contains((Genre) genre)).ToList();

        public static ICollection<Movie> FetchMoviesWithActor(string actorName) => movies.Where(movie => movie.Actors.Contains(actorName)).ToList();

        public static Movie FetchMovie(int code) => movies.FirstOrDefault(movie => movie.Code == code);
    }
}
