using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleUpdate : MonoBehaviour
{
    public TextMeshProUGUI content;
    public SubsActivation subtitles;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //content.text = subtitles[0];
        subtitles = gameObject.GetComponent<SubsActivation>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer == 0)
        {
            subtitles.gameObject.SetActive(true);
            subtitles.OnEnable();
        }
        else if (timer == 1.5f)
        {
            subtitles.ChangeSubs();
        }
        else if (timer == 6)
        {
            subtitles.ChangeSubs();
        }
        else if(timer >= 11)
        {
            subtitles.gameObject.SetActive(false);
        }
        //fale kai ta alla clips
    }


}
