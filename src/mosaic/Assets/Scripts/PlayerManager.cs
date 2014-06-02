using UnityEngine;
using System.Collections;

namespace Mosaic{

	public class PlayerManager : MonoBehaviour {
		
		public float speed = 10.0F;
		public float horizontalSpeed = 2.0F;
		public float verticalSpeed = 2.0F;

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update() {
			float h = horizontalSpeed * Input.GetAxis("Mouse X");
			float v = verticalSpeed * Input.GetAxis("Mouse Y");

			float translation = Input.GetAxis("Vertical") * speed;
			translation *= Time.deltaTime;
			transform.Translate(0, 0, translation);
			transform.Rotate(v, h, 0);
		}
	}
}
