using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class E3_15 : MonoBehaviour
{
    Material mat;
    public Transform target;
    private void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material = mat = new Material(rend.sharedMaterial);
    }
    void Update()
    {
        mat.SetVector("_Position", target.position);
    }
}
