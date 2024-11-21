using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody _targetRb;
    private float _minSpeed = 13;
    private float _maxSpeed = 18;
    private float _maxTorque = 40;
    private float _xRange = 4;
    private float _ySpawnPos = -6;

    void Start()
    {
        _targetRb = GetComponent<Rigidbody>();
        _targetRb.AddForce(Vector3.up * Random.Range(_minSpeed, _maxSpeed), ForceMode.Impulse);
        _targetRb.AddTorque(
            Random.Range(-_maxTorque, _maxTorque),
            Random.Range(-_maxTorque, _maxTorque),
            Random.Range(-_maxTorque, _maxTorque)
        );
        _targetRb.transform.position = new Vector3(Random.Range(-_xRange, _xRange), _ySpawnPos, 0);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
