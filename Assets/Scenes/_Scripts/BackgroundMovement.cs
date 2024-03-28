using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMovement : MonoBehaviour
{
    private float _bgSpeed = 5.0f;
    private Vector2 _startPosition;
    private float _halfWigth;

    private void Start()
    {
        _startPosition = transform.position;
        _halfWigth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _bgSpeed);

        if (transform.position.x < (_startPosition.x - _halfWigth))
        {
            transform.position = _startPosition;
        }
    }
}
