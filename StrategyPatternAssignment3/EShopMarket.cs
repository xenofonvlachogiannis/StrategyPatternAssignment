using System;
using System.Collections.Generic;

namespace StrategyPatternAssignment3
{
    class EShopMarket
    {
        public static void EshopChoose()
        {
            Console.WriteLine("Welcome to my T-Shirt e-shop.");
            Console.WriteLine();
            Console.WriteLine("Please choose your T-shirt color. \n1) Red, 2) Orange, 3) Yellow, 4) Green, 5) Blue, 6) Indigo, 7) Violet");
            var tshirtColor = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            var color = ChooseColor(tshirtColor);

            Console.WriteLine("Please choose your T-shirt size. \n1) XS, 2) S, 3) M, 4) L, 5) XL, 6) XXL, 7) XXXL");
            var tshirtSize = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            var size = ChooseSize(tshirtSize);

            Console.WriteLine("Please choose your T-shirt fabric. \n1) Wool, 2) Cotton, 3) Polyester, 4) Rayon, 5) Linen, 6) Cashmere, 7) Silk");
            var tshirtFabric = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            var fabric = ChooseFabric(tshirtFabric);

            Console.Write("How would you like to pay? 1) Credit Card, 2) Bank Transfer, 3) Cash : ");
            var paymentType = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine();
            var paymentMethod = ChoosePaymentMethod(paymentType);
            var eshop = new Eshop();

            var variations = new List<Variation>() { new ColorVariation(), new FabricVariation(), new SizeVariation() };

            TShirt shirt = new TShirt(color, size, fabric);
            eshop.Variation(variations);
            eshop.SelectPaymentMethod(paymentMethod);
            eshop.PayTShirt(shirt);

        }

        public static Color ChooseColor(int tshirtColor)
        {
            switch (tshirtColor)
            {
                case 1:
                    return Color.RED;
                case 2:
                    return Color.ORANGE;
                case 3:
                    return Color.YELLOW;
                case 4:
                    return Color.GREEN;
                case 5:
                    return Color.BLUE;
                case 6:
                    return Color.INDIGO;
                case 7:
                    return Color.VIOLET;
                default:
                    Console.WriteLine("Doesn't choose a right input. We put the default color Blue.");
                    return Color.BLUE;
            }
        }

        public static Size ChooseSize(int tshirtSize)
        {
            switch (tshirtSize)
            {
                case 1:
                    return Size.XS;
                case 2:
                    return Size.S;
                case 3:
                    return Size.M;
                case 4:
                    return Size.L;
                case 5:
                    return Size.XL;
                case 6:
                    return Size.XXL;
                case 7:
                    return Size.XXL;
                default:
                    Console.WriteLine("Doesn't choose a right input. We put the default size Large.");
                    return Size.L;
            }
        }

        public static Fabric ChooseFabric(int tshirtFabric)
        {
            switch (tshirtFabric)
            {
                case 1:
                    return Fabric.WOOL;
                case 2:
                    return Fabric.COTTON;
                case 3:
                    return Fabric.POLYESTER;
                case 4:
                    return Fabric.RAYON;
                case 5:
                    return Fabric.LINEN;
                case 6:
                    return Fabric.CASHMERE;
                case 7:
                    return Fabric.SILK;
                default:
                    Console.WriteLine("Doesn't choose a right input. We put the default fabric Cotton.");
                    return Fabric.COTTON;
            }
        }

        public static PaymentMethod ChoosePaymentMethod(int paymentMethod)
        {
            switch (paymentMethod)
            {
                case 1:
                    return  new CreditCard();

                case 2:
                    return  new BankTransfer();

                case 3:
                    return  new Cash();

                default:
                    return  new CreditCard();

            }
        }
    }

}
