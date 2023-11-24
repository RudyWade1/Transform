using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    private float _maxScale = 2;

    private void Update()
    {
        transform.position += transform.forward * _moveSpeed * Time.deltaTime;
        transform.Rotate(0, _rotationSpeed, 0);
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

        if (transform.localScale.x > _maxScale || transform.localScale.y > _maxScale || transform.localScale.z > _maxScale)
            transform.localScale = new Vector3(_maxScale, _maxScale, _maxScale);
    }
}
