using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckCollisions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;
    public PlayerController playerController;
    Vector3 PlayerStartPos;
    public GameObject speedBoosterIcon;
    public GameObject slownessIcon;
    public int maxScore;
    public Animator PlayerAnim;
    public GameObject Player;
    public GameObject FinishPanel;
    public AudioClip coinSound;
    public AudioClip hitSound;
    public AudioClip winSound;
    public GameObject speedParticle;
    public GameObject slowParticle;

    private AudioSource audioSource;

    private InGameRanking ig;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayerStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        speedBoosterIcon.SetActive(false);
        ig = FindObjectOfType<InGameRanking>();
        PlayerAnim = Player.GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            audioSource.PlayOneShot(coinSound);
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Finish"))
        {
            audioSource.PlayOneShot(winSound);
            if (ig.namesTxt[6].text == "Player" && score >= maxScore)
            {
                PlayerFinished();
                PlayerAnim.SetBool("Win", true);
            }
            else
            {
                PlayerFinished();
                PlayerAnim.SetBool("Lose", true);
            }
        }
        else if (other.CompareTag("SpeedBoost"))
        {
            Instantiate(speedParticle, transform.position, Quaternion.identity);
            playerController.runningSpeed += 3f;
            speedBoosterIcon.SetActive(true);
            StartCoroutine(SlowAfterAWhileCoroutine());
        }
        else if (other.CompareTag("SlownessObs"))
        {
            Instantiate(slowParticle, transform.position, Quaternion.identity);
            playerController.runningSpeed -= 3f;
            slownessIcon.SetActive(true);
            StartCoroutine(FastAfterAWhileCoroutine());
        }
    }

    void PlayerFinished()
    {
        playerController.runningSpeed = 0;
        transform.Rotate(transform.rotation.x, 180, transform.rotation.z, Space.Self);
        GameManager.instance.isGameOver = true;
        FinishPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collision"))
        {
            audioSource.PlayOneShot(hitSound);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            transform.position = PlayerStartPos;
        }
    }

    public void AddCoin()
    {
        score++;
        CoinText.text = "Score: " + score.ToString();
    }

    private IEnumerator SlowAfterAWhileCoroutine()
    {
        yield return new WaitForSeconds(2.0f);
        playerController.runningSpeed -= 3f;
        speedBoosterIcon.SetActive(false);
    }

    private IEnumerator FastAfterAWhileCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        playerController.runningSpeed += 3f;
        slownessIcon.SetActive(false);
    }
}
