using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    public float _Zoffset;
    public float _Yoffset;
    private Vector3 _offset;

    private void Start()
    {
        _offset = new Vector3 (_target.localPosition.x - transform.localPosition.x, transform.localPosition.y, 0);
    }

    private void Update()
    {
        transform.position = new Vector3(_target.localPosition.x, _Yoffset, _Zoffset) - _offset;
    }
}

