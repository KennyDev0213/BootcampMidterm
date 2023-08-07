using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Wire : MonoBehaviour
{
    public Transform[] points;

    LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.SetPositions(GetVectors());
    }

    Vector3[] GetVectors()
    {
        Vector3[] vectorPoints = new Vector3[points.Length];

        for (int i = 0; i < points.Length; i++)
        {
            vectorPoints[i] = points[i].position;
        }

        return vectorPoints;
    }

}
