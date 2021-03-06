using System;
using System.Collections.Generic;

using ChatupNET.Model;

namespace ChatupNET.Remoting
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="roomInvitation"></param>
    internal delegate void InviteHandler(RoomInvitation roomInvitation);

    /// <summary>
    ///
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="remoteInvocation"></param>
    internal delegate void DisconnectHandler(string userName, bool remoteInvocation);

    /// <summary>
    ///
    /// </summary>
    /// <param name="userProfile"></param>
    /// <param name="userHost"></param>
    internal delegate void ConnectHandler(UserProfile userProfile, string userHost);

    /// <summary>
    ///
    /// </summary>
    internal class MessageInterface : MarshalByRefObject
    {
        /// <summary>
        ///
        /// </summary>
        private readonly HashSet<string> _users = new HashSet<string>();

        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public RemoteResponse Disconnect(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return RemoteResponse.BadRequest;
            }

            if (_users.Contains(userName))
            {
                _users.Remove(userName);
            }

            ChatupClient.Instance.Messaging.P2PDisconnect(userName, false);

            return RemoteResponse.Success;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="remoteMessage"></param>
        /// <returns></returns>
        public RemoteResponse Send(RemoteMessage remoteMessage)
        {
            if (string.IsNullOrEmpty(remoteMessage?.Author?.Username))
            {
                return RemoteResponse.BadRequest;
            }

            if (string.IsNullOrWhiteSpace(remoteMessage.Contents))
            {
                return RemoteResponse.BadRequest;
            }

            ChatupClient.Instance.Messaging.P2PReceive(remoteMessage);

            return RemoteResponse.Success;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="roomInvitation"></param>
        /// <returns></returns>
        public RemoteResponse Invite(RoomInvitation roomInvitation)
        {
            if (roomInvitation != null && roomInvitation.Id >= 0)
            {
                ChatupClient.Instance.Messaging.P2PInvite(roomInvitation);
            }
            else
            {
                return RemoteResponse.BadRequest;
            }

            return RemoteResponse.Success;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userProfile"></param>
        /// <param name="userHost"></param>
        /// <returns></returns>
        public Tuple<RemoteResponse, UserProfile> Connect(UserProfile userProfile, string userHost)
        {
            var userName = userProfile.Username;

            if (string.IsNullOrEmpty(userName))
            {
                return new Tuple<RemoteResponse, UserProfile>(RemoteResponse.BadRequest, null);
            }

            if (_users.Contains(userName) == false)
            {
                _users.Add(userName);
            }

            ChatupClient.Instance.Messaging.P2PConnect(userProfile, userHost);

            return new Tuple<RemoteResponse, UserProfile>(RemoteResponse.Success, ChatupClient.Instance.Profile);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}