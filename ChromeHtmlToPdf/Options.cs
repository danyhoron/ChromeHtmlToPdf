﻿using ChromeHtmlToPdfLib.Settings;
using CommandLine;

namespace ChromeHtmlToPdf
{
    /// <summary>
    ///     The parameters that can be used when calling this application
    /// </summary>
    public class Options
    {
        #region Properties
        /// <summary>
        ///     The input url or file
        /// </summary>
        [Option("input", Required = true, HelpText = "The input url or file")]
        public string Input { get; set; }

        /// <summary>
        ///     A file with input url's and/or files
        /// </summary>
        [Option("input-is-list", Required = false,
            HelpText =
                "Tells this app that --input is a list of input url's and/or files. Use the --output parameter to " +
                "give a location where to write information about the converted files, e.g. c:\\myconvertedfiles.txt"
        )]
        public bool InputIsList { get; set; }

        /// <summary>
        ///     The output file
        /// </summary>
        [Option("output", Required = true, HelpText = "The output file")]
        public string Output { get; set; }

        /// <summary>
        ///     Paper orientation. Defaults to false.
        /// </summary>
        [Option("landscape", Default = false, Required = false, HelpText = "Paper orientation")]
        public bool Landscape { get; set; }

        /// <summary>
        ///     Display header and footer. Defaults to false.
        /// </summary>
        [Option("display-headerfooter", Default = false, Required = false, HelpText = "Display header and footer")]
        public bool DisplayHeaderFooter { get; set; }

        /// <summary>
        ///     Print background graphics. Defaults to false.
        /// </summary>
        [Option("print-background", Required = false, Default = false, HelpText = "Print background graphics")]
        public bool PrintBackground { get; set; }

        /// <summary>
        ///     Scale of the webpage rendering. Defaults to 1.
        /// </summary>
        [Option("scale", Default = 1.0, Required = false, HelpText = "Scale of the webpage rendering")]
        public double Scale { get; set; }

        /// <summary>
        ///     The papersize to use, when this option is set is will override <see cref="PaperWidth" /> and
        ///     <see cref="PaperHeight" />
        /// </summary>
        [Option("paper-format", Required = false, Default = PaperFormats.Letter,
            HelpText = "Paper format to use, when set then this will override --paper-width and --paper-height")]
        public PaperFormats PaperFormat { get; set; }

        /// <summary>
        ///     Paper width in inches. Defaults to 8.5 inches.
        /// </summary>
        [Option("paper-width", Default = 8.5, Required = false, HelpText = "Paper width in inches")]
        public double PaperWidth { get; set; }

        /// <summary>
        ///     Paper height in inches. Defaults to 11 inches.
        /// </summary>
        [Option("paper-height", Default = 11.0, Required = false, HelpText = "Paper height in inches")]
        public double PaperHeight { get; set; }

        /// <summary>
        ///     The widowsize to use, when this option is set it will override <see cref="WindowWidth" /> and
        ///     <see cref="WindowHeight" />
        /// </summary>
        [Option("window-size", Required = false, Default = WindowSize.HD_1366_768,
            HelpText = "Window size to use, when set then this will override --window-width and --window-height")]
        public WindowSize WindowSize { get; set; }

        /// <summary>
        ///     Window width in pixel.
        /// </summary>
        [Option("window-width", Default = 1366, Required = false, HelpText = "Window width in pixels")]
        public int WindowWidth { get; set; }

        /// <summary>
        ///     Window height in pixels.
        /// </summary>
        [Option("window-height", Default = 768, Required = false, HelpText = "Window height in pixels")]
        public int WindowHeight { get; set; }

        /// <summary>
        ///     Use the given user-agent
        /// </summary>
        [Option("user-agent", Required = false,
            HelpText = "Let Chrome know that we want to use the given user-agent string instead of the default one")]
        public string UserAgent { get; set; }

        /// <summary>
        ///     Top margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [Option("margin-top", Default = 0.4, Required = false, HelpText = "Top margin in inches")]
        public double MarginTop { get; set; }

        /// <summary>
        ///     Bottom margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [Option("margin-bottom", Default = 0.4, Required = false, HelpText = "Top margin in inches")]
        public double MarginBottom { get; set; }

        /// <summary>
        ///     Left margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [Option("margin-left", Default = 0.4, Required = false, HelpText = "Left margin in inches")]
        public double MarginLeft { get; set; }

        /// <summary>
        ///     Right margin in inches. Defaults to 1cm (~0.4 inches).
        /// </summary>
        [Option("margin-right", Default = 0.4, Required = false, HelpText = "Right margin in inches")]
        public double MarginRight { get; set; }

        /// <summary>
        ///     Paper ranges to print, e.g., '1-5, 8, 11-13'. Defaults to the empty string, which means print all pages.
        /// </summary>
        [Option("pageranges", Required = false, HelpText = "Paper ranges to print, e.g., '1-5, 8, 11-13'")]
        public string PageRanges { get; set; }

        /// <summary>
        ///     Whether to silently ignore invalid but successfully parsed page ranges, such as '3-2'. Defaults to false.
        /// </summary>
        [Option("ignore-invalid-pageranges", Default = false, Required = false,
            HelpText = "Whether to silently ignore invalid but successfully parsed page ranges, such as '3-2'")]
        public bool IgnoreInvalidPageRanges { get; set; }

        /// <summary>
        ///     The location for Chrome, when not set then the registry is accessed to get the needed information
        /// </summary>
        [Option("chrome-location", Required = false,
            HelpText =
                "The location for Chrome, when not set then then this tool first looks inside the folder where" +
                "it is executed from if it can find Chrome.exe (protable) otherwise the registry is accessed " +
                "to get the needed information")]
        public string ChromeLocation { get; set; }

        /// <summary>
        ///     The Chrome user profile location to use, when not set then the default location is used
        /// </summary>
        [Option("chrome-user-profile", Required = false,
            HelpText = "The Chrome user profile location to use, when not set then the default location is used")]
        public string ChromeUserProfile { get; set; }

        /// <summary>
        ///     The default port to use when communicating with Chrome
        /// </summary>
        [Option("portrange", Default = "9222-9322", Required = false,
            HelpText =
                "The port(range) to use when communicating with Chrome. For example 9222-9322 when setting a port range"
        )]
        public string PortRange { get; set; }

        /// <summary>
        ///     This tells Chrome to use a custom proxy configuration
        /// </summary>
        [Option("proxy-server", Required = false, HelpText = "This tells Chrome to use a custom proxy configuration")]
        public string ProxyServer { get; set; }

        /// <summary>
        ///     This tells chrome to bypass any specified proxy for the given semi-colon-separated list of hosts. This flag must be
        ///     used (or rather, only has an effect) in
        ///     tandem with --proxy-server. For example "*.google.com;*foo.com;127.0.0.1:8080"
        /// </summary>
        [Option("proxy-bypass-list", Required = false,
            HelpText =
                "This tells chrome to bypass any specified proxy for the given semi-colon-separated list of hosts. This flag must be used (or rather, only has an effect) in tandem with --proxy-server. For example \"*.google.com;*foo.com;127.0.0.1:8080\""
        )]
        public string ProxyByPassList { get; set; }

        /// <summary>
        ///     This tells Chrome to use the PAC file at the specified URL. For example "http://wpad/windows.pac"
        /// </summary>
        [Option("proxy-pac-url", Required = false,
            HelpText =
                "This tells Chrome to use the PAC file at the specified URL. For example \"http://wpad/windows.pac\"")]
        public string ProxyPacUrl { get; set; }

        /// <summary>
        ///     Run Chrome under this user. This option is used in combination with --password"
        /// </summary>
        [Option("user", Required = false,
            HelpText = "Run Chrome under this user. This option is used in combination with --password")]
        public string User { get; set; }

        /// <summary>
        ///     The password needed for --user
        /// </summary>
        [Option("password", Required = false, HelpText = "The password needed for --user")]
        public string Password { get; set; }

        /// <summary>
        ///     The extra time in milliseconds to wait after the page has been loaded
        /// </summary>
        [Option("wait-for-network-idle", Required = false, Default = false,
            HelpText = "Wait until Chrome signals that all networking is done (e.g. loading external sources like javascript files). " +
                       "Normally this app waits until the DOMLoaded event is executed.")]
        public bool WaitForNetworkIdle { get; set; }

        /// <summary>
        ///     Use multithreading when converting. Only usefull if the parameter --inputlist is used
        /// </summary>
        [Option("multi-threading", Required = false, Default = false,
            HelpText = "Use multi threading when converting. Only usefull if the parameter --input-is-list is used")]
        public bool UseMultiThreading { get; set; }

        /// <summary>
        ///     Limits the concurrency level when doing multi threading conversions. This property is only used when
        ///     --input-is-list and --multi-threading is set to <c>true</c>. When not set then the system decides about
        ///     how many threads will be used
        /// </summary>
        [Option("max-concurrency-level", Required = false, Default = 0,
            HelpText = "Limits the concurrency level when doing multi threading conversions. This parameter is only used when " +
                       "--input-is-list and --multi-threading is set to true. When not set then the system decides about " +
                       " how many threads will be used")]
        public int MaxConcurrencyLevel { get; set; }

        /// <summary>
        ///     Wait for the javascript window.status to equal the given string before starting PDF conversion
        /// </summary>
        [Option("wait-for-window-status", Required = false, Default = "",
            HelpText = "Wait for the javascript window.status to equal the given string before starting PDF conversion")]
        public string WaitForWindowStatus { get; set; }
        
        /// <summary>
        ///     The timeout when waiting for the parameter <see cref="WaitForWindowStatus"/>
        /// </summary>
        [Option("wait-for-window-status-timeout", Required = false, Default = 60000,
            HelpText = "The timeout when waiting for the parameter --wait-for-windows-status")]
        public int WaitForWindowStatusTimeOut { get; set; }
        #endregion
    }
}