using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuEndLevel : MonoBehaviour {
    public Button btnQuit;
    public Button btnContinue;

    // Use this for initialization
    void Start()
    {
        btnQuit.GetComponent<Button>().onClick.AddListener(OnQuit);
        btnContinue.GetComponent<Button>().onClick.AddListener(OnContinue);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnQuit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                         Application.Quit();
        #endif
    }

    void OnContinue()
    {
        SceneManager.LoadScene("Level_01");
    }
}
