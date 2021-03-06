﻿namespace Shaiya.Origin.Common.Packets
{
    /// <summary>
    /// Here we define all the various opcodes for the packets used throughout the Shaiya protocol.
    /// Theoretically, these values should never change, even throughout episodes.
    /// </summary>
    public class Opcodes
    {
        /// <summary>
        /// The ping packet sent by the client, which is used to ensure the client is still connected.
        /// </summary>
        public const int PING = 0x03;

        /// <summary>
        /// Called whenever a login session is terminated, either through ALT + F4, or the "Quit Game" button.
        /// </summary>
        public const int LOGIN_TERMINATE = 0x010B;

        /// <summary>
        /// The login handshake is the first packet sent from the server, to the client, and is responsible
        /// for defining the values used for the encryption algorithm.
        /// </summary>
        public const int LOGIN_HANDSHAKE = 0xA101;

        /// <summary>
        /// A standard login request, sent to the login server, which contains the username and password
        /// values. The server responds with the login result, and if the login result equals 0,
        /// then the server also sends the user id, privilege level, and session identity keys.
        /// </summary>
        public const int LOGIN_REQUEST = 0xA102;

        /// <summary>
        /// The server list packet sent by the server, which contains the various server ids,
        /// the server names, and the server status/population.
        /// </summary>
        public const int SERVER_LIST_DETAILS = 0xA201;

        /// <summary>
        /// Sent by the client when selecting the game server. The client sends the server id
        /// it wishes to connect to, as well as the client version. If the client version matches
        /// that of the server, the packet contains the ip address of the game server that the client
        /// should attempt to connect to.
        /// </summary>
        public const int SELECT_GAME_SERVER = 0xA202;

        /// <summary>
        /// The game handshake request sent by the client, which should contain the previously assigned
        /// user id and session identity keys from the login request.
        /// </summary>
        public const int GAME_HANDSHAKE = 0xA301;

        /// <summary>
        /// Contains information about the various characters for the character selection list.
        /// </summary>
        public const int CHARACTER_LIST = 0x0101;

        /// <summary>
        /// Contains information about a character creation request from the current game account.
        /// </summary>
        public const int CREATE_CHARACTER = 0x0102;

        /// <summary>
        /// Contains information about a character deletion request from the current game account.
        /// </summary>
        public const int DELETE_CHARACTER = 0x0103;

        /// <summary>
        /// Represents a request to enter the game world with a specific character.
        /// </summary>
        public const int CHARACTER_SELECTION = 0x0104;

        /// <summary>
        /// Contains specific details about the game character, such as the max HP, Gold, Stat/Skill Points,
        /// Kills/Deaths, and guild name.
        /// </summary>
        public const int CHARACTER_DETAILS = 0x0105;

        /// <summary>
        /// Contains the current faction of the game account (either Light, Fury, or undecided).
        /// </summary>
        public const int ACCOUNT_FACTION = 0x0109;

        /// <summary>
        /// Checks if a given character name is available
        /// </summary>
        public const int AVAILABLE_CHARACTER_NAME = 0x0119;

        /// <summary>
        /// Contains the amount of "Aeria Points" the account possesses.
        /// </summary>
        public const int ACCOUNT_AERIA_POINTS = 0x2601;
    }
}