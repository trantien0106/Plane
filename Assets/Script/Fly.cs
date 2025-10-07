using UnityEngine;

public class Fly : MonoBehaviour
{

    public float speed = 10f;       // tốc độ bay thẳng
    public float rotationSpeed = 50f; // tốc độ xoay

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Luôn bay về phía trước
        rb.linearVelocity = -transform.forward * speed;

        // Điều khiển xoay bằng phím
        float h = Input.GetAxis("Horizontal"); // A/D hoặc mũi tên trái/phải
        float v = Input.GetAxis("Vertical");   // W/S hoặc mũi tên lên/xuống

        // Quay máy bay
        transform.Rotate(Vector3.up * h * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right * -v * rotationSpeed * Time.deltaTime);
    }

    void BackMain()
    {
        
    }

}
