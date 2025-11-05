using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 90f;

    private Vector2 moveInput;
    private Vector2 rotateInput;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnRotate(InputValue value)
    {
        rotateInput = value.Get<Vector2>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(move * moveSpeed * Time.deltaTime);

        float yaw = rotateInput.x * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * yaw);
        float yaw2 = rotateInput.y * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.left * yaw2);
    }

    public void OnColorChange1(InputValue value)
    {

    }
}
