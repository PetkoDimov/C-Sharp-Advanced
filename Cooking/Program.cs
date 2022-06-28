using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] liquidsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] ingredientsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> ingredients = new Stack<int>(ingredientsInput);
            Dictionary<string, int> cooked = new Dictionary<string, int>();
            cooked.Add("Bread", 0);
            cooked.Add("Cake", 0);
            cooked.Add("Pastry", 0);
            cooked.Add("Fruit Pie", 0);

            int sum = 0;
            int value = 0;

            while (true)
            {
                if (!liquids.Any())
                {
                    break;
                }
                else if (!ingredients.Any())
                {
                    break;
                }
                int currLiquid = liquids.Peek();
                int currIng = ingredients.Peek();
                sum = currIng + currLiquid;

                if (sum == 25)
                {
                    cooked["Bread"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 50)
                {

                    cooked["Cake"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 75)
                {
                    cooked["Pastry"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 100)
                {

                    cooked["Fruit Pie"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    int currElm = ingredients.Pop();
                    ingredients.Push(currElm + 3);
                }

            }
            if (cooked["Bread"] > 0 && cooked["Cake"] > 0 && cooked["Pastry"] > 0 && cooked["Fruit Pie"] > 0)
            {


                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }

            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (!liquids.Any())
            {
                Console.WriteLine("Liquids left: none");
            }
            else if (liquids.Any())
            {
                Console.Write($"Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }

            if (!ingredients.Any())
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {

                Console.Write($"Ingredients left: ");
                Console.WriteLine(string.Join(", ", ingredients));
            }

            cooked = cooked.OrderBy(k => k.Key).ThenBy(v => v.Value).ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in cooked)
            {
                Console.Write($"{item.Key}: ");
                Console.WriteLine($"{item.Value}");
            }
        }
    }
}