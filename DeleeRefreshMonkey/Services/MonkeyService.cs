using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeleeRefreshMonkey.Models;
using DeleeRefreshMonkey.Services;

namespace DeleeRefreshMonkey.Services
{
    internal class MonkeyList
    {
        public List<Monkey> Monkeys { get; private set; }
        public MonkeyList()
        {
            this.Monkeys = new List<Monkey>();
            FillList();
        }

        private void FillList()
        {

            Monkeys.Add(new Monkey
            {
                Name = "Baboon",
                Location = "Asia",
                Details = "Baboons are African Old World monkeys.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "America",
                Details = "The capuchin monkeys are New World monkeys/",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Blue Monkey",
                Location = "Africa",
                Details = "The blue monkey or diademed monkey is a species of Old World monkey.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "America",
                Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Details = "The golden lion tamarin also known as the golden marmoset",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Howler Monkey",
                Location = "America",
                Details = "Howler monkeys are among the largest of the New World monkeys.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Israel",
                Details = "The Japanese macaque, is a terrestrial Old World monkey ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Mandrill",
                Location = "Israel",
                Details = "The mandrill is a primate of the Old World monkey family.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Snub-nosed Monkey",
                Location = "China",
                Details = "The golden snub-nosed monkey is an Old World monkey in the Colobinae subfamily.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });
        }
    }
    public class MonkeyService
    {
        public MonkeyService()
        {
            monkeys = new MonkeyList().Monkeys;
        }
        List<Monkey> monkeys;
        static Random random = new Random();
        public Monkey GetRandomMonkey()
        {
            int index = random.Next(0, monkeys.Count);
            return monkeys[index];
        }

        public void AddMonkey(Monkey monkey)
        {
            monkeys.Add(monkey);
        }

        public void RemoveMonkey(Monkey monkey)
        {
            monkeys.Remove(monkey);
        }

        public async Task<List<Monkey>> GetMonkeysByLocation(string location)
        {
            return monkeys.Where(m => m.Location == location).ToList();
        }
        public async Task<List<Monkey>> GetMonkeys()
        {
            return monkeys;
        }
    }
}
