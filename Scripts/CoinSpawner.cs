using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform[] _coinPossition;

    private void Start()
    {
        for (int i = 0; i < _coinPossition.Length; i++)
        {
            Instantiate(_coin, _coinPossition[i].position, _coinPossition[i].rotation);
        }    
    }
}
