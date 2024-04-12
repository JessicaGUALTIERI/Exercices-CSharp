using FirstAspDotnetApp.Models;

namespace FirstAspDotnetApp.Data
{
    public class AppData
    {
        public List<Classroom> Classrooms { get; set; }
        public AppData() {
            Classrooms = new List<Classroom>()
            {
                new()
                {
                    Id = 1,
                    Name = "CDA - C#",
                    Students =
                    [
                        new()
                        {
                            Id = 1,
                            Firstname = "Imane",
                            Lastname = "Cherraj"
                        },
                        new()
                        {
                            Id = 2,
                            Firstname = "Arnaud",
                            Lastname = "Muller"
                        },
                        new()
                        {
                            Id = 3,
                            Firstname = "Alexandre",
                            Lastname = "Dach"
                        },
                        new()
                        {
                            Id = 4,
                            Firstname = "Axel",
                            Lastname = "Martin"
                        },
                        new()
                        {
                            Id = 5,
                            Firstname = "Cyril",
                            Lastname = "Cherrier"
                        },
                        new()
                        {
                            Id = 6,
                            Firstname = "Jessica",
                            Lastname = "Gualtieri"
                        },
                        new()
                        {
                            Id = 7,
                            Firstname = "Mathias",
                            Lastname = "Dumas"
                        },
                        new()
                        {
                            Id = 8,
                            Firstname = "Isabelle",
                            Lastname = "Apoux"
                        },
                        new()
                        {
                            Id = 9,
                            Firstname = "Florent",
                            Lastname = "Bernar"
                        },
                        new()
                        {
                            Id = 10,
                            Firstname = "Alexandre",
                            Lastname = "Cerf"
                        },
                        new()
                        {
                            Id = 11,
                            Firstname = "Clément",
                            Lastname = "Parpaiola"
                        },
                        new()
                        {
                            Id = 12,
                            Firstname = "Fabien",
                            Lastname = "Hasselmann"
                        },
                        new()
                        {
                            Id = 13,
                            Firstname = "Nathan",
                            Lastname = "Randoulet"
                        },
                        new()
                        {
                            Id = 14,
                            Firstname = "Louis",
                            Lastname = "Kuster"
                        },
                        new ()
                        {
                            Id = 15,
                            Firstname = "Thomas",
                            Lastname = "Thouvenin"
                        },
                        new()
                        {
                            Id = 16,
                            Firstname = "Nadejda",
                            Lastname = "Teriokhina"
                        },
                        new()
                        {
                            Id = 17,
                            Firstname = "Necati",
                            Lastname = "Han"
                        },
                        new()
                        {
                            Id = 18,
                            Firstname = "Imane",
                            Lastname = "Badi"
                        }
                    ]
                },
            };
        }
    }
}
