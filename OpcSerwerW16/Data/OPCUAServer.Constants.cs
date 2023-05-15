/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OPCUAServer
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint MotorConveyor_Start = 29;

        /// <remarks />
        public const uint MotorConveyor_Stop = 30;

        /// <remarks />
        public const uint MachineType_Conveyor_Start = 53;

        /// <remarks />
        public const uint MachineType_Conveyor_Stop = 54;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Start = 78;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Stop = 79;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Start = 103;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Stop = 104;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint MachineType_Temperature = 32;

        /// <remarks />
        public const uint MachineType_Proximity = 39;

        /// <remarks />
        public const uint MachineType_Conveyor = 46;

        /// <remarks />
        public const uint OPCUAServerType_Machine = 56;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature = 57;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity = 64;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor = 71;

        /// <remarks />
        public const uint OPCUAServer1 = 80;

        /// <remarks />
        public const uint OPCUAServer1_Machine = 81;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature = 82;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity = 89;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor = 96;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericSensorType = 1;

        /// <remarks />
        public const uint TemperatureSensor = 8;

        /// <remarks />
        public const uint ProximitySensor = 15;

        /// <remarks />
        public const uint MotorConveyor = 22;

        /// <remarks />
        public const uint MachineType = 31;

        /// <remarks />
        public const uint OPCUAServerType = 55;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericSensorType_Value = 2;

        /// <remarks />
        public const uint GenericSensorType_Value_EURange = 6;

        /// <remarks />
        public const uint TemperatureSensor_Value_EURange = 13;

        /// <remarks />
        public const uint ProximitySensor_Value_EURange = 20;

        /// <remarks />
        public const uint MotorConveyor_Speed = 23;

        /// <remarks />
        public const uint MotorConveyor_Speed_EURange = 27;

        /// <remarks />
        public const uint MachineType_Temperature_Value = 33;

        /// <remarks />
        public const uint MachineType_Temperature_Value_EURange = 37;

        /// <remarks />
        public const uint MachineType_Proximity_Value = 40;

        /// <remarks />
        public const uint MachineType_Proximity_Value_EURange = 44;

        /// <remarks />
        public const uint MachineType_Conveyor_Speed = 47;

        /// <remarks />
        public const uint MachineType_Conveyor_Speed_EURange = 51;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature_Value = 58;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Temperature_Value_EURange = 62;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity_Value = 65;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Proximity_Value_EURange = 69;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Speed = 72;

        /// <remarks />
        public const uint OPCUAServerType_Machine_Conveyor_Speed_EURange = 76;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature_Value = 83;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Temperature_Value_EURange = 87;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity_Value = 90;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Proximity_Value_EURange = 94;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Speed = 97;

        /// <remarks />
        public const uint OPCUAServer1_Machine_Conveyor_Speed_EURange = 101;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.MotorConveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.MotorConveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.MachineType_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.MachineType_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Conveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Conveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Conveyor, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(OPCUAServer.ObjectTypes.GenericSensorType, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensor = new ExpandedNodeId(OPCUAServer.ObjectTypes.TemperatureSensor, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProximitySensor = new ExpandedNodeId(OPCUAServer.ObjectTypes.ProximitySensor, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor = new ExpandedNodeId(OPCUAServer.ObjectTypes.MotorConveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType = new ExpandedNodeId(OPCUAServer.ObjectTypes.MachineType, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType = new ExpandedNodeId(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Value = new ExpandedNodeId(OPCUAServer.Variables.GenericSensorType_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.GenericSensorType_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId TemperatureSensor_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.TemperatureSensor_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId ProximitySensor_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.ProximitySensor_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.MotorConveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MotorConveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.MotorConveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <remarks />
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string Conveyor = "Conveyor";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Machine = "Machine";

        /// <remarks />
        public const string MachineType = "MachineType";

        /// <remarks />
        public const string MotorConveyor = "MotorConveyor";

        /// <remarks />
        public const string OPCUAServer1 = "Line";

        /// <remarks />
        public const string OPCUAServerType = "OPCUAServerType";

        /// <remarks />
        public const string Proximity = "Proximity";

        /// <remarks />
        public const string ProximitySensor = "ProximitySensor";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string Start = "Start";

        /// <remarks />
        public const string Stop = "Stop";

        /// <remarks />
        public const string Temperature = "Temperature";

        /// <remarks />
        public const string TemperatureSensor = "TemperatureSensor";

        /// <remarks />
        public const string Value = "Value";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OPCUAServer namespace (.NET code namespace is 'OPCUAServer').
        /// </summary>
        public const string OPCUAServer = "http://opcfoundation.org/OPCUAServer";
    }
    #endregion
}