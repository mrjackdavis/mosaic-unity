using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Mosaic.Models;
using Mosaic.Infrastructure;

namespace Mosaic.Controllers {
	public class NodeController : IRepository<Node>{

		public void Render(Node Node){
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = Node.Position;
			cube.transform.RotateAround (new Vector3 (0, 0, 0), new Vector3 (0.5F, 0.5F, 0), 20.2F);
		}

		#region IRepository implementation

		public IEnumerable<Node> GetAll ()
		{
			throw new NotImplementedException ();
		}

		public void Add ()
		{
			throw new NotImplementedException ();
		}

		public void Remove ()
		{
			throw new NotImplementedException ();
		}

		public void Update ()
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}
