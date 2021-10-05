using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour
{
    [SerializeField] private GameObject _coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMove>(out PlayerMove playerMove))
        {
            Destroy(_coin);
        }
    }
}
