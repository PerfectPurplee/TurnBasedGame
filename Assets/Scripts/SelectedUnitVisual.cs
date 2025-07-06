using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedUnitVisual : MonoBehaviour {
    private Unit _unit;

    private void Start() {
        _unit = GetComponentInParent<Unit>();
        UnitSelectionManager.Instance.OnNewUnitSelectedInManager += OnSelectedUnitChangedHandler;
    }

    private void OnSelectedUnitChangedHandler(Unit unit) {
        gameObject.SetActive(unit == _unit);
    }
}