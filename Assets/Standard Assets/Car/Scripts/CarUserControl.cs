using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController car; // the car controller we want to use
		private float carTurn = 0f;

        private void Awake()
        {
            // get the car controller
            car = GetComponent<CarController>();
        }

		public void changeDirectionLeft(){
			carTurn = -.2f;
		}

		public void changeDirectionRight(){
			carTurn = +.2f;
		}

		public void resetDirection(){
			carTurn = 0f;
		}

        private void FixedUpdate()
        {
            // pass the input to the car!
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
        
			float vGamePad = CrossPlatformInputManager.GetAxis ("Fire1");
			car.Move(carTurn, vGamePad);

			//print (h + " " + vGamePad);


        }
    }
}