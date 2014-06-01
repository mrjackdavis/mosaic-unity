using UnityEngine;
using System.Collections;
using Mosaic.Infrastructure;
using Mosaic.Models;

namespace Mosaic.Controllers{

	public class NodeRenderer : IRenderer<Node>{
		public void Render(Node Node){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = Node.Position;
			cube.transform.RotateAround (new Vector3 (0, 0, 0), new Vector3 (0.5F, 0.5F, 0), 20.2F);
		}
	}

}
