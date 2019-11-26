using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
	public enum FileIoMessage
	{
		None,
		Complete,
		FileAccessError,
		RecordNotFound,
		NoRecordsFound
	}
}
