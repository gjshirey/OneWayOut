using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{

    public string keyName = "Key";
    public string doorName = "MasterDoor";
    public float xangle = -90;
    public float yangle = 0;
    public float zangle = 0;


    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag(keyName))
        {
            //Unlock door
            //get Door Game Object
            //Make sure to set the doorName for each door
            //GameObject[] Door = GameObject.FindGameObjectsWithTag(doorName);
            Door = GameObject.Find(doorName);
            Door.transform.Rotate(xangle,yangle,zangle, Space.Self);
            //Destroy object last
            Destroy(col.collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
