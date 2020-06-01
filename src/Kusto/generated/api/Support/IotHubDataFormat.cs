// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    public partial struct IotHubDataFormat :
        System.IEquatable<IotHubDataFormat>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Avro = @"AVRO";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Csv = @"CSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Json = @"JSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Multijson = @"MULTIJSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Orc = @"ORC";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Parquet = @"PARQUET";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Psv = @"PSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Raw = @"RAW";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Scsv = @"SCSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Singlejson = @"SINGLEJSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Sohsv = @"SOHSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Tsv = @"TSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Tsve = @"TSVE";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat Txt = @"TXT";

        /// <summary>the value for an instance of the <see cref="IotHubDataFormat" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to IotHubDataFormat</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IotHubDataFormat" />.</param>
        internal static object CreateFrom(object value)
        {
            return new IotHubDataFormat(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type IotHubDataFormat</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type IotHubDataFormat (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is IotHubDataFormat && Equals((IotHubDataFormat)obj);
        }

        /// <summary>Returns hashCode for enum IotHubDataFormat</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="IotHubDataFormat" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private IotHubDataFormat(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for IotHubDataFormat</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to IotHubDataFormat</summary>
        /// <param name="value">the value to convert to an instance of <see cref="IotHubDataFormat" />.</param>

        public static implicit operator IotHubDataFormat(string value)
        {
            return new IotHubDataFormat(value);
        }

        /// <summary>Implicit operator to convert IotHubDataFormat to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="IotHubDataFormat" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum IotHubDataFormat</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum IotHubDataFormat</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.IotHubDataFormat e2)
        {
            return e2.Equals(e1);
        }
    }
}