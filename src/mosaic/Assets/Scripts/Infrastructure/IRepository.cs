using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Mosaic.Infrastructure {
	public interface IRepository<T> : IDisposable{
		IEnumerable<T> GetAll ();
		void Add (T Item);
		void Remove (T Item);
		void Update (T Item);
		void Commit();
	}
}