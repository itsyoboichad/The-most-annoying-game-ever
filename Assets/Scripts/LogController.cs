using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController : MonoBehaviour
{
    public GameObject logPrefab;

    GameObject newLog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Log"))
        {
            Destroy(other.gameObject);
            newLog = Instantiate(logPrefab) as GameObject;
            newLog.transform.position = transform.position;
        }
    }
}
