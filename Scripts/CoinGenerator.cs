using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private Transform[] _coinPositions;

    private void Start()
    {
        for (int i = 0; i < _coinPositions.Length; i++)
        {
            Instantiate(_template, _coinPositions[i].position, _coinPositions[i].rotation);
        }       
    }
}
