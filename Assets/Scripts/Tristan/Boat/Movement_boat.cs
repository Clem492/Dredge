using UnityEngine;

public class Movement_boat : MonoBehaviour
{
    float speed = 5f;
    float speed_rotation = 25f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * move);

        // Rotation gauche / droite
        float rotation = Input.GetAxis("Horizontal") * speed_rotation * Time.deltaTime;
        transform.Rotate(Vector3.up * rotation);
    }
}
