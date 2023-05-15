using Opc.Ua;
using Opc.Ua.Server;
using System.Collections.Generic;

namespace OPCUAServer
{
    class Server : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            List<INodeManager> nodeManagers = new List<INodeManager>();
            nodeManagers.Add(new NodeManager(server, configuration));
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties prop = new ServerProperties();

            prop.ManufacturerName = "Macheronte";
            prop.ProductName = "OPC Server";
            prop.ProductUri = "http://opcfoundation.org/OPCServer/InformationModelServer/v1.0";
            prop.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            prop.BuildNumber = Utils.GetAssemblyBuildNumber();
            prop.BuildDate = Utils.GetAssemblyTimestamp();

            return prop;
        }
    }
}
