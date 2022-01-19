using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posShip : MonoBehaviour
{
    private Vector3 rightTopCameraBorder;
    private Vector3 leftTopCameraBorder;
    private Vector3 rightBottomCameraBorder;
    private Vector3 leftBottomCameraBorder;

    private Vector3 siz;

    // Start is called before the first frame update
    void Start()
    {
        leftBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
        rightBottomCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));
        leftTopCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0));
        rightTopCameraBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));

    }

    // Update is called once per frame
    void Update()
    {

        siz.x = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;

        //Debug.Log(rightTopCameraBorder);
        if(transform.position.x <= leftBottomCameraBorder.x+(siz.x/2)){
            transform.position = new Vector3 (leftBottomCameraBorder.x+(siz.x/2),transform.position.y,0);
        }
        if(transform.position.y <= leftBottomCameraBorder.y+(siz.y/2)){
            transform.position = new Vector3 (transform.position.x,leftBottomCameraBorder.y+(siz.y/2),0);
        }
        if(transform.position.y >= rightTopCameraBorder.y-(siz.y/2)){
            transform.position = new Vector3 (transform.position.x,rightTopCameraBorder.y-(siz.y/2),0);
        }
        if(transform.position.x >= rightTopCameraBorder.x-(siz.x/2)){
            transform.position = new Vector3 (rightTopCameraBorder.x-(siz.x/2),transform.position.y,0);
        }

    }
}