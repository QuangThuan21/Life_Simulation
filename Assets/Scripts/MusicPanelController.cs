using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPanelController : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip music1, music2, music3;

    [SerializeField]
    private Button play1Btn, play2Btn, play3Btn, closeBtn, pauseBtn;

    bool isPause = false;

    private void Start()
    {
        closeBtn.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            audioSource.Pause();
            audioSource.clip = null;
        });

        play1Btn.onClick.AddListener(() => 
        {
            audioSource.clip = music1;
            audioSource.Play();
            pauseBtn.gameObject.SetActive(true);
            isPause = false;
        });

        play2Btn.onClick.AddListener(() =>
        {
            audioSource.clip = music2;
            audioSource.Play();
            pauseBtn.gameObject.SetActive(true);
            isPause = false;
        });

        play3Btn.onClick.AddListener(() =>
        {
            audioSource.clip = music3;
            audioSource.Play();
            pauseBtn.gameObject.SetActive(true);
            isPause = false;
        });

        pauseBtn.onClick.AddListener(() =>
        {
            Debug.Log(isPause);
            if (isPause == false)
            {
                audioSource.Pause();
                pauseBtn.GetComponentInChildren<Text>().text = "Tiếp tục";
                isPause = true;
            }
            else
            {
                audioSource.UnPause();
                pauseBtn.GetComponentInChildren<Text>().text = "Tạm Dừng";
                isPause = false;
            }
        });
    }
}
