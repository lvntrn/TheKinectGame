using UnityEngine;
using System.Collections;

namespace Tetris {
    public class HudHealthPanel : MonoBehaviour {

		private static int pause;

        public Transform[] heartList; // List this the UI Elements to Display
        public int actualLive = 2; // actualLive that is been Displayed

        void Start() {
            actualLive = heartList.Length;
        }

		void Update() {
			GameObject thePlayer = GameObject.Find ("FakePlayer");
			TetrisPlayer tetrisPlayer = thePlayer.GetComponent<TetrisPlayer>();
			pause = tetrisPlayer.winPause;
		}

        //Reset the List ,set all to Active
//        public void setActive() {
//            for(int i = 0; i < heartList.Length; i++) {
//                heartList[i].gameObject.SetActive(true);
//            }
//        }

        // set the Live and Deactivate all Objects Above this Count
        public void setLive(int _value) {
            actualLive = _value;
			Debug.Log ("DKK: " + pause);
//            if(_value == heartList.Length) {
//                //setActive();
//            }
			if (actualLive >= 0) {
				heartList [_value].gameObject.SetActive (false);
			}
			if (actualLive == 0) {
				if (pause == 0) { 
					Dying ();
				}
            }
        }

        //Getter
        public int getLive() {
            return this.actualLive;
        }

		void Dying () {
			Application.LoadLevelAdditive (2);
			//Application.LoadLevel ("PauseMenu");
		}
    }
}
