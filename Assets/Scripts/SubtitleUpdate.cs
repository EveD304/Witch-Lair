using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleUpdate : MonoBehaviour
{
    public string[] subtitles = { "Hello there!", "It's time to make some potions and have fun trying different combinations.", "How about you start by picking up one of the flasks sitting right there on your left?" };
    public TextMeshProUGUI content;
    
    // Start is called before the first frame update
    void Start()
    {
       content.text = subtitles[0];
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
