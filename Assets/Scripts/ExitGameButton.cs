using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class ExitGameButton : MonoBehaviour
{
    public Button gameExitButton;
    public TextMeshProUGUI exitText;
    public GameObject textObj;

    bool isPressedOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameExitFunction()
    {
        if(isPressedOnce == false)
        {
            textObj.SetActive(true);
            isPressedOnce = true;
        }
        else if (isPressedOnce == true)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
}
