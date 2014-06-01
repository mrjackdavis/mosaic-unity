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

			Node node = new Node ();
			node.Position = new Vector3 (0, 0.5F, 0);

			nodeController.AddNode (node);

			nodeController.RenderNodes ();
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}