using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMain : MonoBehaviour {
    public Button btnQuit;
    public Button btnStart;

    // Use this for initialization
    void Start () {
        btnQuit.GetComponent<Button>().onClick.AddListener(OnQuit);
        btnStart.GetComponent<Button>().onClick.AddListener(OnStart);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnQuit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }

    void OnStart()
    {
        SceneManager.LoadScene("Level_01");
    }
}
