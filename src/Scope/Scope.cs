using PowerOff.Primitives;
using System;

namespace PowerOff
{
    public class Scope
    {
        public Scope() //ctor for main scope
        { Parrent = null; }
        public Scope(Scope parent)
        { Parrent = parent; }

        public SymbolTable<Point> Points { get; } = new();
        public SymbolTable<Line> Lines { get; } = new();
        public SymbolTable<Circle> Circles { get; } = new();

        //---

        public Scope? Parrent { get; private set; }
    }
}
