using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField] float timeBtwShots;
    [SerializeField] float startTimeBtwShots;
    public float damage = 10f;
    public float range = 100f;
public Camera fpscam;
public ParticleSystem MuzzleFlash;
public GameObject ImpactEffect;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots<=0)
        {
            if(Input.GetButton("Fire1"))
            {
            shoot();
            timeBtwShots=startTimeBtwShots;

            }
        }else{
            timeBtwShots-=Time.deltaTime;
        }
    }

    void shoot()
    {
        MuzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit)){
            Debug.Log(hit.transform.name);


            Target target = hit.transform.GetComponent<Target>();
            if(target != null){
                target.takeDamage(damage);
            }

            GameObject impactGO = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));  
            Destroy(impactGO,2f);
        }
    }
}
