using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public float seconds = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        seconds -= Time.deltaTime;
        textDisplay.text = ((int)seconds).ToString();
        if (seconds <= 0)
        {
            SceneManager.LoadScene("loseScene");
        }
    }
}
