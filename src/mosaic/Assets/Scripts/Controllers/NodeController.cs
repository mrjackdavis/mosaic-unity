using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Mosaic.Models;
using Mosaic.Infrastructure;

namespace Mosaic.Controllers {
	public class NodeController {

		private readonly IRepository<Node> nodeRepository;
		private readonly IRenderer<Node> nodeRenderer;

		public NodeController(IRepository<Node> NodeRepository, IRenderer<Node> NodeRenderer){
			this.nodeRepository = NodeRepository;
			this.nodeRenderer = NodeRenderer;
		}

		public void RenderNodes(){
			foreach (var node in nodeRepository.GetAll()) {
				this.nodeRenderer.Render(node);
			}
		}

		public void AddNode(Node node){
			nodeRepository.Add (node);
			nodeRepository.Commit ();
		}
	}
}
