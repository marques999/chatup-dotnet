using System;
using System.Collections.Generic;
using ChatupNET.Model;

namespace ChatupNET.Remoting
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="roomId"></param>
    public delegate void DeleteHandler(int roomId);

    /// <summary>
    ///
    /// </summary>
    /// <param name="roomInformation"></param>
    public delegate void InsertHandler(Room roomInformation);

    /// <summary>
    ///
    /// </summary>
    /// <param name="roomId"></param>
    /// <param name="roomCount"></param>
    /// <param name="roomCapacity"></param>
    public delegate void UpdateHandler(int roomId, int roomCount, int roomCapacity);

    /// <summary>
    ///
    /// </summary>
    public interface LobbyInterface
    {
        /// <summary>
        ///
        /// </summary>
        event InsertHandler OnInsert;

        /// <summary>
        ///
        /// </summary>
        event DeleteHandler OnDelete;

        /// <summary>
        ///
        /// </summary>
        event UpdateHandler OnUpdate;

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Dictionary<int, Room> Rooms
        {
            get;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        RemoteResponse Delete(int roomId, string userName);

        /// <summary>
        ///
        /// </summary>
        /// <param name="roomInformation"></param>
        /// <returns></returns>
        Tuple<RemoteResponse, Room> Insert(Room roomInformation);

        /// <summary>
        ///
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomPassword"></param>
        /// <returns></returns>
        Tuple<RemoteResponse, string> Join(int roomId, string roomPassword);
    }
}