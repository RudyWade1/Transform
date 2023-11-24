using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private float _maxScale = 2;

    private void Update()
    {
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

        if (transform.localScale.x > _maxScale || transform.localScale.y > _maxScale || transform.localScale.z > _maxScale)
            transform.localScale = new Vector3(_maxScale, _maxScale, _maxScale);
    }
}
