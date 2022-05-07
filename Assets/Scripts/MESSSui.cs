using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MESSSui : MonoBehaviour
{
    //Player Health variables
    public TMP_Text _textHealth;
    private int _health;
    public KnightMovement _playerRef;

    //Gun-related variables
    public TMP_Text _fullAmmo;
    public TMP_Text _remainingAmmo;
    public TMP_Text _killCounter;
    private int _fullCount, _remainCount;
    public Image _activeWeapLabel;
    public Image _storedWeapLabel;
    public Image _ammoType;
    public Sprite _shotgunSprite;
    public Sprite _pistolSprite;
    public Sprite _shotgunAmmo;
    public Sprite _pistolAmmo;

    //Key related variables
    public Image _redKey;
    public Image _greenKey;
    public Image _blueKey;


    // Start is called before the first frame update
    void Start()
    { 
        _health = _playerRef._hp;
        _textHealth.text = _health.ToString();
        _killCounter.text = _playerRef._killCount.ToString();
        //_fullCount = _playerRef._activeGun._maxAmmo;
        //_remainCount = _playerRef._activeGun._currAmmo;
        //_fullAmmo.text = _fullCount.ToString();
        //_remainingAmmo.text = _remainCount.ToString();
        _redKey.enabled = false;
        _greenKey.enabled = false;
        _blueKey.enabled = false;
        if(_playerRef._activeGun.name == "Shotgun")
        {
            _activeWeapLabel.sprite = _shotgunSprite;
            _storedWeapLabel.sprite = _pistolSprite;
            _ammoType.sprite = _shotgunAmmo;
        }
        else if(_playerRef._activeGun.name == "Pistol")
        {
            _activeWeapLabel.sprite = _pistolSprite;
            _storedWeapLabel.sprite = _shotgunSprite;
            _ammoType.sprite = _pistolAmmo;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _health = _playerRef._hp;
        _textHealth.text = _health.ToString();
        _killCounter.text = _playerRef._killCount.ToString();
        //_fullCount = _playerRef._activeGun._maxAmmo;
        //_remainCount = _playerRef._activeGun._currAmmo;
        //_fullAmmo.text = _fullCount.ToString();
        //_remainingAmmo.text = _remainCount.ToString();

        //pull into function
        if (_playerRef._activeGun.name == "Shotgun")
        {
            _activeWeapLabel.sprite = _shotgunSprite;
            _storedWeapLabel.sprite = _pistolSprite;
            _ammoType.sprite = _shotgunAmmo;
        }
        else if (_playerRef._activeGun.name == "Pistol")
        {
            _activeWeapLabel.sprite = _pistolSprite;
            _storedWeapLabel.sprite = _shotgunSprite;
            _ammoType.sprite = _pistolAmmo;
        }
    }
}
