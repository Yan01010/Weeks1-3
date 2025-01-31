using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoddessBehaviour : MonoBehaviour
{
    public float speed = 0.2f;
    public float height = 0.2f;
    private Vector3 startY;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startY.y + Mathf.Sin(Time.time * speed) * height * 0.5f;
        transform.position = new Vector3(startY.x, newY, startY.z);
    }
}
