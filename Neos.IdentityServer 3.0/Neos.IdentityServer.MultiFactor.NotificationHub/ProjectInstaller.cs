﻿//******************************************************************************************************************************************************************************************//
// Copyright (c) 2020 Neos-Sdi (http://www.neos-sdi.com)                                                                                                                                    //                        
//                                                                                                                                                                                          //
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),                                       //
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,   //
// and to permit persons to whom the Software is furnished to do so, subject to the following conditions:                                                                                   //
//                                                                                                                                                                                          //
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.                                                           //
//                                                                                                                                                                                          //
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,                                      //
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,                            //
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                               //
//                                                                                                                                                                                          //
// https://adfsmfa.codeplex.com                                                                                                                                                             //
// https://github.com/neos-sdi/adfsmfa                                                                                                                                                      //
//                                                                                                                                                                                          //
//******************************************************************************************************************************************************************************************//
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;

namespace Neos.IdentityServer.MultiFactor.NotificationHub
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void ProjectInstaller_BeforeInstall(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification BEFORE INSTALL");
            }
            catch { }
        }

        private void ProjectInstaller_AfterInstall(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification AFTER INSTALL");
            }
            catch { }
        }

        private void ProjectInstaller_BeforeUninstall(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification BEFORE UNINSTALL");
            }
            catch { }
        }

        private void ProjectInstaller_AfterUninstall(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification AFTER UNINSTALL");
            }
            catch { }
        }

        private void HubInstaller_BeforeRollback(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification BEFORE ROLLBACK");
            }
            catch { }
        }

        private void HubInstaller_AfterRollback(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification AFTER ROLLBACK");
            }
            catch { }
        }

        private void HubInstaller_Committing(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification BEFORE COMMIT");
            }
            catch { }
        }

        private void HubInstaller_Committed(object sender, InstallEventArgs e)
        {
            try
            {
                Trace.TraceInformation("Notification AFTER COMMIT");
            }
            catch { }
        }
    }
}