using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HiveYellow : MonoBehaviour

{
    public float moveSpeed;
    public float bootSpeed;
    public float startSpeed;
    public bool move = false;

    public Vector3 StartPostion;

    public static float staticY = float.MinValue;

    public static HiveYellow instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        if (staticY == float.MinValue)
        {
            staticY = transform.position.y;

        }

        StartPostion = new Vector3(transform.position.x, staticY, transform.position.z);

        moveSpeed = bootSpeed / 10;

        startSpeed = bootSpeed / 10;

        move = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HiveCollider")
        {
            MoneyCanvas.instance.moneyCanvas = true;
            MoneyCanvas.instance.transform.gameObject.SetActive(true);
            Debug.Log("Temas var");
        }
    }

    void Update()
    {

        if (move)
        {
            //transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            if (transform.position.y > 0.5)
            {
                transform.position = StartPostion;
            }
            else if (transform.position.y > 1.2)
            {
                transform.position = StartPostion;
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


            if (moveSpeed == bootSpeed && control==false)
            {
                control = true;

                InvokeRepeating("GiveMoney", 0, 0.5f);
            }
        }


    }
    static bool control = false;
    void GiveMoney()
    {
        MoneyCanvas.scoreUI += (int)(MoneyButtons.moneyHoney);
        if (moveSpeed == startSpeed)
        {
            CancelInvoke("GiveMoney");
            control = false;
        }
    }
}
