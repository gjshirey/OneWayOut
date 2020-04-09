using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
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
        if (col.collider.CompareTag("Key"))
        {
            //Add unlock code here

            //Destroy object last
            Destroy(col.collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
