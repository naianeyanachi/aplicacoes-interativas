using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDog : MonoBehaviour
{
  public WalkDog dog;
  public ParticleSystem hearts;

  void OnMouseDown()
  {
    hearts.Play();
  }
}
