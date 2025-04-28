using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHive : MonoBehaviour
{
    public float moveSpeed;
    public float bootSpeed;
    public float startSpeed;
    public static bool move = true;
    public static bool moneyStart = false;

    Vector3 StartPostion;

    public static BeeHive instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        StartPostion = this.gameObject.transform.GetChild(1).transform.position;
        startSpeed = moveSpeed;
       
     
    }

    // Update is called once per frame
    void Update()
    {

        if (move)
        {
            this.gameObject.transform.GetChild(1).transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            if (this.gameObject.transform.GetChild(1).transform.position.y > 0.5)
            {
                this.gameObject.transform.GetChild(1).transform.position = StartPostion;
           
            }
            else if (this.gameObject.transform.GetChild(1).transform.position.y > 1.2)
            {
                this.gameObject.transform.GetChild(1).transform.position = StartPostion;          
            }
     
            if (Input.GetMouseButton(0))
            {
                moveSpeed = bootSpeed;
            }

            if (Input.GetMouseButtonUp(0))
            {
                moveSpeed = startSpeed;
            }

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    moveSpeed = bootSpeed;
                }

                if (touch.phase == TouchPhase.Moved)
                {
                    moveSpeed = startSpeed;
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    moveSpeed = startSpeed;

                }
            }
        }
            

    }
}
