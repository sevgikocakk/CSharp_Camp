using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*********************GAME SIMULATİON**********************");

            Console.WriteLine("\n---------------Oyuncu Bilgileri------------");

            Gamer gamer1 = new Gamer() { GamerName = "Engin", GamerLastname = "Demirog" , BirthYear = 1985};
            Gamer gamer2 = new Gamer() { GamerName = "Yasin", GamerLastname = "Kargan" };
            Gamer gamer3 = new Gamer() { GamerName = "Can", GamerLastname = "Alter" };

            IGamerServices gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer3);

            Console.WriteLine("\n---------------Oyun Bilgileri--------------");

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Stardew Valley";

            Game game2 = new Game() { GameId = 2, GameName = "Celeste" };
            Game game3 = new Game() {GameId=3, GameName = "Gris"};           

            IGameServices gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);

            Console.WriteLine("\n---------------Kampanya Bilgileri--------------");

            Campaign campaign1 = new Campaign();
            campaign1.CampName = "Kış Fırsatları!";
            campaign1.CampDate = "20.02.2021";

            Campaign campaign2 = new Campaign();
            campaign2.CampName = "Sömestr öğrenci indirimi!";
            campaign2.CampDate = "22.01.2021";

            Campaign campaign3 = new Campaign();
            campaign3.CampName = "Kış Fırsatları!";
            campaign3.CampDate = "20-03.2021";

            ICampaignServices campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            Console.WriteLine("\n---------------Kampanyalı Satış Bilgileri--------------");
            OrderManager orderManager = new OrderManager();
            orderManager.Add(campaign1);
            orderManager.Add(campaign2);
            orderManager.Add(campaign3);
            orderManager.Delete(campaign1);
            orderManager.Update(campaign2);
            






        }
    }
}
