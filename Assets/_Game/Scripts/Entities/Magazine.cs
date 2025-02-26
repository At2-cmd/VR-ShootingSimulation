using UnityEngine;

public class Magazine : MonoBehaviour
{
    [SerializeField] private int ammoCount;
    private int _currentAmmo;
    public int CurrentAmmoCount => _currentAmmo;

    private void Start()
    {
        _currentAmmo = ammoCount;
    }
    public void UseAmmo()
    {
        if(_currentAmmo <= 0)
        {
            Debug.Log("No ammo left");
            return;
        }
        _currentAmmo--;
    }
}
