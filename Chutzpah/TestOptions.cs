﻿using Chutzpah.Models;

namespace Chutzpah
{
    public class TestOptions
    {
        public TestOptions()
        {
            FileSearchLimit = 300;
            TestingMode = TestingMode.All;
        }

        /// <summary>
        /// Whether or not to launch the tests in the default browser
        /// </summary>
        public bool OpenInBrowser { get; set; }

        /// <summary>
        /// The time to wait for the tests to compelte in milliseconds
        /// </summary>
        public int? TimeOutMilliseconds { get; set; }

        /// <summary>
        /// Determines if we are testing JavaScript files (and creating harnesses for them), 
        /// testing html test harnesses directly or both
        /// </summary>
        public TestingMode TestingMode { get; set; }

        /// <summary>
        /// This is the max number of files to run tests for
        /// </summary>
        public int FileSearchLimit { get; set; }
    }
}