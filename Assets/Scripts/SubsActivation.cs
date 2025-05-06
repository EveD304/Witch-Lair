using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubsActivation : MonoBehaviour
{
    public TextMeshProUGUI content;
    string[] subtitles = { "Hello there!", "It's time to make some potions and have fun trying different combinations.", "How about you start by picking up one of the flasks sitting right there on your left?" };
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        ChangeSubs();
    }

    public void ChangeSubs()
    {
        content.text = subtitles[i];
        i += 1;
    }
}
