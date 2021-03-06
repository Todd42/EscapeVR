namespace VRTK.Examples
{
    using UnityEngine;

    public class TriButtonReactor : MonoBehaviour
    {
        public GameObject go;
        public Transform dispenseLocation;

		public bool But1;
		public bool But2;
		public bool But3;
		private bool But4 = true;

		public GameObject Button_1;
		public GameObject Button_2;

		private int count;

        private void Start()
        {
            GetComponent<VRTK_Button>().events.OnPush.AddListener(handlePush);
        }

        private void handlePush()
        {
            Debug.Log("Pushed");

			if (tag == "Button_1") {
				But1 = true;
				Debug.Log ("1 pressed");
			}else if (tag == "Button_2"){
				But2 = true;
				Debug.Log ("2 pressed");
			}else if(tag == "Button_3"){
				But3 = true;
				Debug.Log ("3 pressed");
			}

			if((But1 && But2 && But3 && But4) || (Button_1.GetComponent<TriButtonReactor>().But1 && Button_2.GetComponent<TriButtonReactor>().But2 && But3 && But4)){
				Debug.Log ("Success!");
            	GameObject newGo = (GameObject)Instantiate(go, dispenseLocation.position, Quaternion.identity);
            	//Destroy(newGo, 1f);
				But4 = false;
				}
        }

		private void Update(){
			count += 1;
			if (count >= 30) {
				But1 = false;
				But2 = false;
				But3 = false;
				count = 0;
			}
		}

    }
}