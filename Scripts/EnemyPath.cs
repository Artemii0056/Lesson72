using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyPath : MonoBehaviour
{
    [SerializeField] private Vector3[] _wayPoints;
    [SerializeField] private int _wayDuration;

    private void Start()
    {
        Tween tween = transform.DOPath(_wayPoints, _wayDuration, PathType.CatmullRom).SetOptions(true);

        tween.SetEase(Ease.Linear).SetLoops(-1);
    }
}
