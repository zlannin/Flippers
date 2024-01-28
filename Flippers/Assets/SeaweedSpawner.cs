using UnityEngine;

public class SeaweedSpawner : MonoBehaviour
{
    public GameObject Seaweed;

    public float SpawnRate = 2;

    private float timer = 0;
    private int heightOffset = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnSeaweed();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnSeaweed();
            timer = 0;
        }
    }

    void SpawnSeaweed()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;
        
        Instantiate(Seaweed, new Vector3(transform.position.x, Random.Range(lowestHeight, heightOffset), 0), transform.rotation);
    }
}
