using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Concurrency.Asynchronous.ValueTask
{
    public class ValueTaskMain
    {
        public static Dictionary<int, string> cardDictionary = new Dictionary<int, string>
        {
            { 1, "1 Card Info" },
            { 2, "2 Card info " },
            { 3, "3 Card info part I" },
            //{ 3, "3 Card info part I" }, not allowed to add duplicate key
            { 15, "15 Card info part II" },
            { 4, "4 Card info" },
            { 10, "10 Card info" }
        };
        public static async Task Main(string[] args)
        {
            //synchronous call
            var Card1Result = GetCardInfoAsync(1);
            Console.WriteLine(Card1Result);
            //asynchronous call
            var Card3Result = await GetCardInfoAsync(3);
            Console.WriteLine(Card3Result);
            //asynchronous call to 15
            var Card15Result = await GetCardInfoAsync(15);
            Console.WriteLine(Card15Result);
            //not found card
            var Card5Result = await GetCardInfoAsync(5);
            Console.WriteLine(Card5Result);
            Console.ReadKey();

        }
        //value task static method
        public static async ValueTask<string> GetCardInfoAsync(int cardId)
        {
            if(cardDictionary.ContainsKey(cardId))
            {
                return cardDictionary[cardId]; //synchronous return
            }
            var card = $"Card info {cardId} from database.";
            cardDictionary[cardId] = card;
            return await Task.FromResult(card); //asynchronous return
        }
    }
}
