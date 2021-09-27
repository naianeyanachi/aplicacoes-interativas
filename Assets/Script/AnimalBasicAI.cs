using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimalBasicAI : MonoBehaviour
{
    private float happiness;
    public float Happiness {
        get { return this.happiness; }
        set {
            if (value < 0) this.happiness = 0;
            else if (value > 100) this.happiness = 100;
            else this.happiness = value;
        }
    }
    private float hunger;
    public float Hunger {
        get { return this.hunger; }
        set {
            if (value < 0) this.hunger = 0;
            else if (value > 100) this.hunger = 100;
            else this.hunger = value;
        }
    }
    private float hygiene;
    public float Hygiene {
        get { return this.hygiene; }
        set {
            if (value < 0) this.hygiene = 0;
            else if (value > 100) this.hygiene = 100;
            else this.hygiene = value;
        }
    }

    public GameObject player;
    public GameObject food;
    public GameObject sponge;
    public GameObject toy;

    Animator animator;

    public DateTime lastInitialization;
    public int TICK = 500;

    // Start is called before the first frame update
    void Start()
    {
        // int times = (Datetime.now() - lastInitialization) / TICK;
        // lastInitialization = Datetime.now();
        // this.happiness = this.happiness - 0.1 * times;
        // this.hunger = this.hunger - 0.1 * times;
        // this.hygiene = this.hygiene - 0.1 * times;
        this.Happiness = 50f;
        this.Hunger = 0f;
        this.Hygiene = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Datetime.now() - lastInitialization > TICK) {
            lastInitialization = DateTime.Now;
            this.Happiness = this.Happiness - 0.1f;
            this.Hunger = this.Hunger + 0.1f;
            this.Hygiene = this.Hygiene - 0.1f;
            Debug.Log(this.Happiness);
            Debug.Log(this.Hunger);
            Debug.Log(this.Hygiene);
            Debug.Log("-----------");
        // }
    }

    // UI: Joao

    void feed() {
        // Responsável: Naiane
        // aparecer comida na tela do usuario e arrasta até o animal
        // animal vai até a comida e come
    } 

    void pet() {
        // Responsável: 
        // animal vai perto da camera
        // espera pela ação do usuário (touch)
        // fica feliz
    }

    void play() {
        // Responsável: 
        // aparecer brinquedo na tela do usuario e arrasta até o animal
        // animal vai até o brinquedo e traz de volta (?)
    }

    void clean() {
        // Responsável: 
        // animal vai perto da camera
        // espera pela ação do usuário (esfregar)
        // ao esfregar aparece uma esponja
        // animação de banho (?)
    }
}
