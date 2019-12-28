﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Datamodel
{
    public class UML_Method : UML_Attribute
    {
        // List to store method parameters, may be empty
        public List<UML_Parameter> parameters { get; set; }


        public override bool Equals(object obj)
        {
            return this.accessModifier == ((UML_Method)obj).accessModifier 
                && this.name == ((UML_Method)obj)?.name 
                && this.type == ((UML_Method)obj)?.type
                && ( parameters == null && ((UML_Method)obj)?.parameters == null
                ||  parameters != null && ((UML_Method)obj)?.parameters != null 
                && parameters.SequenceEqual(((UML_Method)obj).parameters));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = parameters != null ? parameters.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (accessModifier != null ? accessModifier.GetHashCode() : 0 );
                hashCode = (hashCode * 397) ^ (name != null ? name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (type != null ? type.GetHashCode() : 0);
                return hashCode;
            }
        }

    }
}
