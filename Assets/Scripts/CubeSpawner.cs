using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    [SerializeField] private Transform _start;

    [SerializeField] private int _x, _y;

    [SerializeField] private float _size;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _x; ++i)
        {
            for (int e = 0; e < _y; ++e)
            {
                GameObject instance = Instantiate(_cubePrefab, _start);
                instance.transform.position = new Vector2(_start.position.x + i * _size, _start.position.y - e * _size);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
