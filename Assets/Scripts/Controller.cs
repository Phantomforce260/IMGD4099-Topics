using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // --- Mouse Look ---
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * 100f * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * 100f * Time.deltaTime;

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);

        // --- Movement ---
        float moveX = Input.GetAxis("Horizontal"); // A/D
        float moveZ = Input.GetAxis("Vertical");   // W/S

        float moveY = 0f;
        if (Input.GetKey(KeyCode.Space))
            moveY += 1f;
        if (Input.GetKey(KeyCode.LeftShift))
            moveY -= 1f;

        Vector3 move = transform.right * moveX + transform.forward * moveZ + transform.up * moveY;

        transform.position += moveSpeed * Time.deltaTime * move;
    }
}
