using UnityEngine;

public class TagAndPositionMoving : MonoBehaviour
{
  private Vector3 lastPosition;

  void Start() {
    string objectTag = gameObject.tag;
    lastPosition = transform.position;
    Debug.Log(objectTag + ": " + $"({lastPosition.x}; {lastPosition.y}; {lastPosition.z})");
  }

  void Update() {
    Vector3 newPosition = transform.position;
    if (newPosition != lastPosition) {
      string objectTag = gameObject.tag;
      lastPosition = transform.position;
      Debug.Log(objectTag + ": " + $"({lastPosition.x}; {lastPosition.y}; {lastPosition.z})");
    }
  }
}
