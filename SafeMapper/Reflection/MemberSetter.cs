﻿namespace SafeMapper.Reflection
{
    using System;
    using System.Reflection;

    public class MemberSetter : Member
    {
        public MemberSetter(MemberInfo member, string key = null)
            : base(member, key)
        {
            this.Type = this.GetSetterType(member);
        }

        private Type GetSetterType(MemberInfo member)
        {
            var method = member as MethodInfo;
            if (method != null)
            {
                var parameters = method.GetParameters();
                if (parameters.Length == 2 && parameters[0].ParameterType == typeof(string))
                {
                    return parameters[1].ParameterType;
                }
            }

            return ReflectionUtils.GetMemberType(member);
        }
    }
}
