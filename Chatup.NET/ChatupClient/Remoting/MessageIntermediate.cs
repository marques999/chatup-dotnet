using ChatupNET.Model;

namespace ChatupNET.Remoting
{
    /// <summary>
    ///
    /// </summary>
    internal class MessageIntermediate
    {
        /// <summary>
        ///
        /// </summary>
        public event InviteHandler OnInvite;

        /// <summary>
        ///
        /// </summary>
        public event MessageHandler OnReceive;

        /// <summary>
        ///
        /// </summary>
        public event ConnectHandler OnConnect;

        /// <summary>
        ///
        /// </summary>
        public event DisconnectHandler OnDisconnect;

        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="remoteInvocation"></param>
        public void P2PDisconnect(string userName, bool remoteInvocation)
        {
            OnDisconnect?.Invoke(userName, remoteInvocation);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="remoteMessage"></param>
        public void P2PReceive(RemoteMessage remoteMessage)
        {
            OnReceive?.Invoke(remoteMessage);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="roomInvitation"></param>
        public void P2PInvite(RoomInvitation roomInvitation)
        {
            OnInvite?.Invoke(roomInvitation);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userProfile"></param>
        /// <param name="userHost"></param>
        public void P2PConnect(UserProfile userProfile, string userHost)
        {
            OnConnect?.Invoke(userProfile, userHost);
        }
    }
}