namespace Grid {
    public struct GridPosition {
        public int X { get; }
        public int Z { get; }

        public GridPosition(int x, int z) {
            this.X = x;
            this.Z = z;
        }


        public override string ToString() {
            return $"X: {X}, Z: {Z}";
        }
    }
}