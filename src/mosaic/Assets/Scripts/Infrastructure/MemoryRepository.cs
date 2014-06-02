using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Mosaic.Infrastructure{

	public class MemoryRepository<T> : IRepository<T> {

		private IList<T> _InMemoryList;
		private IList<T> _UnitOfWorkList;


		public MemoryRepository(){
			this._InMemoryList = new List<T> ();
			this._UnitOfWorkList = new List<T> (_InMemoryList);
		}

		#region IRepository implementation

		public IEnumerable<T> GetAll ()
		{
			return new List<T> (_InMemoryList);
		}

		public void Add (T Item)
		{
			_UnitOfWorkList.Add (Item);
		}

		public void Remove (T Item)
		{
			_UnitOfWorkList.Remove (Item);
		}

		public void Update (T Item)
		{
			//Since Item is referenced across lists, it should already be updated
		}

		public void Commit ()
		{
			_InMemoryList = new List<T> (_UnitOfWorkList);
		}

		#endregion
		
		#region IDisposable implementation
		
		public void Dispose ()
		{
			_UnitOfWorkList = new List<T> (_InMemoryList);
		}
		
		#endregion


	}

}