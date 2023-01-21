using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Play.Common.MongoDB.Serializers
{
    public class GuidSerializationProvider : IBsonSerializationProvider
    {
        public IBsonSerializer GetSerializer(Type type)
        {
            return type == typeof(Guid)? GuidSerializer.StandardInstance: null;
        }
    }
}