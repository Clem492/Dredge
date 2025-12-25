using UnityEngine;

public class Movement_boat : MonoBehaviour
{
    // float qui determine la vitesse de deplacement et de rotation 
    float speed = 5f;
    float speed_rotation = 25f;

 
    void Update()
    {
        //appelle de la fonction deplacement
        Move();
    }

    
    //fonction deplacement
    void Move()
    {
        // avancer / reculer
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * move);

        // Rotation gauche / droite
        float rotation = Input.GetAxis("Horizontal") * speed_rotation * Time.deltaTime;
        transform.Rotate(Vector3.up * rotation);
    }
}
