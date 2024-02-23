using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private Outline outline; // Tham chiếu đến script "Outline" của đối tượng

    void Start()
    {
        // Lấy tham chiếu đến script "Outline" của đối tượng
        outline = GetComponent<Outline>();
        // Tắt script "Outline" khi bắt đầu game
        outline.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Kiểm tra nếu nhân vật tiếp xúc với đối tượng
        if (other.CompareTag("Player"))
        {
            // Bật script "Outline" khi nhân vật tiếp cận
            outline.enabled = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            // Bật script "Outline" khi nhân vật tiếp cận
            outline.enabled = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            // Bật script "Outline" khi nhân vật tiếp cận
            outline.enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Kiểm tra nếu nhân vật rời xa đối tượng
        if (other.CompareTag("Player"))
        {
            // Tắt script "Outline" khi nhân vật rời xa
            outline.enabled = false;
        }
    }
}
