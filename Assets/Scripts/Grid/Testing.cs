using System.Collections;
using System.Collections.Generic;
using Grid;
using UnityEngine;

public class Testing : MonoBehaviour {
    private GridSystem _gridSystem;

    private void Start() {
        _gridSystem = new GridSystem(100, 100, 2);
    }

    void Update() {
        Debug.Log(_gridSystem.GetGridPosition(MouseWorld.GetPosition()));
    }
}