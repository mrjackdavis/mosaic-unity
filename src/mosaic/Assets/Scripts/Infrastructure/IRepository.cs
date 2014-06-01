using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Mosaic.Infrastructure {
	public interface IRepository<T> {
		IEnumerable<T> GetAll ();
		void Add ();
		void Remove ();
		void Update ();
	}
}