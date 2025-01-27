﻿using System.Xml.Linq;

namespace DotNetProjectFile.Resx;

public sealed class ResHeader : Node
{
    public ResHeader(XElement element, Resource? resource)
        : base(element, resource)
    {
        Value = Children<Value>().FirstOrDefault();
    }

    public string? Name => Element.Attribute("name")?.Value;

    public Value? Value { get; }
}
