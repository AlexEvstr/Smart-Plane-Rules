using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMovement : MonoBehaviour
{
    private float _questionSpeed = 2.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _questionSpeed);
    }
}
