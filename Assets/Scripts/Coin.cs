using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private Transform _coinTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _coinTransform.Translate(Vector2.left*_speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
