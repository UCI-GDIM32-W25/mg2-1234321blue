using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform _spawn;
    float random;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0f,4f);
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        SpawnCoin();
        
    }
    void SpawnCoin()
    {
        
        if(timer>=random)
        {
            Instantiate(_coin,_spawn);
            timer=0;
            random = Random.Range(0f,4f);
        }
    }
}
