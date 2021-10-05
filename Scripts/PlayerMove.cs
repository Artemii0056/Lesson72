using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _checkRadius;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _ground;

    private const string _isRun = "IsRun";
    private const string _jump = "Jump";

    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private float _speed = 2;
    private float _jumpForce = 8f;
    private int _collectedCoins = 0;
    private int _jumpCount = 1;
    private bool _onGround;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animator.SetBool(_isRun, true); 
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animator.SetBool(_isRun, true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            _animator.SetBool(_isRun, false);
        }

        _onGround = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _ground);

        if (_onGround == true)
        {
            _jumpCount = 1;
        }

        if (Input.GetKey(KeyCode.Space) == true && _jumpCount > 0)
        {
            _rigidbody.velocity = _jumpForce * Vector2.up;
            _animator.Play(_jump);
            _jumpCount--;
            Debug.Log(_jumpCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<DestroyCoins>(out DestroyCoins destroyCoins))
        {
            _collectedCoins++;
            Debug.Log(_collectedCoins);
        }
    }
}
