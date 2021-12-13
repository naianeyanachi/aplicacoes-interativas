using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimalBasicAI : MonoBehaviour
{
  public HappinessBar happinessBar;
  public HungerBar hungerBar;

  private float happiness;
  public float Happiness
  {
    get { return this.happiness; }
    set
    {
      if (value < 0) this.happiness = 0;
      else if (value > 100) this.happiness = 100;
      else this.happiness = value;
    }
  }
  private float hunger;
  public float Hunger
  {
    get { return this.hunger; }
    set
    {
      if (value < 0) this.hunger = 0;
      else if (value > 100) this.hunger = 100;
      else this.hunger = value;
    }
  }

  private WalkDog walkDog;

  // Start is called before the first frame update
  void Start()
  {
    this.Happiness = 50f;
    this.happinessBar.SetMaxHappiness(100f);
    this.happinessBar.SetHappiness(this.Happiness);
    this.Hunger = 70f;
    this.hungerBar.SetMaxHunger(100f);
    this.hungerBar.SetHunger(this.Hunger);

    this.walkDog = this.gameObject.GetComponent<WalkDog>();
  }

  // Update is called once per frame
  void Update()
  {
    this.Happiness = this.Happiness - 0.05f;
    this.happinessBar.SetHappiness(this.Happiness);

    this.Hunger = this.Hunger - 0.01f;
    this.hungerBar.SetHunger(this.Hunger);
  }

  // UI: Joao

  public void Feed()
  {
    if (!walkDog.walking)
    {
      this.Hunger += 5f;
      hungerBar.SetHunger(this.Hunger);
    }
  }
}
