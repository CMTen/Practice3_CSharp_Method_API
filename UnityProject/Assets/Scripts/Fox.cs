using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0, 99)]
    public float speed = 10f;
    private float High = 150f;

    public Rigidbody2D Rig;
    public SpriteRenderer SR;

    private float thrust = 3.0f;

    private void Update()
    {
        if (Input.GetKey("d"))
        {
            SR.flipX = false;
            Input.GetAxisRaw("Horizontal");
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            SR.flipX = true;
            Input.GetAxisRaw("Horizontal");
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyDown("w"))
        {
            Rig.AddForce(new Vector2(0, 1000));
        }
    }
}
