﻿using ItemAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PMod
{
    public class Module : ETGModule
    {
        public static readonly string MOD_NAME = "Pirate's Personal Portable Plunder Producer";
        public static readonly string VERSION = "1.0.0";
        public static readonly string TEXT_COLOR = "#00FFFF";

        public override void Start()
        {
            ItemBuilder.Init();
            Log($"{MOD_NAME} v{VERSION} started successfully.", TEXT_COLOR);
            CannonFactory.Add();
            ZipFilePath = this.Metadata.Archive;
            FilePath = this.Metadata.Directory;
            AudioResourceLoader.InitAudio();
        }

        public static void Log(string text, string color="#FFFFFF")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Exit() { }
        public override void Init() { }

        public static string ZipFilePath;
        public static string FilePath;
    }
}
