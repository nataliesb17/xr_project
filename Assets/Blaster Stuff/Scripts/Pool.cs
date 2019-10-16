using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool
{
   public static List<T> Create<T>(GameObject prefab, int count)
        where T : MonoBehaviour
    {
        //New List

        List<T> newPool = new List<T>();

        //Create
        for (int i = 0; i < count; i++) {
            GameObject projectileObject = GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity);
            T newProjectile = projectileObject.GetComponent<T>();

            newPool.Add(newProjectile);
        }


        return newPool;
    }
}

public class ProjectilePool : Pool
{
    public List<Projectile> m_Projectiles = new List<Projectile>();

    public ProjectilePool(GameObject prefab, int count)
    {
        m_Projectiles = ProjectilePool.Create<Projectile>(prefab, count);
    }

    public void SetAllProjectiles(bool value)
    {
        foreach(Projectile projectile in m_Projectiles)
        {

        }
    }
}
