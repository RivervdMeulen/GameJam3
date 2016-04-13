using UnityEngine;
using System.Collections;

public class PickupSlow : MonoBehaviour {

    public bool _hasPickup1 = false;
    public bool _hasPickup2 = false;
    private BoxCollider _pickUpCollider;
    private MeshRenderer _meshRenderer;
    [SerializeField]private GameObject _juiceSlow;
    [SerializeField]private GameObject _player;


    void Start ()
    {

        _pickUpCollider = GetComponent<BoxCollider>();
        _meshRenderer = GetComponent<MeshRenderer>();
        

    }
	
	void Update ()
        {
        if (Input.GetButtonDown("Jump") && _hasPickup1 == true)
        {
            StartCoroutine(Cooldown());
        }

    }

   private IEnumerator Cooldown()
    {
  
        _hasPickup1 = false;
        yield return new WaitForSeconds(0.5f);
        Instantiate(_juiceSlow, _player.transform.position, _player.transform.rotation);
       
    }
    void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Player1" && _hasPickup1 == false)
            {
            _hasPickup1 = true;
            _pickUpCollider.enabled = false;
            _meshRenderer.enabled = false;
        }

            else if(other.gameObject.tag == "Player2" && _hasPickup2 == false)
            {
            _hasPickup2 = true;
            _pickUpCollider.enabled = false;
            _meshRenderer.enabled = false;
        }
        }


    }
