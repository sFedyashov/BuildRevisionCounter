﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace BuildRevisionCounter.Model
{
	public class RevisionModel
	{
		[BsonId]
		public string Id;

		[BsonElement("created"), BsonDateTimeOptions(Kind=DateTimeKind.Utc)]
		public DateTime Created;

		[BsonElement("updated"), BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
		public DateTime Updated;

		[BsonElement("currentNumber")]
		public long CurrentNumber;

	}
}