using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectIfAsteroid : MonoBehaviour
{

    public GameObject[] respawns;
    private Vector3 rightBottomCameraBorder;
    private Vector3 leftBottomCameraBorder;

    // Start is called before the first frame update
    void Start()
    {
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        respawns = GameObject.FindGameObjectsWithTag("Asteroid");
        if(respawns.Length < 100000){
            Debug.Log("more asteroides");

             float randomLocation = Random.Range(-5.0f,5.0f);
             Vector3 tmpPos = new Vector3 (rightBottomCameraBorder.x,randomLocation,0);
             GameObject gY = Instantiate(Resources.Load("Asteroid"), tmpPos, Quaternion.identity) as GameObject;
        }

    }
}
