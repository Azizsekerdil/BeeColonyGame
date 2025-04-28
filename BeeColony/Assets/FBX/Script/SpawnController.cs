using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public int nextBee = 5;

    public float waitTime = 0.5f;

    private bool waitting = false;

    GameObject BeeWorker;

    public GameObject Bees;

    public Transform BeeBrith;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Spawn()
    {
        waitting = false;
       
        BeeWorker = Instantiate(Bees,BeeBrith.position, BeeBrith.rotation);

        Debug.Log("Spawn Adet");
    }

    // Update is called once per frame
    void Update()
    {
        if(!waitting && nextBee> 0 )
        {
            Invoke("Spawn",waitTime);
            nextBee--;
            waitting = true;
        }
    }
}
