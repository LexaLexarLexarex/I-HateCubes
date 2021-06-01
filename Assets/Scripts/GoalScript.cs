using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    public AudioSource sphere;
    public AudioSource cube;
    public int _Score = 0;
    [SerializeField] Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        GameObject collideWith = other.gameObject;
        if ( collideWith.tag == gameObject.tag)
        {
            Destroy(other);
            _Score++;
            sphere.Play();
        } else
        {
            _Score--;
            cube.Play();
        }
    }
    private void Start()
    {
        sphere = GetComponent<AudioSource>();
        cube = GetComponent<AudioSource>();
    }
    void Update()
    {
        scoreText.text = _Score.ToString();
    }
}
