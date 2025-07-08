using UnityEngine;

namespace Grid {
    public class GridSystem {
        private int _sizeX;
        private int _sizeY;
        private int _cellSize;

        public GridSystem(int sizeX, int sizeY, int cellSize) {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _cellSize = cellSize;
        }

        public Vector3 GetWorldPosition(GridPosition gridPosition) {
            return new Vector3(gridPosition.X * _cellSize, 0, gridPosition.Z * _cellSize);
        }

        public GridPosition GetGridPosition(Vector3 worldPosition) {
            return new GridPosition(Mathf.RoundToInt(worldPosition.x / _cellSize),
                Mathf.RoundToInt(worldPosition.z / _cellSize));
        }
    }
}