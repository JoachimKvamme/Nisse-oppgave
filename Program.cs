using System.Text.Json;
using Nisse_oppgave.Models;

namespace Nisse_oppgave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        UserController userController = new UserController();
        userController.GoodCarList = ["Ford Fiesta", "Volkswagen Golf", "Toyota Corolla", "Honda Civic", "Chevrolet Cruze",
        "BMW 3 Series", "Audi A4", "Mercedes-Benz C-Class", "Hyundai Elantra", "Nissan Altima",
        "Kia Optima", "Mazda3", "Subaru Impreza", "Volkswagen Passat", "Toyota Camry",
        "Honda Accord", "Chevrolet Malibu", "Ford Fusion", "Nissan Maxima", "Hyundai Sonata",
        "Kia Stinger", "BMW 5 Series", "Audi A6", "Mercedes-Benz E-Class", "Lexus ES",
        "Jaguar XF", "Volvo S60", "Alfa Romeo Giulia", "Tesla Model 3", "Porsche Panamera",
        "Chevrolet Impala", "Chrysler 300", "Dodge Charger",];
        userController.GoodMusicList = ["Pop", "Rock", "Hip Hop", "Jazz", "Classical",
        "Electronic", "Country", "R&B", "Reggae", "Blues",
        "Metal", "Soul", "Funk", "Disco", "Punk",
        "Folk", "Gospel", "Latin", "Ska", "House",
        "Techno", "Trance", "Dubstep", "Ambient", "Indie",
        "Grunge", "K-Pop", "J-Pop", "Opera", "Swing",
        "Bluegrass", "Afrobeat", "Salsa", "Merengue"];
        userController.GoodStreetNames = ["Aad Gjelles gate", "Abels gate", "Absalon Beyers gate", "Adolph Bergs vei", "Agnes Mowinckels gate",
        "Allégaten", "Allehelgens gate", "Amalie Skrams vei", "Arbeidergaten", "Armauer Hansens vei",
        "Arne Garborgs gate", "Arnoldus Reimers' gate", "Asbjørnsens gate", "Astrups vei", "Asylplassen",
        "Baglergaten", "Baneveien", "Bankgaten", "Bispengsgaten", "Bjerregårds gate",
        "Bjørnsons gate", "Blaauws vei", "Bontelabo", "Bradbenken", "Bredalsmarken",
        "Bredsgården", "Breistølen", "Breiviksveien", "Bryggen", "Bøhmergaten",
        "C. Sundts gate", "Christian Michelsens gate", "Christies gate", "Cort Piil-Smauet", "Damsgårdsveien",
        "Dreggsallmenningen", "Engen", "Fabrikkgaten"];

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        string jsonString = File.ReadAllText("./randomPeople.json");
        
        List<UserInfo> users = JsonSerializer.Deserialize<List<UserInfo>>(jsonString, options);

        GoodAndBadUsers goodAndBadUsers = userController.GoodOrBadSorter(users);

        userController.Gift(goodAndBadUsers);

    }

    }
