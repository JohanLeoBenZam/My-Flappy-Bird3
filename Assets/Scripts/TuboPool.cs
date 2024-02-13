using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class TuboPool : MonoBehaviour
{
    private List<GameObject> _pool;
    public GameObject poolObject;
    public uint size;

    // Start is called before the first frame update
    void Awake()
    {
        Init(size);
    }
    public void Init(uint _size)
    {
        _pool = new List<GameObject>();

        for (int i = 0; i < _size; i++)
        {
            AddGameObjectToPool();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject AddGameObjectToPool()
    {
        GameObject obj = Instantiate(poolObject, transform);
        obj.SetActive(false);
        _pool.Add(obj);
        return obj;
    }

    public GameObject GetInactiveGameObject()
    {
        foreach (GameObject o in _pool)
        {
            if (!o.activeInHierarchy)
            {
                return o;
            }
        }
        return null;
    }
}
