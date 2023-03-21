using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushDoor : MonoBehaviour
{
    public GameObject door;

    public float force = 1.0f;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Rigidbody>().AddForce(0, 0, force, ForceMode.Impulse);
    }
}
