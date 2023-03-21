using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject spawnTarget;
    public GameObject logSpawn;
    public GameObject playerPrefab;
    public GameObject door1;
    GameObject door2;
    public GameObject door2Prefab;
    public Transform door2Spawn;
    public Camera mainCam;

    GameObject player;
    Camera playerCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = Instantiate(playerPrefab) as GameObject;
            player.transform.position = spawnTarget.transform.position;
            door1.SetActive(true);
            if (door2 != null)
                Destroy(door2);
            door2 = Instantiate(door2Prefab) as GameObject;
            door2.transform.position = door2Spawn.position;
            playerCam = player.GetComponentInChildren<Camera>();
            playerCam.enabled = true;
            mainCam.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(player);
            player = Instantiate(playerPrefab) as GameObject;
            player.transform.position = logSpawn.transform.position;
        }
        
        if (playerCam == null)
        {
            Debug.Log("Player Camera not available");
            mainCam.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
