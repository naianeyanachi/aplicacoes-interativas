using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDog : MonoBehaviour
{
  public AnimalBasicAI dog;
  public ParticleSystem hearts;
  public HappinessBar happinessBar;

  void OnMouseDown()
  {
    hearts.Play();
    dog.Happiness += 5f;
    happinessBar.SetHappiness(dog.Happiness);
  }
}
