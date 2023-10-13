using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ChangeMenu : MonoBehaviour
{
    public List<Canvas> canvasList;

    int currentMenu = 0;

    public float transSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swapMenu(int newMenu)
    {

        //exitAnim(currentMenu);
        //entryAnim(newMenu);

        StartCoroutine(exitRoutine(currentMenu));
        
        
        StartCoroutine(entryRoutine(newMenu));

        

        
    }

    IEnumerator exitRoutine(int menu)
    {
        if (menu == 0)
        {
            for (float i = 1.0f; i < 1.75f; i += 0.05f)
            {
                canvasList[menu].scaleFactor = i;
                yield return new WaitForSeconds(.01f);
            }
            canvasList[menu].enabled = false;
        }
        else
        {
            for (float i = 1.0f; i > 0f; i -= 0.05f)
            {
                canvasList[menu].scaleFactor = i;
                yield return new WaitForSeconds(.01f);
            }
            canvasList[menu].enabled = false;
        }
        
    }

    IEnumerator entryRoutine(int menu)
    {
        canvasList[menu].enabled = true;
        if (menu == 0)
        {
            for (float i = 1.75f; i > 1.0f; i -= 0.05f)
            {
                canvasList[menu].scaleFactor = i;
                yield return new WaitForSeconds(.01f);
            }
        }
        else
        {
            for (float i = 0f; i < 1.05f; i += 0.05f)
            {
                canvasList[menu].scaleFactor = i;
                yield return new WaitForSeconds(.01f);
            }
        }
        currentMenu = menu;
    }

    //handles exit animations
    private void exitAnim(int menu)
    {
        if(menu == 0)
        {
            for (float i = 1.0f; i < 1.75f; i += 0.05f)
            {
                canvasList[menu].scaleFactor = i;
            }
        }
        else
        {
            for (float i = 1.0f; i > 0f; i -= 0.1f)
            {
                canvasList[menu].scaleFactor = i;
            }
        }


        //canvasList[menu].enabled = false;
    }
    //handles entry animations
    private void entryAnim (int menu)
    {
        //canvasList[menu].enabled = true;
        //Invoke("swapEnabled", 1f);

       

        if (menu == 0)
        {
            for (float i = 1.75f; i > 1.0f; i -= 0.05f)
            {
                canvasList[menu].scaleFactor = i;
            }
        }
        else
        {
            for (float i = 0f; i < 1.0f; i += 0.1f)
            {
                canvasList[menu].scaleFactor = i;
            }
        }
        
    }

    void swapEnabled(int menu)
    {
        canvasList[menu].enabled = !canvasList[menu].enabled;
    }

    IEnumerator changeCanvasSize(float newSize, int menu)
    {
        canvasList[menu].scaleFactor = newSize;
        yield return null;
    }
}
