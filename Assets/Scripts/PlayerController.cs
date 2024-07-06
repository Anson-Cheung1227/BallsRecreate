using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mosPosition = Input.mousePosition;
        Vector2 playerPosition = Camera.main.ScreenToWorldPoint(mosPosition);
        playerPosition.y = _player.gameObject.transform.position.y;
        _player.transform.position = playerPosition;
    }
}
