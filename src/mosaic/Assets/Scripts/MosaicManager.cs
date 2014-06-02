using UnityEngine;
using System.Collections;
using Mosaic.Controllers;
using Mosaic.Models;
using Mosaic.Infrastructure;

namespace Mosaic {
	public class MosaicManager : MonoBehaviour {
		private NodeController nodeController;
		private GameObject Player;

		// Use this for initialization
		void Start () {
			this.Player = this.gameObject;

			IRenderer<Node> nodeRenderer = new NodeRenderer ();
			IRepository<Node> nodeRepository = new MemoryRepository<Node> ();

			nodeController = new NodeController (nodeRepository,nodeRenderer);

			int mockNodes = 300;

			Node CurrentNode = null;

			for(int i = 0; i+1 <= mockNodes; i++){
				Node node = new Node ();
				node.Position = new Vector3 (i*i%29, i*i%13, i*i%67);
				node.OrbitDistance = 1F;
				nodeController.AddNode (node);

				if(i == mockNodes/2)
					CurrentNode = node;
			}

			if (CurrentNode == null)
				throw new UnityException ("Expected current node to not be null");


			nodeController.RenderNodes ();

			//Player.transform.position = new Vector3(CurrentNode.Position.x+CurrentNode.OrbitDistance,CurrentNode.Position.y,CurrentNode.Position.z);
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}