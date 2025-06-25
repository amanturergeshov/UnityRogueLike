using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private MobileJoystick mobileJoystick;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rigbody;
    void Start()
    {
        rigbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigbody.linearVelocity = mobileJoystick.GetMoveVector() * moveSpeed * Time.deltaTime;

    }
}
