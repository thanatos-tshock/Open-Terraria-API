﻿using System;
using Mono.Cecil;
using System.Linq;

namespace OTA.Patcher.Organisers
{
    public class TerrariaOrganiser : Organiser
    {
        public TerrariaOrganiser(AssemblyDefinition assembly) : base(assembly)
        {
        }

        public TypeDefinition Chest
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Chest"); }
        }

        public TypeDefinition Collision
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Collision"); }
        }

        public TypeDefinition Entity
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Entity"); }
        }

        public TypeDefinition Item
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Item"); }
        }

        public TypeDefinition Lang
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Lang"); }
        }

        public TypeDefinition LaunchInitializer
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "LaunchInitializer"); }
        }

        public TypeDefinition Main
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Main"); }
        }

        public TypeDefinition MapHelper
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "MapHelper"); }
        }

        public TypeDefinition MessageBuffer
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "MessageBuffer"); }
        }

        public TypeDefinition NetMessage
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "NetMessage"); }
        }

        public TypeDefinition Netplay
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Netplay"); }
        }

        public TypeDefinition NPC
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "NPC"); }
        }

        public TypeDefinition Player
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Player"); }
        }

        /// <summary>
        /// Entry class for Mac
        /// </summary>
        /// <value>The program.</value>
        public TypeDefinition Program
        {
            get

            { return _asm.MainModule.Types.Single(x => x.Name == "Program"); }
        }

        public TypeDefinition Projectile
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Projectile"); }
        }

        public TypeDefinition RemoteClient
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "RemoteClient"); }
        }

        public TypeDefinition RemoteServer
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "RemoteServer"); }
        }

        public TypeDefinition Tile
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "Tile"); }
        }

        /// <summary>
        /// Entry class for windows
        /// </summary>
        /// <value>The windows launch.</value>
        public TypeDefinition WindowsLaunch
        {
            get

            { return _asm.MainModule.Types.Single(x => x.Name == "WindowsLaunch"); }
        }

        public TypeDefinition WorldFile
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "WorldFile"); }
        }

        public TypeDefinition WorldGen
        {
            get
            { return _asm.MainModule.Types.Single(x => x.Name == "WorldGen"); }
        }
    }
}

