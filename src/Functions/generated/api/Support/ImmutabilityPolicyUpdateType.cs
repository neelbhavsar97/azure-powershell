// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct ImmutabilityPolicyUpdateType :
        System.IEquatable<ImmutabilityPolicyUpdateType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType Extend = @"extend";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType Lock = @"lock";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType Put = @"put";

        /// <summary>
        /// the value for an instance of the <see cref="ImmutabilityPolicyUpdateType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ImmutabilityPolicyUpdateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ImmutabilityPolicyUpdateType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ImmutabilityPolicyUpdateType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ImmutabilityPolicyUpdateType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ImmutabilityPolicyUpdateType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ImmutabilityPolicyUpdateType && Equals((ImmutabilityPolicyUpdateType)obj);
        }

        /// <summary>Returns hashCode for enum ImmutabilityPolicyUpdateType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ImmutabilityPolicyUpdateType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ImmutabilityPolicyUpdateType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ImmutabilityPolicyUpdateType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ImmutabilityPolicyUpdateType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ImmutabilityPolicyUpdateType" />.</param>

        public static implicit operator ImmutabilityPolicyUpdateType(string value)
        {
            return new ImmutabilityPolicyUpdateType(value);
        }

        /// <summary>Implicit operator to convert ImmutabilityPolicyUpdateType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ImmutabilityPolicyUpdateType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ImmutabilityPolicyUpdateType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ImmutabilityPolicyUpdateType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ImmutabilityPolicyUpdateType e2)
        {
            return e2.Equals(e1);
        }
    }
}