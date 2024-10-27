using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageDecorator
{
    public abstract class Beverage
    {
        protected Beverage() { }
        public abstract string Name { get; }
        public abstract int Cost { get; }
        public abstract int GetCost();
        public static Font Font { get => new Font("Arial", 14); }
        public virtual void Draw(Graphics g, Point topCenter, int size)
        {
            g.DrawEllipse(new Pen(Color.Black, 5), new Rectangle(topCenter.X - size / 2, topCenter.Y, size, size));

            var text = Name;
            var cost = Cost;
            if (cost % 1000 == 0)
            {
                cost = cost / 1000;
                text += $" {cost}k";
            }
            else
            {
                text += $" {cost / 1000f:#.0}k";
            }
            var sizeText = g.MeasureString(text, Font);
            g.DrawString(text, Font, new SolidBrush(Color.Blue), topCenter.X - sizeText.Width / 2, topCenter.Y + sizeText.Height / 3);
        }
    }

    public class Coffee : Beverage
    {
        public override string Name => "Coffee";
        public override int Cost => 25000;

        public override int GetCost()
        {
            return Cost;
        }
    }

    public class Tea : Beverage
    {
        public override string Name => "Tea";
        public override int Cost => 17000;

        public override int GetCost()
        {
            return Cost;
        }
    }

    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage wrapObj;
        protected CondimentDecorator(Beverage wrapObj)
        {
            this.wrapObj = wrapObj;
        }
        public override void Draw(Graphics g, Point topCenter, int size)
        {
            base.Draw(g, topCenter, size);
            var sizeText = g.MeasureString(Name, Font);
            topCenter.Y += (int)sizeText.Height * 4 / 3 + 5;
            wrapObj.Draw(g, topCenter, size - (int)sizeText.Height * 2);
        }
    }

    public class Pearl : CondimentDecorator
    {
        public Pearl(Beverage wrapObj) : base(wrapObj) { }
        public override string Name => "Pearl";
        public override int Cost => 3000;
        public override int GetCost()
        {
            return Cost + wrapObj.GetCost();
        }
    }

    public class FreshMilk : CondimentDecorator
    {
        public FreshMilk(Beverage wrapObj) : base(wrapObj) { }
        public override string Name => "FreshMilk";
        public override int Cost => 6000;
        public override int GetCost()
        {
            return Cost + wrapObj.GetCost();
        }
    }

    public class Aloe : CondimentDecorator
    {
        public Aloe(Beverage wrapObj) : base(wrapObj) { }
        public override string Name => "Aloe";
        public override int Cost => 3500;
        public override int GetCost()
        {
            return Cost + wrapObj.GetCost();
        }
    }
}
