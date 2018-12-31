using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using AliasPair = Examen.OrderedPair<int>;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //---- COURS 1 -----

            //NewContact();
            //ChangeContactNumber();
            //ShowContactNumber();
            //NewDies();
            //NewPairOfDies();
            //NewCity();

            //---- COURS 2 -----

            //NewPerson();
            //HeritageEmployee();

            //---- COURS 3 -----
            // UML
            //---- COURS 4 -----

            //PointTranslation();
            //InterfaceComplex();
            //MathOverloading();
            //GenericPair();
            //GenericOrderedPair();
            //GenericMethod();
            //AliasMethode();

            //---- COURS 5 -----

            //EncapsVector();
            //StateSortedPair();
            //ChangeVector();

            //---- COURS 6 -----

            //TotalPriceItems();
            //UtilsItem();
            //IncreaseInstanceCounter();
            //IncreaseSuperInstanceCounter();
            //ItemParser();
            //InnerOuterClass();
            //CreateLinkedList();
            //TypeInfoAndTest();
            //InvoquerMethode();
            //InstanceCreation();

            //---- COURS 7 -----


        }
        //---- COURS 1 -----

        public static void NewContact()
        {
            Contact marchand = new Contact(" Cédric ", " Marchand ");
            Console.WriteLine(marchand);
        }

        public static void ChangeContactNumber()
        {
            Contact marchand = new Contact(" Cédric ", " Marchand ");
            marchand.SetPhoneNumber(8172); // this fera référence
            Console.WriteLine(marchand); // à marchand
        }

        public static void ShowContactNumber()
        {
            Contact marchand = new Contact(" Cédric ", " Marchand ");
            marchand.PhoneNumber = 666;
            Console.WriteLine(marchand.PhoneNumber);
        }

        public static void NewDies()
        {
            Die d1 = new Die(); // Dé à 6 faces
            Die d2 = new Die(12); // Dé à 12 faces

            Console.WriteLine(d1.VisibleFace);
            Console.WriteLine(d2.VisibleFace);
        }

        public static void NewPairOfDies()
        {
            PairOfDice dice = new PairOfDice(6);
            dice.PrintFaces(); // 1, 3
        }

        public static void NewCity()
        {
            Citizen philippe = new Citizen(" Philippe ", " Melotte ");

            City woluwe = new City("Woluwé -Saint - Lambert ");
            woluwe.ChangeMayor(philippe);
        }

        //---- COURS 2 -----
        // absence de Pair et orderedPair car conflit avec futur code

        public static void NewPerson()
        {
            DateTime birthday = new DateTime(1996, 2, 18);
            Person arno = new Person(" Arno Feelters ", birthday);
        }

        public static void HeritageEmployee()
        {
            // avec shitbull et overide base.name
            DateTime HB = new DateTime(1992, 4, 21);
            Employee flemal = new Employee("C. Flemal ", HB, 3200);
            Console.WriteLine(flemal);
        }

        //---- COURS 3 -----
        // UML
        //---- COURS 4 -----

        public static void PointTranslation()
        {
            ColouredPoint cp = new ColouredPoint(1, 2, Color.Red);
            Console.WriteLine(cp);
            Console.WriteLine(cp.Translate(1, 0));
        }

        public static void InterfaceComplex()
        {
            List<Complex> list = new List<Complex>
                {
                    new CartesianComplex(2, -1),
                    new PolarComplex(2, Math.PI / 2),
                    new CartesianComplex(-1, 1)
                };

            double a = 0;
            double b = 0;
            foreach (Complex c in list)
            {
                a += c.Real();
                b += c.Imag();
            }

            Complex sum = new CartesianComplex(a, b);
            Console.WriteLine(sum);
        }

        public static void MathOverloading()
        {
            byte b = 12;
            short s = 43;
            int i = 90;
            //long l = 123;
            Overloading overloading = new Overloading();
            // overloading.Test(l, i); Long not cast in int
            overloading.Test(s, i);
            overloading.Test(b, i);
            // overloading.Test(i, s); case not exist
        }

        public static void GenericPair()
        {
            Pair<string, int> p = new Pair<string, int>(" Tom ", 21);
            Console.WriteLine(p);
            Pair<string, Pair<int, int>> q = new Pair<string, Pair<int, int>>(" Tom"
            , new Pair<int, int>(187, 98));
            Console.WriteLine(q);
        }

        public static void GenericOrderedPair()
        {
            OrderedPair<int> p = new OrderedPair<int>(12, 3);
            Console.WriteLine(p);
            OrderedPair<string> q = new OrderedPair<string>(" trois ", " douze ");
            Console.WriteLine(q);
        }

        public static T max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void GenericMethod()
        {
            Console.WriteLine(max(12, 7));
            Console.WriteLine(max(" sept ", " douze "));
        }

        public static void AliasMethode()
        {
            AliasPair p = new AliasPair(12, 3);
            Console.WriteLine(p);
        }

        //---- COURS 5 -----

        public static void EncapsVector()
        {
            Vector2D u = new Vector2D(1, -1);

            Console.WriteLine(u);
        }

        public static void StateSortedPair()
        {
            SortedPair p = new SortedPair(12, 9);
            p.X = 42;
        }

        public static void ChangeVector()
        {
            Vector u = new Vector(new double[] { 1, -1 });
            Console.WriteLine(u);
            double[] data = u.Coords;
            data[0] = 0;
            Console.WriteLine(u);
        }

        //---- COURS 6 -----

        public static void TotalPriceItems()
        {
            Dictionary<Item, int> purchases = new Dictionary<Item, int>()
            {
                { new Item("42X", " Leffe des vignes ", 14.50) , 10} ,
                { new Item(" 1101 ", " MacBook Pro ", 1799.99) , 1}
            };

            double totalprice = 0;
            foreach (KeyValuePair<Item, int> entry in purchases)
            {
                totalprice += entry.Key.GetPrice(entry.Value);
            }
            Console.WriteLine(totalprice);
        }

        public static void UtilsItem()
        {
            Item beer = new Item("42X", " Leffe des vignes ", 14.50);
            Console.WriteLine(Utils.GetTaxIncPrice(beer.GetPrice(1)));
        }

        public static void IncreaseInstanceCounter()
        {
            new InstanceCounter();
            Console.WriteLine(InstanceCounter.Counter);

            new InstanceCounter();
            Console.WriteLine(InstanceCounter.Counter);
        }

        public static void IncreaseSuperInstanceCounter()
        {
            new SuperInstanceCounter();
            new SuperInstanceCounter();
            Console.WriteLine(SuperInstanceCounter.Counter);
        }

        public static void ItemParser()
        {
            Item beer = Item.ParseItem("42X; Leffe des vignes ;14.50 ");
            Console.WriteLine(beer);
        }

        public static void InnerOuterClass()
        {
            Outer outer = new Outer();
            Outer.Inner inner = new Outer.Inner(outer);
            Console.WriteLine(inner);
        }

        public static void CreateLinkedList()
        {
            LinkedList<string> data = new LinkedList<string>();
            Console.WriteLine(data.Size + " : " + data);

            data.addFirst("un");
            data.addLast(" deux ");
            Console.WriteLine(data.Size + " : " + data);

            data.addLast(" trois ");
            data.addLast(" quatre ");
            data.addFirst(" zéro ");
            Console.WriteLine(data.Size + " : " + data);
        }

        public static void TypeInfoAndTest()
        {
            Item beer = new Item("42X", " Leffe des vignes ", 14.50);
            Type type = beer.GetType();

            if (type == typeof(Item))
            {
                Console.WriteLine(" Oui ! " + type);
            }

            foreach (FieldInfo info in type.GetFields(BindingFlags.NonPublic |
            BindingFlags.Static))
            {
                Console.WriteLine(info);
            }
        }

        public static void InvoquerMethode()
        {
            Type type = typeof(Item);
            MethodInfo info = type.GetMethod(" GetPrice ");
            Console.WriteLine(info.ReturnType);

            Object o = Activator.CreateInstance(type, new Object[] { "42X", "Leffe des vignes ", 14.50 });
            double price = (double)type.InvokeMember(" GetPrice ",
            BindingFlags.InvokeMethod, null, o, new Object[] { 10 });
            Console.WriteLine(price);
        }

        public static void InstanceCreation()
        {
            Item beer = (Item)Activator.CreateInstance(typeof(Item),
            new Object[] { "42X", " Leffe des vignes ", 14.50 });
            Console.WriteLine(beer.GetPrice(1));
        }

        //---- COURS 7 -----


    }
}


