using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubo : MonoBehaviour
{
    private float maxTime = 5;
    private float _currenTime;
    public float speed;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _currenTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _currenTime += Time.deltaTime;

        if( _currenTime >= maxTime)
        {
            _currenTime = 0;
            gameObject.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        _rb.velocity = Vector2.left * speed;
    }
}
