using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatCaption : MonoBehaviour
{
    public float amp = 0.3f;
    public float freq = 0.3f;
    Vector3 initpos;

    private void Start()
    {
        initpos = transform.position;
    }
    private void Update()
    {
        transform.position = new Vector3(initpos.x,Mathf.Sin(Time.time * freq) * amp +  initpos.y, initpos.z);
    }
}
