using System;
using System.Collections.Generic;
using System.Reflection;

namespace Il2CppDumper
{
    public class StructInfo
    {
        public string TypeName;
        public bool IsValueType;
        public string Parent;
        public ScriptMetadata TypeInfoPointer;
        public Il2CppTypeDefinition Type;
        public List<StructFieldInfo> Fields = new List<StructFieldInfo>();
        public List<StructFieldInfo> StaticFields = new List<StructFieldInfo>();
        public StructVTableMethodInfo[] VTableMethod = Array.Empty<StructVTableMethodInfo>();
        public List<StructRGCTXInfo> RGCTXs = new List<StructRGCTXInfo>();
        public List<StructMethod> Methods = new List<StructMethod>();
    }

    public class StructMethod
    {
        public ulong Offset;
        public string MethodName;
        public List<StructMethodParameter> Parameters = new List<StructMethodParameter>();
        public string ReturnTypeSignature;
        public bool IsStatic;
        public StructMethodInfo MethodInfo;
    }

    public class StructMethodParameter
    {
        public string Name;
        public string TypeSignature;
    }

    public class StructMethodInfo
    {
        public StructMethod Method;
        public ulong Offset;
        public string Signature;
    }

    public class StructFieldInfo
    {
        public string FieldTypeName;
        public string FieldName;
        public bool IsValueType;
        public bool IsCustomType;
    }

    public class StructVTableMethodInfo
    {
        public string MethodName;
    }

    public class StructRGCTXInfo
    {
        public Il2CppRGCTXDataType Type;
        public string TypeName;
        public string ClassName;
        public string MethodName;
    }
}
