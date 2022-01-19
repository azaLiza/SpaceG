using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveship : MonoBehaviour
{
    //1 - La vitesse de déplacement
    public Vector2 speed;

    //2 - Stockage du mouvement
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        
        // 3 - Récuperer les informations du clavier/manette
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        // 4 - Calcul du mouvement
        movement = new Vector2(speed.x * inputX,speed.y * inputY);

        GetComponent<Rigidbody2D> ().velocity = movement;
        
    }
}
