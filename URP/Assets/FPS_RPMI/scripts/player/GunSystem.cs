using UnityEngine;
using UnityEngine.InputSystem;

public class GunSystem : MonoBehaviour
{

    #region General Variables

    [Header("General References")]
    [SerializeField] Camera fpsCam;
    [SerializeField] Transform ShootPoint;
    [SerializeField] LayerMask impactLayer;
    RaycastHit hit;


    [Header("Weapon Parameters")]
    [SerializeField] int damage = 10;
    [SerializeField] float range = 100;
    [SerializeField] float spread = 0;
    [SerializeField] float shootingColldown = 0.2f;
    [SerializeField] float reloadTime = 1.5f;
    [SerializeField] bool allowButtonHold = false;


    [Header("Bullet Management")]
    [SerializeField] int amoSize = 30;
    [SerializeField] int bulletsPerTap = 1;
    int bulletsLeft;

    [Header("FeedBack references")]
    [SerializeField] GameObject impactEffect;


    [Header("Dev - Gun State Bools")]
    [SerializeField] bool shooting;
    [SerializeField] bool canShoot;
    [SerializeField] bool reloading;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    #endregion
    private void Awake()
    {
        bulletsLeft = amoSize;
        canShoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {




    }
    #region

    public void OnShoot(InputAction.CallbackContext context)
    {



    }


    public void OnReload(InputAction.CallbackContext context)
    {



    }

    #endregion
}
