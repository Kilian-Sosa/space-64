using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour {
    private float startTime;
    private float remainingTime = 55f;
    private bool timerRunning = true;

    void Start() {
        startTime = Time.time;
    }

    void Update() {
        if (timerRunning) {
            remainingTime += Time.deltaTime;

            string minutes = (Mathf.Floor(Mathf.Round(remainingTime) / 60)).ToString();
            string seconds = (Mathf.Round(remainingTime) % 60).ToString();

            if (minutes.Length == 1) { minutes = "0" + minutes; }
            if (seconds.Length == 1) { seconds = "0" + seconds; }

            GameObject.Find("Timer").GetComponent<TMP_Text>().text = minutes + ":" + seconds;
        }
    }

    public void StopTimer() {
        timerRunning = false;
    }
}
