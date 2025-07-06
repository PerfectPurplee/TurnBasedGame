using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    [SerializeField] private Animator unitAnimator;


    private Vector3 _targetPosition;

    public static event Action<Unit> OnUnitSelected;


    private void Update() {
        const float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, _targetPosition) > stoppingDistance) {
            Vector3 moveDirection = (_targetPosition - transform.position).normalized;
            const float moveSpeed = 4f;
            transform.position += moveDirection * (moveSpeed * Time.deltaTime);

            const float rotateSpeed = 10f;
            transform.forward = Vector3.Lerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);

            unitAnimator.SetBool("IsWalking", true);
        }
        else {
            unitAnimator.SetBool("IsWalking", false);
        }

    }

    public void Move(Vector3 targetPosition) {
        this._targetPosition = targetPosition;
    }

    private void OnMouseDown() {
        OnUnitSelected?.Invoke(this);
    }
    
}