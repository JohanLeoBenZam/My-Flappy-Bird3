using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour

{
    public KeyCode upKey;
    public float force;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        if(Input.GetKeyDown(upKey))
        {
            _rb.velocity = Vector2.up * force;
        }

#elif UNITY_ANDROID
    foreach(Touch touch in Input.touches)
    {
        if(touch.phase == TouchPhase.Began)
        {
            _rb.velocity = Vector2.up * force;
        }
    }
#endif
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Tubo>())
        {
            GameManager.instance.UpdatePoints();
        }
        else
        {
            GameManager.instance.ShowMenu();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.ShowMenu();
    }

}
