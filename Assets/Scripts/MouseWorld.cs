using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ReSharper disable All

public class MouseWorld : MonoBehaviour
{

    private static MouseWorld instance;


    [SerializeField] private LayerMask mousePlaneLayerMask;

    private void Awake()
    {
        instance = this;
    }

    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main!.ScreenPointToRay(pos: Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLayerMask);
        return raycastHit.point;
    }

}