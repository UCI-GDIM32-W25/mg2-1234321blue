using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform _spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeCoin();
    }
    void MakeCoin()
    {
        int random = Random.Range(0,1200);
        Debug.Log(random);
        if(random==1199)
        { 
           Instantiate(_coin,_spawn);
        }
    }
}
