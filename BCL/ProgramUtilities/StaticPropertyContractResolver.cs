﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BCL
{
    //public class StaticPropertyContractResolver : DefaultContractResolver
    //{
    //    protected override List<MemberInfo> GetSerializableMembers(Type objectType)
    //    {
    //        var baseMembers = base.GetSerializableMembers(objectType);

    //        PropertyInfo[] staticMembers =
    //            objectType.GetProperties(BindingFlags.Static | BindingFlags.Public);

    //        baseMembers.AddRange(staticMembers);

    //        return baseMembers;
    //    }
    //}
}
