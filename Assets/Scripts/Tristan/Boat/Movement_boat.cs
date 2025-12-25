using UnityEngine;

public class Movement_boat : MonoBehaviour
{
    // float qui determine la vitesse de deplacement et de rotation 
    float speed = 5f;
    float speed_rotation = 25f;

    //recuperer particule
    [SerializeField] GameObject particle;

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

        //on active si il y a un deplacement les particules
        if (move != 0)
        {
            particle.SetActive(true);
        }

        //on active si il y a une rotation les particules
        if (rotation != 0)
        {
            particle.SetActive(true);
        }

        //si il y a aucun mouvement on desactive
        else if(move ==0 && rotation == 0)
        {
            particle.SetActive(false);
        }
    }
}
