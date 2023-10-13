using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TMPro;



public class sliderPercentageManager : MonoBehaviour
{
    

    public TextMeshProUGUI soundText;
    public TextMeshProUGUI musicText;
    public TextMeshProUGUI heroText;

    public Slider soundSlider;
    public Slider musicSlider;
    public Slider heroSlider;

    // Start is called before the first frame update
    void Start()
    {
        soundSlider.onValueChanged.AddListener(delegate { changeTextValue(soundSlider, soundText); });
        musicSlider.onValueChanged.AddListener(delegate { changeTextValue(musicSlider, musicText); });
        heroSlider.onValueChanged.AddListener(delegate { changeTextValue(heroSlider, heroText); });
    }



    public void changeTextValue(Slider slider, TextMeshProUGUI textMesh)
    {
        textMesh.SetText(slider.value + "%");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
