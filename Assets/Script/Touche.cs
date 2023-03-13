using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touche : MonoBehaviour
{
    [SerializeField]
    private GameObject bird;
    [SerializeField]
    private GameObject Pide_up;
    [SerializeField]
    private GameObject Pide_down;
    [SerializeField]
    private float speed = 1f;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip flyClip, pingClip, dieadClip;
    private bool isTouche = false;

    public GameObject Panel;
    public GameObject playAgainButton;
    public GameObject quitButton;

    private float dirXUp;
    private float dirYUp;

    float upXRight;
    float upYRight;

    float upXLeft;
    float upYLeft;

    private float dirXDown;
    private float dirYDown;

    float downXRight;
    float downYRight;

    float downXLeft;
    float downYLeft;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * Time.deltaTime) * speed;
   

        // Check PipeUp
        dirXUp = Pide_up.transform.position.x;
        dirYUp = Pide_up.transform.position.y;


        upXLeft = dirXUp + 0.8f;
        upYLeft = dirYUp - 0.2f;

        upYRight = dirYUp - 0.2f;
        upXRight = dirXUp - 0.8f;


        if (bird.transform.position.x > upXRight && bird.transform.position.y > upYRight && bird.transform.position.x < upXLeft && bird.transform.position.y > upYLeft)
        {

            Time.timeScale = 0.0f;
            
            playAgainButton.SetActive(true);
            Panel.SetActive(true);
            quitButton.SetActive(true);
        }

        // Check PipeDown
        dirXDown = Pide_down.transform.position.x;
        dirYDown = Pide_down.transform.position.y;


        downXLeft = dirXDown + 0.8f;
        downYLeft = dirYDown + 0.2f;

        downYRight = dirYDown + 0.2f;
        downXRight = dirXDown - 0.8f;

        if (bird.transform.position.x > downXRight && bird.transform.position.y < downYRight && bird.transform.position.x < downXLeft && bird.transform.position.y < downYLeft)
        {
          
            Time.timeScale = 0.0f;
           
            playAgainButton.SetActive(true);
            Panel.SetActive(true);
            quitButton.SetActive(true);
        }   
    }
}
