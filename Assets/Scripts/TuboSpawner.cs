using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuboSpawner : MonoBehaviour
{
    public TuboPool pool;
    public float maxTime;
    private float _currentTime;
    // Start is called before the first frame update
    void Start()
    {
        _currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        if( _currentTime >= maxTime)
        {
            _currentTime = 0;
            GameObject tubo = pool.GetInactiveGameObject();
            if (tubo)
            {
                tubo.SetActive(true);
                tubo.transform.position = new Vector2(transform.position.x,Random.Range(-3.0f,0.5f));
            }
        }
    }
}
