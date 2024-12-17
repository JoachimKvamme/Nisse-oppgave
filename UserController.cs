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
                        break;
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
    


    public GoodAndBadUsers Gift(GoodAndBadUsers goodAndBadUsers) {
        
        Random random = new Random();
        foreach (var item in goodAndBadUsers.BadUser)
        {
            
            int chance = random.Next(0,10);
            if (chance == 0) {
                Console.WriteLine(item.Name + " ble tatt av Gryla!");
                item.Gift = "Gryla";

            }else {
                Console.WriteLine(item.Name + " fikk kull til jul");
                item.Gift = "Kull";
            }


        }

        foreach (var item in goodAndBadUsers.GoodUser)
        {
         int chance = random.Next(0,5);
         switch (chance)
         {
            case 0:
                Console.WriteLine(item.Name + " får gave av trealven.");
                item.Elf = "Trealven";
                break;
            case 1:
                Console.WriteLine(item.Name + " får gave av sømalven.");
                item.Elf = "Sømalven";
                break;
            case 2:
                Console.WriteLine(item.Name + " får gave av strømalven.");
                item.Elf = "Strømalven";
                break;
            case 3:
                Console.WriteLine(item.Name + " får gave av smiealven.");
                item.Elf = "Smiealven";
                break;
            case 4:
                Console.WriteLine(item.Name + " får gave av keramikkalven.");
                item.Elf = "Keramikkalven";
                break;
            default:
                break;
         }   
        }

        

        return goodAndBadUsers;
    }

public void GetGift(List<UserInfo> goodUsers,  Dictionary<string, List<string>> elves)
        {
            
            foreach (var user in goodUsers)
            {
                Random random = new Random();
                int i = random.Next(0,3);
                string gift = elves[user.Elf][i];
                user.Gift = gift;
                Console.WriteLine(user.Name + $" fikk {gift}");
            }
        
        }

}}
   
