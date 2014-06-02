using UnityEngine;
using System.Collections;
using Mosaic.Controllers;
using Mosaic.Models;
using Mosaic.Infrastructure;

namespace Mosaic {
	public class MosaicManager : MonoBehaviour {
		private NodeController nodeController;

		// Use this for initialization
		void Start () {
			IRenderer<Node> nodeRenderer = new NodeRenderer ();
			IRepository<Node> nodeRepository = new MemoryRepository<Node> ();

			nodeController = new NodeController (nodeRepository,nodeRenderer);

			int mockNodes = 997;

			for(int i = 0; i+1 <= mockNodes; i++){
				Node node = new Node ();
				node.Position = new Vector3 (i*i%383, i*i%47, i*i%173);
				nodeController.AddNode (node);
			}


			nodeController.RenderNodes ();
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}