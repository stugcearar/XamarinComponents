﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Xamarin.iOS.Binding.Transformer.Models.Metadata
{
    public class Remove_Node
    {
        [XmlAttribute(AttributeName = "path")]
        public string Path { get; set; }
    }
}
