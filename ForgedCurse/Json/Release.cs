﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ForgedCurse.Enumeration;

namespace ForgedCurse.Json
{
    public class Release
    {
        /// <summary>
        /// The identifier for this addon file
        /// </summary>
        [JsonPropertyName("id")]
        public int Identifier { get; set; }

        /// <summary>
        /// The name of the file displayed on Curseforge
        /// </summary>
        [JsonPropertyName("displayName")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the addon's file
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The date at which this file was released
        /// </summary>
        [JsonPropertyName("fileDate")]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// The amount of bytes this release contains
        /// </summary>
        [JsonPropertyName("fileLength")]
        public long FileSize { get; set; }

        /// <summary>
        /// The <see cref="Enumeration.ReleaseType"/> for this file (Alpha, Beta, Release)
        /// </summary>
        public ReleaseType ReleaseType { get; set; }

        /// <summary>
        /// The status of this release
        /// </summary>
        [JsonPropertyName("fileStatus")]
        public ItemStatus Status { get; set; }

        /// <summary>
        /// The URL for the file download
        /// </summary>
        /// <remarks>
        /// Due to the migration from Twitch to CurseForge, this can point to either Twitch (edge.forgecdn.net) or Overwolf (edge-service.overwolf.wtf) CDN
        /// </remarks>
        public string DownloadUrl { get; set; }

        [JsonPropertyName("isAlternate")]
        public bool Alternate { get; set; }

        public int AlternateFileId { get; set; }

        /// <summary>
        /// The dependencies for this addon
        /// </summary>
        public Dependency[] Dependencies { get; set; }

        /// <summary>
        /// Boolean value representing whether or not the file is available
        /// </summary>
        /// <remarks>
        /// Files are unavailable if they are either deprecated or the addon is not available
        /// </remarks>
        [JsonPropertyName("isAvailable")]
        public bool Available { get; set; }

        /// <summary>
        /// The top-most modules (folders / files) in the file archive
        /// </summary>
        public Module[] Modules { get; set; }

        /// <summary>
        /// The hash for this file
        /// </summary>
        /// <remarks>
        /// These hashes are calculated using MurmurHash2 with a seed of 1 and a normalized (removed whitespace characters) array of the file stream (JAR file)
        /// </remarks>
        [JsonPropertyName("packageFingerprint")]
        public uint Hash { get; set; }

        /// <summary>
        /// The compatible versions of the game for this addon
        /// </summary>
        [JsonPropertyName("gameVersion")]
        public string[] CompatibleVersions { get; set; }

        public object InstallMetadata { get; set; }

        public object ServerPackFileId { get; set; }

        public bool HasInstallScript { get; set; }

        /// <summary>
        /// The date at which the compatible version of the game was released
        /// </summary>
        [JsonPropertyName("gameVersionDateReleased")]
        public DateTime GameVersionReleaseDate { get; set; }

        public object GameVersionFlavour { get; set; }
    }
}
