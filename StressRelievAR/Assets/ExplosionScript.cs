using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
	public GameObject Explosion;
	public GameObject Notebook;
	public GameObject g;
	public bool goingRight = true;

	void Explode()
	{
		var exp = GetComponent<ParticleSystem>();
		exp.Play();
		Destroy(gameObject, exp.duration / 2);
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("COLLISION");
		if (other.gameObject.name.Contains("Cat"))
		{
			Debug.Log("CAT COLLISION");
			other.gameObject.GetComponent<AudioSource>().Play();
		}
		else if (other.gameObject.name.Contains("notepad") != true && other.gameObject.name.Contains("Food") == false)
		{
			var exp = other.gameObject.GetComponent<ParticleSystem>();
			exp.Play();
			Destroy(other.gameObject, exp.duration);
		}

		else if (other.gameObject.name.Contains("Food"))
		{
			Debug.Log("FOOD COLLISION");
			other.gameObject.GetComponent<AudioSource>().Play();
			Destroy(other.gameObject);
		}
	}

	// Use this for initialization
	void Start()
	{
		// GameObject obj2 = Instantiate(Explosion, Notebook.transform.position, Quaternion.identity);


	}

	// Update is called once per frame
	void Update()
	{
		if (!goingRight)
		{
			g.transform.Translate(0.1f, 0, 0);
			g.GetComponent<BoxCollider>().transform.Translate(0.1f, 0, 0);

		}
		else
		{
			g.transform.Translate(-0.1f, 0, 0);
			g.GetComponent<BoxCollider>().transform.Translate(-0.1f, 0, 0);
		}

		if (g.transform.position.x > 15)
		{
			goingRight = false;
		}
		else if (g.transform.position.x < -15)
		{
			goingRight = true;
		}
	}

	void move(GameObject g)
	{
		bool goingRight = true;
		if (goingRight)
		{
			g.transform.Translate(0.01f, 0, 0);
			g.GetComponent<BoxCollider>().transform.Translate(0.01f, 0, 0);

		}
		else
		{
			g.transform.Translate(-0.01f, 0, 0);
			g.GetComponent<BoxCollider>().transform.Translate(-0.01f, 0, 0);
		}

		if (g.transform.position.x > 20)
		{
			goingRight = false;
		}
		else if (g.transform.position.x < -20)
		{
			goingRight = true;
		}
	}
}