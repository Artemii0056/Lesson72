using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class CoinCollector : MonoBehaviour
{
    private PlayerMover _player;

    private void Start()
    {
        _player = GetComponent<PlayerMover>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.TryGetComponent<DestroyCoins>(out DestroyCoins destroyCoins))
        {
            _player.CollectedCoins();
        }
    }
}
