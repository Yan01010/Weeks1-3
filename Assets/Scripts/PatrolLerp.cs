using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PatrolLerp : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public Transform A;
    public Transform B;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(A.position, B.position, curve.Evaluate(t));
    }
}
