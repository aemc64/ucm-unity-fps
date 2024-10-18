using UnityEngine;

public class WeaponsManager : MonoBehaviour
{
    [SerializeField] private Shoot[] _weapons;
    [SerializeField] private int _initialWeaponIndex;

    private int _currentWeaponIndex = -1;

    private void Awake()
    {
        foreach (var weapon in _weapons)
        {
            weapon.gameObject.SetActive(false);
        }
        
        ChangeWeapon(_initialWeaponIndex);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeWeapon(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
        }
    }

    private void ChangeWeapon(int index)
    {
        if (_currentWeaponIndex != -1)
        {
            _weapons[_currentWeaponIndex].gameObject.SetActive(false);
        }
        
        _weapons[index].gameObject.SetActive(true);
        _currentWeaponIndex = index;
    }
}
