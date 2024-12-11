namespace Nisse_oppgave
{
    public class Elves
    {
        public string Elf { get; set; }
        public string Specialty { get; set; }
        public string[] Gift { get; set; }

        public Elves(string elf, string specialty, string[] gift)
        {
            Elf = elf;
            Specialty = specialty;
            Gift = gift;
        }

        public override string ToString()
        {
            return $"Gift: {Gift}.";
        }
    }

    public class ElfGift
    {
        public List<Elves> Elves { get; set; }
        public string[] WoodElfGifts = {"Trebil", "Gyngehest", "Fruktbolle"};
        public string[] ElectronicElfGifts = {"Keyboard", "Mobil", "Elektrisk gitar"};
        public string[] SewingElfGifts = {"Kjøkkenforkle", "Sengetøy", "Dekorasjonspute"};
        public string[] SmithingElfGifts = {"Stekepanne", "Verktøykasse", "Skulptur i metall"};
        public string[] CeramicElfGifts = {"Kaffekrus", "Vase", "Dekorasjonshus"};

        public ElfGift()
        {
            Elves = new List<Elves>
            {
                new Elves("Alvin", "WoodWorking", WoodElfGifts),
                new Elves("Alvhild", "Electronics", ElectronicElfGifts),
                new Elves("Alva", "Sewing", SewingElfGifts),
                new Elves("Gustalv", "Smithing", SmithingElfGifts),
                new Elves("Toralv", "Ceramics", CeramicElfGifts),
            };
        }

        public void GetGift(string specialty)
        {
            var gifter = Elves.Find(e => e.Specialty.Equals(specialty, StringComparison.OrdinalIgnoreCase));
            if(gifter != null)
            {
                Random random = new Random();
                int i = random.Next(0,3);
                string elfGift = gifter.Gift[i];
                Console.WriteLine(elfGift);
            }
        }
    }
}