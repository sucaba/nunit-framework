﻿// ***********************************************************************
// Copyright (c) 2010 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;

namespace NUnit.Framework.Api
{
    /// <summary>
    /// The ITestResult interface represents the result of a test.
    /// </summary>
    public interface ITestResult
    {
        /// <summary>
        /// Gets the ResultState of the test result, which 
        /// indicates the success or failure of the test.
        /// </summary>
        ResultState ResultState
        {
            get;
        }

        /// <summary>
        /// Gets the name of the test result
        /// </summary>
        string Name
        {
            get;
        }

        /// <summary>
        /// Gets the full name of the test result
        /// </summary>
        string FullName
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is a test case.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is test case; otherwise, <c>false</c>.
        /// </value>
        bool IsTestCase
        {
            get;
        }

        /// <summary>
        /// Gets the elapsed time for running the test
        /// </summary>
        double Time
        {
            get;
        }

        /// <summary>
        /// Gets the message associated with a test
        /// failure or with not running the test
        /// </summary>
        string Message
        {
            get;
        }

#if !NETCF_1_0
        /// <summary>
        /// Gets any stacktrace associated with an
        /// error or failure. Not available in
        /// the Compact Framework 1.0.
        /// </summary>
        string StackTrace
        {
            get;
        }
#endif

        /// <summary>
        /// Gets or sets the count of asserts executed
        /// when running the test.
        /// </summary>
        int AssertCount
        {
            get;
        }

        /// <summary>
        /// Gets the collection of child results.
        /// </summary>
        /// <value>The child results collection</value>
        System.Collections.IList Results
        {
            get;
        }

        /// <summary>
        /// Returns the Xml representation of the result.
        /// </summary>
        /// <param name="recursive">If true, descendant results are included</param>
        /// <returns>An XmlNode representing the result</returns>
        System.Xml.XmlNode ToXml(bool recursive);
    }
}