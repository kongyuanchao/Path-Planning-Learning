using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour {
    public enum CreatingMethod
    {
        CELL_GRID,
        WAYPOINTS
    }

    public CreatingMethod creationMethod;
    public Transform start, goal;

    public bool checkInIntervals;
    public float intervalTime;

    public Vector3 startPosition;
    public Vector3 goalPosition;

    
    [Range(float.NegativeInfinity, float.PositiveInfinity)] public float x;
    [Range(float.NegativeInfinity, float.PositiveInfinity)] public float y;
    [Range(float.NegativeInfinity, float.PositiveInfinity)] public float z;
    [Range(-360, 360)] public float rx;
    [Range(-360, 360)] public float ry;
    [Range(-360, 360)] public float rz;

    public bool isUpdatingGraph { get; private set; }

    private float _intervalTime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    //Debug.Log($"Voxel size:  {2} and Transform: {transform.position.ToString()}");
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        rx = transform.rotation.eulerAngles.x;
        ry = transform.rotation.eulerAngles.y;
        rz = transform.rotation.eulerAngles.z;

        Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.5f,0.5f,0.5f), Quaternion.identity);

        //if (colliders.Length > 0)
        //{
        //    Debug.Log("Inside collider1");
        //}

        foreach (var item in colliders)
        {
            Debug.Log($"Collide Object:  {item.gameObject.name}" );
        }
    }
}
