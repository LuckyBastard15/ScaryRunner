using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _coin = default;
    [SerializeField] private ParticleSystem _conffeti;
    [SerializeField] private AudioSource _coinSourse;
    [SerializeField] private AudioClip _coinSound;
    private Transform _player = default;
    public CoinMovement DesableCoin;

    private void Start()
    {
        _conffeti = GetComponent<ParticleSystem>();
        _coinSourse = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            Score.Instance.AddPoint();
            _conffeti.Play();
            _coinSourse.PlayOneShot(_coinSound, 1f);
            StartCoroutine(Conffeti());

        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("GrabCoins"))
        {
            //Debug.Log("CoinGrab");
            DesableCoin.DesableMove();

            _coin.transform.position = _player.transform.position;
        }

    }


    public IEnumerator Conffeti()
    {
        yield return new WaitForSeconds(0.15f);
        _coin.SetActive(false);
        gameObject.SetActive(false);

    }


}