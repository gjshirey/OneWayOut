using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{

    public string keyName = "Key";

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
            
            //Destroy object last
            Destroy(col.collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
