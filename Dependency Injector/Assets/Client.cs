using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        public Bike playerBike;
        public Bike AIBikeOne;
        public Bike AIBikeTwo;
        public Bike AIBikeThree;
        // Start is called before the first frame update
        void Awake()
        {
            IEngine jetEngine = new JetEngine();
            IDriver human = new HumanDriver();
            playerBike.SetEngine(jetEngine);
            playerBike.SetDriver(human);
            playerBike.StartEngine();

            IEngine nitroEngine = new NitroEngine();
            IDriver aiOne = new AIDriver();
            AIBikeOne.SetEngine(nitroEngine);
            AIBikeOne.SetDriver(aiOne);
            AIBikeOne.StartEngine();

            IEngine warpEngine = new WarpEngine();
            IDriver aiTwo = new AIDriver();
            AIBikeTwo.SetEngine(warpEngine);
            AIBikeTwo.SetDriver(aiTwo);
            AIBikeTwo.StartEngine();

            IEngine hyperDrive = new Hyperdrive();
            IDriver aiThree = new AIDriver();
            AIBikeThree.SetEngine(hyperDrive);
            AIBikeThree.SetDriver(aiThree);
            AIBikeThree.StartEngine();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) { playerBike.TurnLeft(); }
            if (Input.GetKeyDown(KeyCode.D)) { playerBike.TurnRight(); }
        }
        void OnGUI() { 
            GUI.color = Color.black; 
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT"); 
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console"); 
        }
    }
}
