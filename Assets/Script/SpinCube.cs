using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
  void Update()
  {
    transform.Rotate(20 * Time.deltaTime, 30 * Time.deltaTime, 50 * Time.deltaTime);
  }
}
