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

    public bool isUpdatingGraph { get; private set; }

    private float _intervalTime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    //Debug.Log($"Voxel size:  {2} and Transform: {transform.position.ToString()}");
    startPosition = transform.position;
    goalPosition = transform.rotation.eulerAngles;
    }
}
