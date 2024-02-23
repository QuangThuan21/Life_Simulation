using UnityEngine;
using UnityEngine.UI;

public class CheckCollision : MonoBehaviour
{
    private Outline outline;

    [SerializeField]
    private Button useBtn;
    [SerializeField]
    private GameObject musicPanel;
    void Start()
    {
    }

    void OnTVClick()
    {
        musicPanel.SetActive(true);
    }

    void OnDinnerTableClick()
    {
        HealthController.OnEatAction.Invoke();
    }

    void OnChairClick()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        outline = collision.gameObject.GetComponent<Outline>();
        if (outline != null)
        outline.enabled = true;

        switch (collision.gameObject.tag)
        {
            case "TV":
                useBtn.gameObject.SetActive(true);
                useBtn.onClick.RemoveAllListeners();
                useBtn.onClick.AddListener(OnTVClick);
                break;
            case "Chair":
                useBtn.gameObject.SetActive(true);
                useBtn.onClick.RemoveAllListeners();
                useBtn.onClick.AddListener(OnChairClick);
                break;
            case "Dinner Table":
                useBtn.gameObject.SetActive(true);
                useBtn.onClick.RemoveAllListeners();
                useBtn.onClick.AddListener(OnDinnerTableClick);
                break;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        outline = collision.gameObject.GetComponent<Outline>();
        if (outline != null)
            outline.enabled = false;

        
        useBtn.gameObject.SetActive(false);
        
    }

}
