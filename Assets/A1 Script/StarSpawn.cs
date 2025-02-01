using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : MonoBehaviour
{
    public int starNum = 50;
    public GameObject circle;
    public GameObject bg1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCircles();
    }

    void SpawnCircles()
    {
        Camera camera = Camera.main;
        float screenWidth = camera.orthographicSize * camera.aspect;
        float screenHeight = camera.orthographicSize;

        for (int i = 0; i < starNum; i++)
        {
            //random position within the camera's view
            Vector3 randomPosition = new Vector2(Random.Range(-screenWidth, screenWidth),
                                                 Random.Range(-screenHeight, screenHeight));

            GameObject newCircle = Instantiate(circle, randomPosition, Quaternion.identity);
            newCircle.transform.localScale = new Vector3(0.1f, 0.1f, 0.4f);

            newCircle.transform.SetParent(bg1.transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
