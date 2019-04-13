﻿namespace BinarySerialization.Test.Issues.Issue76
{
    public abstract class CommandContainer
    {
        [SerializeAs(SerializedType.TerminatedString, StringTerminator = (char)0x20)]
        public CommandType CommandType { get; set; }
    }
}