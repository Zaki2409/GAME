using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roller : MonoBehaviour
{
    [SerializeField] float yRot = 0f;
    void Update() {
        transform.Rotate(0, yRot, 0);
    }  
  
}
