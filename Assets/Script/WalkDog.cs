using UnityEngine;

public class WalkDog : MonoBehaviour
{
  public Transform player;
  public bool walking;
  private Animator animator;


  // Walking variables
  private float timer;
  public float timeToMove;
  public float timeWaiting;
  public float speed;
  public float maxX;
  public float minX;
  public float maxZ;
  public float minZ;
  private Vector3 desiredPos;

  void Start()
  {
    animator = GetComponent<Animator>();
    desiredPos = new Vector3(Random.Range(minX, maxX), 0.0f, Random.Range(minZ, maxZ));
  }

  void Update()
  {
    timer += Time.deltaTime;
    if (walking)
    {
      if (timer >= timeToMove)
      {
        animator.SetInteger("Walk", 1);
        transform.LookAt(desiredPos);
        transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, desiredPos) <= 0.5f)
        {
          desiredPos = new Vector3(Random.Range(minX, maxX), 0.0f, Random.Range(minZ, maxZ));
          timer = 0.0f;
          animator.SetInteger("Walk", 0);
        }
      }
    }
    else
    {
      desiredPos = player.position;
      desiredPos.y = 0;
      transform.LookAt(desiredPos);
      if (Vector3.Distance(transform.position, desiredPos) > 1.6f)
      {
        animator.SetInteger("Walk", 1);
        transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
        timer = 0.0f;
      }
      else
      {
        animator.SetInteger("Walk", 0);
        animator.SetBool("Look", true);
        if (timer >= timeWaiting)
        {
          desiredPos = new Vector3(Random.Range(minX, maxX), 0.0f, Random.Range(minZ, maxZ));
          timer = 0.0f;
          walking = true;
          animator.SetBool("Look", false);
        }
      }
    }
  }
  public void FlipWalking()
  {
    this.walking = !this.walking;
  }
}
