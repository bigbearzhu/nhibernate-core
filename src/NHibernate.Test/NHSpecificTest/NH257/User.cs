using System;
using System.Collections.Generic;
using Iesi.Collections.Generic;

namespace NHibernate.Test.NHSpecificTest.NH257
{
	[Serializable]
	public class User : Party
	{
		private ISet<UserGroup> _groups = new HashedSet<UserGroup>();

		public ISet<UserGroup> Groups
		{
			get { return _groups; }
			set { _groups = value; }
		}
	}
}