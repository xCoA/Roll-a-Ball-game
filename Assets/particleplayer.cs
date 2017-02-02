using UnityEngine;
using System.Collections;

public class particleplayer : MonoBehaviour {

    private Vector3 offset;
    private ParticleSystem ps;

    public GameObject player;
    public float lifeTime = 0.1f;
    public float lengthmodifier = 1.5f;
  
    // Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        ps = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void LateUpdate () {
        transform.position = player.transform.position+offset;
    }
    public void Upgrade()
    {

        //var ma = ps.main;
        lifeTime = lifeTime * lengthmodifier;
        ps.startLifetime = lifeTime;
        Debug.Log(lifeTime);
    }

}
