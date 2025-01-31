using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : MonoBehaviour
{
    public int starNum = 50;
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCircles();
    }

    void SpawnCircles()
    {
        // Get the camera's boundaries in world space
        Camera camera = Camera.main;
        float screenWidth = camera.orthographicSize * camera.aspect;
        float screenHeight = camera.orthographicSize;

        for (int i = 0; i < starNum; i++)
        {
            // Generate random position within the camera's view
            Vector3 randomPosition = new Vector2(Random.Range(-screenWidth, screenWidth),
                                                 Random.Range(-screenHeight, screenHeight));

            GameObject newCircle = Instantiate(circle, randomPosition, Quaternion.identity);
            newCircle.transform.localScale = new Vector2(0.1f, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
