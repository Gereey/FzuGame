using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed=10;
	public float jumpforce=150;
	public int lotus=0;
	public int energy=100;
        public Text show;
	public Text lotusNum;
	public Text energyNum;
	public float time = 3600f;
    public float currentVaule = 20f;
    public float targetVaule = 100f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
	DataIncrement();
	}

	void movement(){
		float horizontalmove=Input.GetAxis("Horizontal");
		float facedirection=Input.GetAxisRaw("Horizontal");
		

        if(horizontalmove!=0){
            rb.velocity=new Vector2(horizontalmove*speed,rb.velocity.y);
		}
		
        if(facedirection!=0){
			transform.localScale= new Vector3(facedirection,1,1);
		}
		
		if(Input.GetButtonDown("Jump")){
		rb.velocity=new Vector2(rb.velocity.x,jumpforce*Time.deltaTime);
		}
	}
	private void OnTriggerEnter2D(Collider2D collision){
	if(collision.tag=="collection"){
	Destroy(collision.gameObject);
	lotus+=50;
	energy-=1;
	lotusNum.text=lotus.ToString();
    energyNum.text=energy.ToString();
	}
	}
    void DataIncrement()
    {
        currentVaule += Time.deltaTime*(targetVaule / time);
 
        if (currentVaule >= targetVaule)
        {
            currentVaule = targetVaule;
        }
        show.text = currentVaule.ToString("00");
    }
}

