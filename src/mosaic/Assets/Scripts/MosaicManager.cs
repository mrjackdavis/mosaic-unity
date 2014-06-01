using UnityEngine;
using System.Collections;
using Mosaic.Controllers;
using Mosaic.Models;

namespace Mosaic {
	public class MosaicManager : MonoBehaviour {
		private NodeController nodeController;

		// Use this for initialization
		void Start () {
			nodeController = new NodeController ();
			Node node = new Node ();
			node.Position = new Vector3 (0, 0.5F, 0);
			nodeController.Render (node);
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}