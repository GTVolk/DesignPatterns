namespace DesiginPatterns.Patterns.Fundamental.ImmutableInterface
{
    class Point2D
    {
        private int x;
        private int y;
        public Point2D(int x, int y) { this.x = x; this.y = y; }

        public int GetX() { return this.x; }
        public int GetY() { return this.y; }

        public void SetX(int newX) { this.x = newX; }
        public void SetY(int newY) { this.y = newY; }
    }
}
