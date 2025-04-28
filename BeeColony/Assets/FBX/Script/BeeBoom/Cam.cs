using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject Bullet;

    public float posSpeed;
    public float rotSpeed;

    public float horizontalSpeed;
    public float verticalSpeed;

    float rotHeight;
    float rotWidth;

    Vector2 point;

    public float fireRate;

    public GameObject TargetIcon;

    private bool control = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Fire()
    {
        control = true;
        transform.GetChild(0).transform.localEulerAngles = new Vector3(-45 * point.y, 30 * point.x, 0);
        GameObject Bulletobj = Instantiate(Bullet,transform.position,Quaternion.identity);
        Bulletobj.tag = "Bullet";
        Bulletobj.GetComponent<Bullet>().gun = transform;
        Destroy(Bulletobj, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            Vector2 pos = touch.position;

            Vector2 rot = touch.deltaPosition;


            if (touch.phase == TouchPhase.Moved)
            {
                TargetIcon.transform.position = touch.position;

                rotHeight = horizontalSpeed * rot.y * rotSpeed * Time.deltaTime;

                rotWidth = verticalSpeed * rot.x * rotSpeed * Time.deltaTime;

                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,transform.localEulerAngles.y + rot.x * rotSpeed * Time.deltaTime, transform.localEulerAngles.z);

                if(control)
                {
                    Invoke("Fire", fireRate);
                    control = false;
                }

                point = new Vector2(((pos.x-Screen.width/2)*2)/Screen.width, ((pos.y - Screen.height / 2) * 2) / Screen.height);
               
            }

            if (touch.phase == TouchPhase.Ended)
            {

            }

            if (touch.phase == TouchPhase.Began)
            {
              

               
            }
        }
    }
}







//rb.MovePosition(new Vector3(input.moveData.y * speed, 0, -input.moveData.x * speed) + transform.position);
//rb.AddForce(new Vector3(input.moveData.y * speed, 0, -input.moveData.x * speed)-rb.velocity,ForceMode.VelocityChange);
//rb.AddForce(new Vector3(input.moveData.y * speed, 0, -input.moveData.x * speed),ForceMode.Impulse);
//transform.LookAt(new Vector3(transform.position.x + input.moveData.x, transform.position.y, transform.position.z + input.moveData.y));



//if (Input.touchCount > 0)
//{

//    Touch touch = Input.GetTouch(0);

//    if (touch.phase == TouchPhase.Moved)
//    {
//

//    }

//    if (touch.phase == TouchPhase.Ended)
//    {
//    }

//    if (touch.phase == TouchPhase.Began)
//    {
//    }
//}

//if (boomBee)
//{
// PC ÜZerine Çalýþan 
//    if (Input.GetMouseButton(0))
//    {
//        height = horizontalSpeed * Input.GetAxis("Mouse Y") * m_Speed * Time.deltaTime;

//        width = verticalSpeed * Input.GetAxis("Mouse X") * m_Speed * Time.deltaTime;

//        cam.transform.Rotate((height), (width), 0, Space.World);

//        bulletSendSpeed -= Time.deltaTime;

//        currentPosition = Input.mousePosition;

//        TargetIcon.transform.position = currentPosition;

//        lazer = Camera.main.ScreenPointToRay(currentPosition);

//        if (Physics.Raycast(lazer, out hit, lazer_Distance))
//        {
//            if (bulletSendSpeed <= 2)
//            {
//                GameObject Bulletobj = Instantiate(Bullet, cam.gameObject.transform.GetChild(0).transform.position, Bullet.transform.rotation);

//                Bulletobj.transform.position = Vector3.MoveTowards(Bulletobj.transform.position, hit.collider.gameObject.transform.position, bulletSpeed);

//                bulletSendSpeed = 3;

//                Destroy(Bulletobj, 3.5f);
//            }
//        }
//    }

//}
