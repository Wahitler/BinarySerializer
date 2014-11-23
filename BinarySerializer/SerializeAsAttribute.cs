﻿using System;
using System.Text;

namespace BinarySerialization
{
    /// <summary>
    /// Provides the <see cref="BinarySerializer"/> with information used to serialize the decorated member.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple=false)]
    public sealed class SerializeAsAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializeAsAttribute"/> class.
        /// </summary>
        public SerializeAsAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializeAs class with a specified <see cref="SerializedType"/>.
        /// </summary>
        public SerializeAsAttribute(SerializedType serializedType)
        {
            SerializedType = serializedType;
        }

        /// <summary>
        /// The order to be observed when serializing or deserializing
        ///  this member compared to other members in the parent object.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Specifies the type to which to serialize the member.
        /// </summary>
        public SerializedType SerializedType { get; set; }

        /// <summary>
        /// Specifies the encoding to use when serializing strings.
        /// </summary>
        public Encoding Encoding { get; set; }

        /// <summary>
        /// Specifies the endianness to use when serializing the decorated member.
        /// </summary>
        public Endianness Endianness { get; set; }
    }
}