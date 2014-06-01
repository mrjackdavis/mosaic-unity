using UnityEngine;
using System.Collections;
using Mosaic.Infrastructure;
using Mosaic.Models;

namespace Mosaic.Controllers{

	public class NodeRenderer : IRenderer<Node>{
		public void Render(Node Node){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			cube.transform.position = Node.Position;
		}
	}

}
