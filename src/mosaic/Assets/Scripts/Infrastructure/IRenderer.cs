using UnityEngine;
using System.Collections;


namespace Mosaic.Infrastructure{

	public interface IRenderer <T> {
		void Render(T Item);
	}

}