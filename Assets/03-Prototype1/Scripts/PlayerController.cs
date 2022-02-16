using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float speed;
   public Text countText;
   public Text winText;

   public Text lifeText;

   private Rigidbody rb;
   private int count;
   private int life = 3;

   void Start ()
   {
   	rb = GetComponent<Rigidbody>();
   }

   void FixedUpdate()
   {
   	float moveHorizontal = Input.GetAxis("Horizontal");
   	float moveVertical = Input.GetAxis("Vertical");
   	Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
   	rb.AddForce (movement * speed);
   }

   void OnTriggerEnter (Collider other)
   {
      if (other.gameObject.CompareTag("Pick Up"))
      {
         other.gameObject.SetActive(false);
         count = count+1;
         SetCountText();
      }
   }

   void SetCountText()
   {
      countText.text = "Count: " + count.ToString();
      if (count>=8){
         winText.text = "You Win!";
      }
   }
   void LifeCounter(){
      lifeText.text = "Lives: " +life.ToString();
      if(life<=0){
         SceneManager.LoadScene("Main-Prototype 1");
      }
   }
    void OnCollisionEnter (Collision coll){
    GameObject collidedWith = coll.gameObject;
    if(collidedWith.tag == "Apple"){
       Destroy(collidedWith);
        }
    }
}
