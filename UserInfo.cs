using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nisse_oppgave
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool ToiletPaperOutward { get; set; }
        public bool DonatesToCharity { get; set; }
        public bool WashesHands { get; set; }
        public string[] MusicGenres { get; set; }
        public string HomeAdress { get; set; }
        public string CarModel { get; set; }
    }
}