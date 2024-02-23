using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private TMP_Text message;
    private float maxHealth = 100;
    private float curHeath = 100;

    float temp = 0;

    public static System.Action OnEatAction;

    private void Start()
    {
        OnEatAction = OnEat;
    }

    void OnEat()
    {
        curHeath += 10;
        slider.value = curHeath / maxHealth;
    }

    private void Update()
    {
        temp += Time.deltaTime;
        if (temp >= 5)
        {
            curHeath -= 1;
            temp = 0;
            slider.value = curHeath / maxHealth;
        }
        if (!message.gameObject.active && curHeath <= 50)
        {
            message.gameObject.SetActive(true);
        }
        if (message.gameObject.active && curHeath > 50)
        {
            message.gameObject.SetActive(false);
        }
    }

}
