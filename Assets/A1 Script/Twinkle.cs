using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    public float Speed;   // Speed of the twinkling effect (higher is faster)
    public float minOpacity = 0f;       // Minimum opacity (fully transparent)
    public float maxOpacity = 1f;

    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Speed = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float alpha = Mathf.Lerp(minOpacity, maxOpacity, Mathf.PingPong(Time.time * Speed, 1f));
        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, alpha);
    }
}
