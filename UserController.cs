using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nisse_oppgave
{
    public class UserController
    {
        public string[] GoodCarList { get; set; }
        public string[] GoodMusicList{get; set;}
        public string[] GoodStreetNames { get; set; }
        public void GoodOrBadSorter(List<UserInfo> users) {
            List<UserInfo> goodUser = new();
            List<UserInfo> badUser = new();

            foreach (var user in users)
            {
                int score = 0;
                if (user.WashesHands == true) {
                    score +=1;
                }
                if(user.DonatesToCharity == true) {
                    score += 1;
                }
                if(GoodCarList.Contains(user.CarModel)) {
                    score += 1;
                }
                // if(GoodMusicList.Contains(user.MusicGenres)){

                // }
                if(GoodStreetNames.Contains(user.HomeAdress)) {
                    score +=1;
                }

                if(score > 2) {
                    goodUser.Add(user);
                } else {
                    badUser.Add(user);
                }
            }
            foreach (var item in goodUser)
            {
                Console.WriteLine($"Good: {item.Name}");
            }
            foreach (var item in badUser)
            {
                Console.WriteLine($"Bad: {item.Name}");
            }
        }
    }
}