using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private GameObject _canvas;
    public TextMeshProUGUI textMeshPro;
    private  int puntos;
    public GameObject _gameOverCanvas;
    void Awake()
    {
        if(!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Time.timeScale = 1f;

    }
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePoints()
    {
        Debug.Log("hola");
        puntos++;
        textMeshPro.text ="Points\n" + puntos.ToString();
    }

    public int getPuntos()
    {
        return puntos;
    }
    public void ShowMenu()
    {
        Instantiate(_gameOverCanvas);
        Debug.Log("acivado");
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
