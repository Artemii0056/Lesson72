using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private PlayerMover Player;

    private void Start()
    {
        Player = GetComponent<PlayerMover>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.TryGetComponent<DestroyCoins>(out DestroyCoins destroyCoins))
        {
            Player.CollectedCoins();
        }
    }
}
