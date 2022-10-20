using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Decorator
{
    internal class ShapeDecorator : IShape
    {
        private IShape wrapee;

        public ShapeDecorator(IShape wrapee)
        {
            this.wrapee = wrapee;
        }

        public override void draw()
        {
            this.wrapee.draw();
        }
    }

    class RedDecorator : ShapeDecorator
    {
        public RedDecorator(IShape wrapee) : base(wrapee) { }
        public override void draw()
        {
            base.draw();
            Console.Write(", in Red color");
        }
    }

    class GreenDecorator : ShapeDecorator
    {
        public GreenDecorator(IShape wrapee) : base(wrapee) { }
        public override void draw()
        {
            base.draw();
            Console.Write(", in Green color");
        }
    }
}
