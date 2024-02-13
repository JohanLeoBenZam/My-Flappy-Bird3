using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public GameObject _movilCanvas;
 
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID
        gameObject.SetActive(false);
        Instantiate(_movilCanvas,transform);
#endif
    }

}
