using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _xOffset;

    private Transform _birdTransform;
    // Start is called before the first frame update
    void Start()
    {
        _birdTransform = _bird.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_birdTransform.position.x + _xOffset, transform.position.y, transform.position.z);
    }
}
