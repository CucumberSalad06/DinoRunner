using UnityEngine;

public class RandomAnimate : MonoBehaviour
{
    Animator anim;
    float randomOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 2f);

        anim.Play("running", 0, randomOffset);
    }

}
