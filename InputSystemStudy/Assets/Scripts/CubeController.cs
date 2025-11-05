using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 90f;

    private Vector2 moveInput;
    private Vector2 rotateInput;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotateInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, moveInput.y,0);
        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        float yaw = rotateInput.x * rotateSpeed * Time.deltaTime;
        transform.Rotate(-Vector3.up * yaw, Space.World);
        float yaw2 = rotateInput.y * rotateSpeed * Time.deltaTime;
        transform.Rotate(-Vector3.left * yaw2, Space.World);
    }

    public void OnColorChange1(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rend.material.color = Color.gray;
        }
    }

    public void OnColorChange2(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rend.material.color = Color.green;
        }
    }

    public void OnColorChange3(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rend.material.color = Color.red;
        }
    }

    public void OnColorChange4(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rend.material.color = Color.yellow;
        }
    }
}
