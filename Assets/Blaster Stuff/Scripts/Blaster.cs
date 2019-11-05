using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Blaster : MonoBehaviour
{

    [Header("Input")]
    public SteamVR_Action_Boolean m_FireAction = null;
    public SteamVR_Action_Boolean m_ReloadAction = null;

    [Header("Settings")]
    public int m_Force = 10; //change this number for shooting straight 100
    public int m_MaxProjectileCount = 6;
    public float m_ReloadTime = 1.5f;

    [Header("References")]
    public Transform m_Barrel = null;
    public GameObject m_ProjectilePrefab = null;
    public Text m_AmmoOutput = null;

    private bool m_IsReloading = false;
    private int m_FireCount = 0;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private Animator m_Animator = null;
    private ProjectilePool m_ProjectilePool = null;

    private void Awake()
    {
        m_Pose = GetComponentInParent<SteamVR_Behaviour_Pose>();
        m_Animator = GetComponent<Animator>();


        m_ProjectilePool = new ProjectilePool(m_ProjectilePrefab, m_MaxProjectileCount);
    }

    private void Update()
    {
        if (m_IsReloading)
        {
            return;
        }
        if (m_FireAction.GetStateDown(m_Pose.inputSource))
        {
            m_Animator.SetBool("Fire", true);
            Fire();
        }

        if (m_FireAction.GetStateUp(m_Pose.inputSource))
        {
            m_Animator.SetBool("Fire", false);
        }

        if (m_ReloadAction.GetStateDown(m_Pose.inputSource))
            StartCoroutine(Reload());
    }

    private void Fire()
    {
        if (m_FireCount >= m_MaxProjectileCount)
            return;


        Projectile targetProjectile = m_ProjectilePool.m_Projectiles[m_FireCount];
        targetProjectile.Launch(this);

        UpdateFireCount(m_FireCount + 1);
    }

    private IEnumerator Reload()
    {
        if (m_FireCount == 0)
            yield break;

        m_AmmoOutput.text = "-";
        m_IsReloading = true;

        m_ProjectilePool.SetAllProjectiles();

        yield return new WaitForSeconds(m_ReloadTime);

        UpdateFireCount(0);
        m_IsReloading = false;
    }

    private void UpdateFireCount(int newValue)
    {
        m_FireCount = newValue;
        m_AmmoOutput.text = (m_MaxProjectileCount - m_FireCount).ToString();
    }
}
