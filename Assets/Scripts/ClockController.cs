using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    private float gameHours = 6;
    private float gameMinutes = 0;

    [SerializeField]
    private GameObject minuteHand, hourHand;

    void Update()
    {
        gameMinutes += Time.deltaTime;

        if (gameMinutes >= 60)
        {
            gameHours++;
            gameMinutes = 0;
        }

        float hoursAngle = (gameHours % 12) * 30 + (gameMinutes / 60f) * 30;
        float minutesAngle = (gameMinutes / 60f) * 360;

        // Áp dụng góc quay vào minuteHand
        minuteHand.transform.rotation = Quaternion.Euler(0, 0, -minutesAngle);
        hourHand.transform.rotation = Quaternion.Euler(0, 0, -hoursAngle);
    }
}
