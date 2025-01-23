using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PatrolLerp : MonoBehaviour
{
    public Transform[] waypoints;


    public AnimationCurve curve;
    [Range(0, 1)]

    public float t;

    public int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        t += Time.deltaTime;

        if (t >= 1f)
        {
            t = 0f; 
            waypointIndex = (waypointIndex + 1) % waypoints.Length; 
        }

        Transform currentWaypoint = waypoints[waypointIndex];
        Transform nextWaypoint = waypoints[(waypointIndex + 1) % waypoints.Length];

        transform.position = Vector2.Lerp(currentWaypoint.position, nextWaypoint.position, curve.Evaluate(t));
    }
}
