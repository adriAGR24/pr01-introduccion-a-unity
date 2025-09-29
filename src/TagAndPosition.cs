using UnityEngine;

public class TagAndPosition : MonoBehaviour
{
  void Start()
  {
    string objectTag = gameObject.tag;
    Vector3 objectPosition = transform.position;
    Debug.Log(objectTag + ": " + $"({objectPosition.x}; {objectPosition.y}; {objectPosition.z})");
  }
}