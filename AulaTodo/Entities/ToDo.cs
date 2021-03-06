﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
	[Table("Todo")]
	public class ToDo : EntitieBase<int>
	{
		[Required]
		[Column("Tarefa")]
		public string Tarefa { get; set; }
		public string Observacao { get; set; }
	}
}
