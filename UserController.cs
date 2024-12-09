using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Nisse_oppgave.Models;

namespace Nisse_oppgave
{
    public class UserController
    {
        public string[] GoodCarList { get; set; }
        public string[] GoodMusicList{get; set;}
        public string[] GoodStreetNames { get; set; }
        public GoodAndBadUsers GoodOrBadSorter(List<UserInfo> users) {
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

                foreach (var item in user.MusicGenres)
                {
                    if(GoodMusicList.Contains(item)){
                        score += 1;
                    }
                    
                }
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
            GoodAndBadUsers goodAndBadUsers = new();
            goodAndBadUsers.GoodUser = goodUser;
            goodAndBadUsers.BadUser = badUser;
            return goodAndBadUsers;
        }
    

    public void Gryla(GoodAndBadUsers badUsers) {
        Random random = new Random();
        foreach (var item in badUsers.BadUser)
        {
            int chance = random.Next(0,100);
            if (chance < 10) {
                Console.WriteLine(item.Name + " ble tatt av Gryla!");
            }
        }
    }

    public GoodAndBadUsers Gift(GoodAndBadUsers goodAndBadUsers) {
        
        Random random = new Random();
        foreach (var item in goodAndBadUsers.BadUser)
        {
            
            int chance = random.Next(0,100);
            if (chance < 10) {
                Console.WriteLine(item.Name + " ble tatt av Gryla!");
                item.Gift = "Gryla";

            }else {
                Console.WriteLine(item.Name + " fikk kull til jul");
            }


        }

        foreach (var item in goodAndBadUsers.GoodUser)
        {
         int chance = random.Next(0,100);
         switch (chance)
         {
            case int i when i > 0 && i > 20:
            default:
         }   
        }

        return goodAndBadUsers;
    }
}}
   