using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(0, _rotationSpeed, 0);
    }
}
