using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

/*  
*   To be used to add a timer
*   To be used to tip the teapot based on how long the timer has left
*   Teapot should range from values -90 to -140 or so
*/

public class TeapotTimer : MonoBehaviour
{
    [Header("Set in Inspector")]
    public TMP_Text timer;
    public int maxAngle;

    private int angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = -90;
        gameObject.transform.rotation = Quaternion.Euler(angle, 0, 0);

        int main = (Mathf.Abs(maxAngle-angle));
        int min = Mathf.FloorToInt(main / 60);
        int sec = main - min * 60;
        timer.text = min.ToString() + ":" + sec.ToString(); //25 seconds for difficulty
        InvokeRepeating("Timer", 1f, 1f); //call every second.
    }

    void Timer(){
        string[] time = timer.text.Split(":");
        int min = int.Parse(time[0]);
        int sec = int.Parse(time[1]);

        //if out of time, end.
        if (min == 0 && sec == 1){
            SceneManager.LoadScene("EndingScene");
        }

        if (sec == 0){
            min--;
            sec = 59;
        }
        else{
            sec--;
        }

        string seconds = sec.ToString();
        if (sec < 10){
            seconds = "0" + sec;
        }

        timer.text = min + ":" + seconds;

        angle -= 1;
        gameObject.transform.rotation = Quaternion.Euler(angle, 0, 0);
    }
}
