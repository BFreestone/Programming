using UnityEngine;

public class Reload2 : MonoBehaviour
{

    [SerializeField] private int _gun1Ammo, _gun1AmmoMax, _gun1AmmoReserve;
    private int _gun1AmmoMissing;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _gun1AmmoMissing = (_gun1AmmoMax - _gun1Ammo);

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_gun1Ammo == _gun1AmmoMax)
            {
                Debug.Log("ammo is full");
                return;
            }


            else if (_gun1AmmoReserve >= _gun1AmmoMissing)
            {
                _gun1Ammo = (_gun1Ammo + _gun1AmmoMissing);
                _gun1AmmoReserve = (_gun1AmmoReserve - _gun1AmmoMissing);

            }

            else
            {
                _gun1Ammo = (_gun1Ammo + _gun1AmmoReserve);
                _gun1AmmoReserve = (0);
                Debug.Log("out of mags");
            }
        }
    }
}
