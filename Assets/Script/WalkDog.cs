using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class WalkDog : MonoBehaviour
{
  //Assign a GameObject in the Inspector to rotate around
  public GameObject target;
  public bool walking;
  Animator animator;

  void Start()
  {
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    // Spin the object around the target at 20 degrees/second.
    if (walking)
    {
      animator.SetInteger("Walk", 1);
      transform.RotateAround(target.transform.position, Vector3.up, 40 * Time.deltaTime);
    }
    else
    {
      animator.SetInteger("Walk", 0);
    }
  }
  public void FlipWalking()
  {
    this.walking = !this.walking;
  }
}