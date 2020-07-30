﻿namespace MirthConnectFX
{
    public static class Operations
    {
        public static class ChannelGroups
        {
            public static string GetChannelGroups { get { return "channelgroups"; } }
            public static string BulkUpdate { get { return "/channelgroups/_bulkUpdate"; } }
            public static string GetChannelGroups_Post { get { return "channelgroups/_getChannelGroups"; } }

        }

        public static class User
        {
            public static string Login { get { return "_login"; } }
        }

        public static class Configuration
        {
            public static string GetVerson { get { return "version"; } }
            public static string SetGlobalScripts { get { return "setGlobalScripts"; } }
            public static string GetServerConfiguration { get { return "getServerConfiguration"; } }
        }

        public static class Channels
        {
            public static string GetChannelSummary { get { return "getChannelSummary"; } }
            public static string GetChannel { get { return "getChannel"; } }
            public static string UpdateChannel { get { return "updateChannel"; } }
            public static string GetIdsAndName { get { return "idsAndNames"; } }

        }

        public static class ChannelStatus
        {
            public static string StopChannel { get { return "_stop"; } }
            public static string StartChannel { get { return "_start"; } }
            public static string GetChannelStatus { get { return "statuses"; } }
        }

        public static class Engine
        {
            public static string DeployChannels { get { return "deployChannels"; } }
            public static string UndeplyChannels { get { return "undeployChannels"; } }
        }

        public static class Events
        {
            public static string RemoveAllEvents { get { return "removeAllEvents"; } }
        }

        public static class CodeTemplates
        {
            public static string UpdateCodeTemplatse { get { return "updateCodeTemplates"; } }
        }

        public static class Messages
        {
            public static string ClearMessages { get { return "clearMessages"; } }
            public static string CreateTempTable { get { return "createMessagesTempTable"; } }
            public static string RemoveFilterTable { get { return "removeFilterTables"; } }
            public static string GetMessagesByPage { get { return "getMessagesByPage"; }}
            public static string ProcessMessage { get { return "processMessage"; } }
        }
    }
}