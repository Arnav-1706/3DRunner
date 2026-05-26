using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed = 2f;
    public float xSpeed = 0.001f;
    public float limitX = 3f;

    private Animator animator;
    private bool isRunning = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isRunning)
        {
            float hi = 0f;

            if (Input.GetKey(KeyCode.A))
            {
                hi = -1f;
            }

            if (Input.GetKey(KeyCode.D))
            {
                hi = 1f;
            }

            Vector3 pos = transform.position;

            pos.x += hi * 3f * Time.deltaTime;

            pos.x = Mathf.Clamp(pos.x, -3.75f, 3.75f);

            pos.z += runningSpeed * Time.deltaTime;

            transform.position = pos;

            if (animator != null)
            {
                animator.SetBool("Running", true);
            }
        }
    }

    public void StartRunning()
    {
        Debug.Log("PLAYER STARTED");

        isRunning = true;
    }
}