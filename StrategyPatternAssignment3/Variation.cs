using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment3
{

    abstract class Variation
    {
        public abstract decimal Cost(TShirt tshirt);
    }

    class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _colorCosts;

        static ColorVariation()
        {
            _colorCosts = new Dictionary<Color, decimal>()
            {
                { Color.BLUE, 1.0m },
                { Color.GREEN, 1.5m },
                { Color.INDIGO, 1.2m },
                { Color.ORANGE, 0.5m },
                { Color.RED, 1.8m },
                { Color.VIOLET, 2m },
                { Color.YELLOW, 3m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _colorCosts[tshirt.Color];
            return tshirt.Price;
        }
    }

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _sizeCosts;

        static SizeVariation()
        {
            _sizeCosts = new Dictionary<Size, decimal>()
            {
                { Size.XS, -1m },
                { Size.S, -0.5m },
                { Size.M, 0m },
                { Size.L, 0.5m },
                { Size.XL, 1m },
                { Size.XXL, 2m },
                { Size.XXXL, 3.5m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _sizeCosts[tshirt.Size];
            return tshirt.Price;
        }
    }

    class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _fabricVariations;

        static FabricVariation()
        {
            _fabricVariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASHMERE, 15m },
                { Fabric.COTTON, 5m },
                { Fabric.LINEN, 9m },
                { Fabric.POLYESTER, 6m },
                { Fabric.RAYON, 8m },
                { Fabric.SILK, 22m },
                { Fabric.WOOL, 12m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _fabricVariations[tshirt.Fabric];
            return tshirt.Price;
        }
    }
}
