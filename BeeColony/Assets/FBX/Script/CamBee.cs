using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBee : MonoBehaviour
{

    public GameObject[] camPosition;

    public float camSpeed;

    Vector3 startCam;
    public static int levelCount = 0;
    public int _levelCount = 0;
    public bool debug = false;
    public static CamBee instace;
    // Start is called before the first frame update
    void Start()
    {
        instace = this;
        startCam = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, camPosition[levelCount].transform.position, camSpeed * Time.deltaTime);
        transform.rotation = camPosition[levelCount].transform.rotation;


        if (debug)
        {
            levelCount = _levelCount;
        }
    }

}
