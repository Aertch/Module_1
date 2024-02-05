using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class ScoreboardManager : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    void Start()
    {
        countText.text = "Count: 0";
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        count++;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }
}
