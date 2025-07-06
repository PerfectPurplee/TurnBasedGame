using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectionManager : MonoBehaviour {
    [SerializeField] private Unit selectedUnit;
    public static UnitSelectionManager Instance { get; private set; }
    public event Action<Unit> OnNewUnitSelectedInManager;
    private bool _selectionPress = false;


    private void Awake() {
        Instance = this;
    }

    private void Start() {
        Unit.OnUnitSelected += SetSelectedUnit;
    }


    private void Update() {
        if (Input.GetMouseButtonDown(0) && !_selectionPress) {
            selectedUnit.Move(MouseWorld.GetPosition());
        }
        else {
            _selectionPress = false;
        }
    }

    private void SetSelectedUnit(Unit unit) {
        selectedUnit = unit;
        _selectionPress = true;

        OnNewUnitSelectedInManager?.Invoke(selectedUnit);
    }
}