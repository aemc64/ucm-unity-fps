using System;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Waypoints")] // Adds a header on top of these fields
    [SerializeField] private Transform _waypoint1;
    [SerializeField] private Transform _waypoint2;

    [Header("Movement")]
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private float _distanceToStop = 2.0f;

    private Transform _currentWaypoint;
    private float _distanceToStopSqr;

    private void Awake()
    {
        transform.position = _waypoint1.position;
        _currentWaypoint = _waypoint2;
        _distanceToStopSqr = _distanceToStop * _distanceToStop;
    }

    private void Update()
    {
        Vector3 dirToWaypoint = _currentWaypoint.position - transform.position;
        if (dirToWaypoint.sqrMagnitude <= _distanceToStopSqr) // More efficient than using dirToWaypoint.magnitude <= _distanceToStopSqr
        {
            _currentWaypoint = _currentWaypoint == _waypoint1 ? _waypoint2 : _waypoint1;
        }
        
        Vector3 dirToWaypointNormalized = dirToWaypoint.normalized;
        transform.position += Time.deltaTime * _speed * dirToWaypointNormalized;
    }
}
