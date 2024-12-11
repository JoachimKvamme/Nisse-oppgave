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
         int chance = random.Next(0,4);
         ElfGift elfGift = new ElfGift();
         switch (chance)
         {
            case 0:
                Console.WriteLine(item.Name + " får gave av trealven.");
                item.Elf = "Trealven";
                elfGift.GetGift("WoodWorking");
                Console.WriteLine($"{item.Name} fikk {item.Gift}");
                break;
            case 1:
                Console.WriteLine(item.Name + " får gave av sømalven.");
                item.Elf = "Sømalven";
                elfGift.GetGift("Sewing");
                Console.WriteLine($"{item.Name} fikk {item.Gift}");
                break;
            case 2:
                Console.WriteLine(item.Name + " får gave av strømalven.");
                item.Elf = "Strømalven";
                elfGift.GetGift("Electronics");
                Console.WriteLine($"{item.Name} fikk {item.Gift}");
                break;
            case 3:
                Console.WriteLine(item.Name + " får gave av smiealven.");
                item.Elf = "Smiealven";
                elfGift.GetGift("Smithing");
                Console.WriteLine($"{item.Name} fikk {item.Gift}");
                break;
            case 4:
                Console.WriteLine(item.Name + " får gave av keramikkalven.");
                item.Elf = "Keramikkalven";
                elfGift.GetGift("Ceramics");
                Console.WriteLine($"{item.Name} fikk {item.Gift}");
                break;
            default:
                break;
         }   
        }

        return goodAndBadUsers;
    }
}}
   