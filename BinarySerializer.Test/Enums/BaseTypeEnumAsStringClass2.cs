﻿namespace BinarySerialization.Test.Enums
{
    internal class BaseTypeEnumAsStringClass2
    {
        [SerializeAs(SerializedType.TerminatedString, StringTerminator = (char)1)]
        public BaseTypeEnumValues Field { get; set; }
    }
}