﻿using Fractions;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Linq;

namespace RandomDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            //string[] input = Console.ReadLine().Split().ToArray();
            //int counter = 0;

            //while (true)
            //{
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        sb.Append(input[random.Next(0, input.Length)] + " ");
            //    }
            //    counter++;

            //    if (sb.ToString().TrimEnd() == string.Join(" ", input))
            //    {
            //        Console.WriteLine(counter);
            //        break;
            //    }
            //    sb.Clear();
            //}

            //for (int i = 0; i <= 10; i++)
            //    Console.WriteLine(random.Next());

            //for (int i = 0; i <= 10; i++)
            //    Console.WriteLine(random.Next(10, 101));

            //for (int i = 0; i <= 10; i++)
            //    Console.WriteLine(random.Next(100, 101));

            //for (int i = 0; i <= 10; i++)
            //    Console.WriteLine(random.Next(-100, 100));

            //Random randomWithSeed = new Random(5);

            //for (int i = 0; i < 10; i++)
            //Console.WriteLine(randomWithSeed.Next(20));


            //string inputDate = Console.ReadLine()!;

            //DateTime dateTime;

            //dateTime = DateTime.ParseExact(inputDate!, "d-M-yyyy", CultureInfo.InvariantCulture);

            //dateTime = new DateTime(int.Parse(inputDate.Split("-")[2]), 
            //    int.Parse(inputDate.Split("-")[1]), 
            //    int.Parse(inputDate.Split("-")[0]));

            //bool isOk = DateTime.TryParseExact(inputDate, 
            //    "d-M-yyyy", 
            //    CultureInfo.InvariantCulture, 
            //    DateTimeStyles.None, 
            //    out dateTime);

            //Console.WriteLine(dateTime.DayOfWeek);


            //var input1 = Console.ReadLine();
            //var input2 = Console.ReadLine();

            //DateCounter counter = new DateCounter();
            //counter.Name = "Pesho countera";

            ////counter.CalculateDifference(input1, input2);

            //DateCounter counterNew = counter;
            //counterNew.Name = "Bai Mitko countera";

            //Console.WriteLine(counter.Name);
            //Console.WriteLine(counterNew.Name);

            //string[] inputArr = Console.ReadLine().Split(" ").ToArray();
            //string sign = inputArr[1];
            //int[] intsFirst = inputArr[0].Split("/").Select(int.Parse).ToArray();
            //int[] intsSecond = inputArr[2].Split("/").Select(int.Parse).ToArray();

            //Fraction fractionOne = new Fraction(intsFirst[0], intsFirst[1]);
            //Fraction fractionTwo = new Fraction(intsSecond[0], intsSecond[1]);

            //if (sign == "+")
            //{
            //    Console.WriteLine($"{fractionOne} {sign} {fractionTwo} = {fractionOne + fractionTwo}");
            //}
            //else 
            //{
            //    Console.WriteLine($"{fractionOne} {sign} {fractionTwo} = {fractionOne - fractionTwo}");
            //}


            //PersonWithCopyConstructor personWithCopyCtor = new PersonWithCopyConstructor("Pesho", 22, 80.01);
            //PersonWithCopyConstructor secondPersonWithCopyCtor = new PersonWithCopyConstructor(personWithCopyCtor);

            //secondPersonWithCopyCtor.Name = "Muncho";
            //secondPersonWithCopyCtor.Age = 34;
            //secondPersonWithCopyCtor.Weight = 70.50;


            //Console.WriteLine(personWithCopyCtor.Name + " " + personWithCopyCtor.Age + " " + personWithCopyCtor.Weight);
            //Console.WriteLine(secondPersonWithCopyCtor.Name + " " + secondPersonWithCopyCtor.Age + " " + secondPersonWithCopyCtor.Weight);

            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //string color = Console.ReadLine();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = width; 
            //rectangle.Height = height;
            //rectangle.Color = color;

            //Console.WriteLine($"Rect({rectangle.Width}, {rectangle.Height}, {rectangle.Color}) has area {(rectangle.Width * rectangle.Height)}.");


            //Person person = new Person(88.01);
            //person.Name = "Muncho";
            //person.Age = 44;
            //Console.WriteLine($"{person.Name} {person.Age} {person.Weight} {(person.Proportion):f2}");

            //PersonWithStaticCtor personWithStatic = new PersonWithStaticCtor();
            //personWithStatic.Name = "Tralalayko";
            //personWithStatic.Age = 101;
            //personWithStatic.Weight = 88.20;
            //Console.WriteLine(string.Join(" ", personWithStatic.Name, personWithStatic.Age, personWithStatic.Weight));


            //List<Card> cards = new List<Card>();

            //Card firstCard = new Card() { Face = "A", Suit = "Spades" };
            //Card secondCard = new Card() { Face = "J", Suit = "Diamonds" };
            //Card thirdCard = new Card() { Face = "Q", Suit = "Clubs" };
            //Card fourthCard = new Card() { Face = "10", Suit = "Hearts" };

            //cards.Add(firstCard);
            //cards.Add(secondCard);
            //cards.Add(thirdCard);
            //cards.Add(fourthCard);

            //foreach (Card card in cards) 
            //{ 
            //    card.Print();
            //}

            //string[] faces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            //string[] suits = new string[4] { "Spades", "Diamonds", "Clubs", "Hearts" };

            //for (int i = 0; i < faces.Length; i++)
            //{
            //    foreach (string suit in suits)
            //    {
            //        cards.Add(new Card() { Face = faces[i], Suit = suit });                
            //    }
            //}

            //Random rnd = new Random();

            //for (int i = 0; i < cards.Count; i++) 
            //{ 
            //    int rIndex = rnd.Next(0, cards.Count);
            //    Card oldCard = cards[i];
            //    cards[i] = cards[rIndex];
            //    cards[rIndex] = oldCard;
            //}

            //foreach (Card card in cards)
            //{ 
            //    card.Print();
            //}

            //CardsDeck deck = new CardsDeck();

            //var input = Console.ReadLine();

            //while (input != "End")
            //{ 
            //    var cmd = input.Split(" ").ToArray();

            //    if (cmd[0] == "Add")
            //    {
            //        deck.Add(new Card() { Face = cmd[1], Suit = cmd[2] });
            //    }
            //    else if (cmd[0] == "Print")
            //    {
            //        deck.Print();
            //    }
            //    else if (cmd[0] == "Get")
            //    {
            //        deck.GetAllCards();
            //    }
            //    else if (cmd[0] == "Randomize")
            //    {
            //        deck.Randomize();
            //    }
            //    else if (cmd[0] == "Clear")
            //    {
            //        deck.Clear();
            //    }

            //    input = Console.ReadLine();
            //}

            //BigInteger big = new BigInteger();
            //big = 1;
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    big *= i;
            //}
            //Console.WriteLine(big);

            //StateOfMind state = StateOfMind.Depressed;

            //var excited = Enum.Parse(typeof(StateOfMind), "Excited");

            //Console.WriteLine((int)excited);

            Car car = new Car();

            car.Make = "Volga";
            car.Model = "4200";
            car.Year = 1972;

            Console.WriteLine($"Make {car.Make}\nModel {car.Model} \nYear {car.Year}");
        }
    }
}
