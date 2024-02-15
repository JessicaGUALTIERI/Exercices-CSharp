namespace TP_FootballTeam;

class Program
{
    static void Main(string[] args)
    {
        Team FCMetz = new Team("FC Metz");
        FCMetz.Initialize();
        Player Mikautadze = new Player(FCMetz, "Georges", "Mikautadze", PlayerStatus.Playing);
        Player LamkelZe = new Player(FCMetz, "Didier", "Lamkel Ze", PlayerStatus.Playing);
        Player JeanJacques = new Player(FCMetz, "Danley", "Jean Jacques", PlayerStatus.Playing);
        Player Camara = new Player(FCMetz, "Lamine", "Camara", PlayerStatus.Playing);
        Player NDoram = new Player(FCMetz, "Kévin", "N'Doram", PlayerStatus.Playing);
        Player Udol = new Player(FCMetz, "Matthieu", "Udol", PlayerStatus.Playing);
        Player Herelle = new Player(FCMetz, "Christophe", "Hérelle", PlayerStatus.Playing);
        Player Traore = new Player(FCMetz, "Ismaël", "Traoré", PlayerStatus.Playing);
        Player Sane_S = new Player(FCMetz, "Sadibou", "Sané", PlayerStatus.Playing);
        Player VanDenKerkhof = new Player(FCMetz, "Kévin", "Van Den Kerkhof", PlayerStatus.Playing);
        Player Oukidja = new Player(FCMetz, "Alexandre", "Oukidja", PlayerStatus.Playing);
        Player Sabaly = new Player(FCMetz, "Cheikh", "Sabaly", PlayerStatus.Substitute);
        Player Tetteh = new Player(FCMetz, "Benjamin", "Tetteh", PlayerStatus.Substitute);
        Player Atta = new Player(FCMetz, "Arthur", "Atta", PlayerStatus.Substitute);
        Player Nduquidi = new Player(FCMetz, "Joseph", "Nduquidi", PlayerStatus.Substitute);
        Player Dietsch = new Player(FCMetz, "Guillaume", "Dietsch", PlayerStatus.Substitute);
        Player Colin = new Player(FCMetz, "Maxime", "Colin", PlayerStatus.Substitute);
        Player Cande = new Player(FCMetz, "Fali", "Candé", PlayerStatus.Substitute);
        Player Sane_I = new Player(FCMetz, "Ibou", "Sané", PlayerStatus.Substitute);
        Player Asoro = new Player(FCMetz, "Joel", "Asoro", PlayerStatus.Substitute);
        FCMetz.DisplayPlayers();

        Team OM = new Team("Olympique de Marseille");
        OM.Initialize();
        Player Lopez = new Player(OM, "Pau", "López", PlayerStatus.Playing);
        Player Clauss = new Player(OM, "Jonathan", "Clauss", PlayerStatus.Playing);
        Player Gigot = new Player(OM, "Samuel", "Gigot", PlayerStatus.Playing);
        Player Balerdi = new Player(OM, "Leonardo", "Balerdi", PlayerStatus.Playing);
        Player Merlin = new Player(OM, "Quentin", "Merlin", PlayerStatus.Playing);
        Player Onana = new Player(OM, "Jean", "Onana", PlayerStatus.Playing);
        Player Ounahi = new Player(OM, "Azzdine", "Ounahi", PlayerStatus.Playing);
        Player Harit = new Player(OM, "Amine", "Harit", PlayerStatus.Playing);
        Player Ndiaye = new Player(OM, "Illiman", "Ndiaye", PlayerStatus.Playing);
        Player Moumbagna = new Player(OM, "Faris", "Moumbagna", PlayerStatus.Playing);
        Player Aubameyang = new Player(OM, "Pierre-Emerick", "Aubameyang", PlayerStatus.Playing);
        Player Garcia = new Player(OM, "Ulisses", "Garcia", PlayerStatus.Substitute);
        Player Meite = new Player(OM, "Bamo", "Meïté", PlayerStatus.Substitute);
        Player Sarr = new Player(OM, "Ismaïla", "Sarr", PlayerStatus.Substitute);
        Player Henrique = new Player(OM, "Luis", "Henrique", PlayerStatus.Substitute);
        Player Correa = new Player(OM, "Joaquin", "Correa", PlayerStatus.Substitute);
        Player Jousselin = new Player(OM, "Léo", "Jousselin", PlayerStatus.Substitute);
        Player Blanco = new Player(OM, "Ruben", "Blanco", PlayerStatus.Substitute);
        Player Soglo = new Player(OM, "Emran", "Soglo", PlayerStatus.Substitute);
        Player SidiAli = new Player(OM, "Sofiane", "Sidi Ali", PlayerStatus.Substitute);
        OM.DisplayPlayers();

        Team FCLorient = new Team("FC Lorient");
        FCLorient.Initialize();
        Player Mvogo = new Player(FCLorient, "Yvon", "Mvogo", PlayerStatus.Playing);
        Player Toure = new Player(FCLorient, "Isaak", "Toure", PlayerStatus.Playing);
        Player Talbi = new Player(FCLorient, "Montassar", "Talbi", PlayerStatus.Playing);
        Player Adjei = new Player(FCLorient, "Nathaniel", "Adjei", PlayerStatus.Playing);
        Player LeBris = new Player(FCLorient, "Théo", "Le Bris", PlayerStatus.Playing);
        Player Louza = new Player(FCLorient, "Imram", "Louza", PlayerStatus.Playing);
        Player Abergel = new Player(FCLorient, "Laurent", "Abergel", PlayerStatus.Playing);
        Player Katseris = new Player(FCLorient, "Pànos", "Katséris", PlayerStatus.Playing);
        Player Ponceau = new Player(FCLorient, "Julien", "Ponceau", PlayerStatus.Playing);
        Player Kari = new Player(FCLorient, "Ayman", "Kari", PlayerStatus.Playing);
        Player Bamba = new Player(FCLorient, "Mohamed", "Bamba", PlayerStatus.Playing);
        Player Bouanani = new Player(FCLorient, "Badredine", "Bouanani", PlayerStatus.Substitute);
        Player Dieng = new Player(FCLorient, "Bamba", "Dieng", PlayerStatus.Substitute);
        Player Mendy = new Player(FCLorient, "Formose", "Mendy", PlayerStatus.Substitute);
        Player Bakayoko = new Player(FCLorient, "Tiémoué", "Bakayoko", PlayerStatus.Substitute);
        Player Gomis = new Player(FCLorient, "Alfred", "Gomis", PlayerStatus.Substitute);
        Player Laporte = new Player(FCLorient, "Julien", "Laporte", PlayerStatus.Substitute);
        Player Makengo = new Player(FCLorient, "Jean-Victor", "Makengo", PlayerStatus.Substitute);
        Player Kroupi = new Player(FCLorient, "Eli Junior", "Kroupi", PlayerStatus.Substitute);
        Player Caoki = new Player(FCLorient, "Gino", "Caoki", PlayerStatus.Substitute);
        FCLorient.DisplayPlayers();

        FCMetz.ChangeOfPlayer(LamkelZe, Sabaly);
        FCMetz.ChangeOfPlayer(NDoram, Tetteh);
        FCMetz.ChangeOfPlayer(Mikautadze, Atta);
        FCMetz.ChangeOfPlayer(VanDenKerkhof, Nduquidi);

        OM.ChangeOfPlayer(Ndiaye, Garcia);
        OM.ChangeOfPlayer(Moumbagna, Meite);
        OM.ChangeOfPlayer(Harit, Sarr);
        OM.ChangeOfPlayer(Merlin, Henrique);


        Clauss.YellowCard();
        Gigot.RedCard();
        Onana.YellowCard();

        Camara.GetsInjuredAndReplacedBy(Dietsch);

        Clauss.DisplayTeamsHistoric();
        Clauss.ChangeTeam(FCMetz);
        Clauss.DisplayTeamsHistoric();
        Clauss.ChangeTeam(FCLorient);
        Clauss.DisplayTeamsHistoric();

        FCLorient.DisplayPlayers();
        FCMetz.DisplayPlayers();
        OM.DisplayPlayers();
    }
}