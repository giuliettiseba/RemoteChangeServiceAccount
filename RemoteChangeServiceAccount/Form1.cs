using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform;
using VideoOS.Platform.ConfigurationItems;
using VideoOS.Platform.SDK.Platform;

namespace RemoteChangeServiceAccount
{
    public partial class Form1 : Form
    {
        enum Authorizationmodes
        {
            DefaultWindows,
            Windows,
            Basic
        };

        // Join the dark theme 
        readonly Color TEXTBACKCOLOR = System.Drawing.ColorTranslator.FromHtml("#252526");
        readonly Color BACKCOLOR = System.Drawing.ColorTranslator.FromHtml("#2D2D30");
        readonly Color INFOCOLOR = System.Drawing.ColorTranslator.FromHtml("#1E7AD4");
        readonly Color MESSAGECOLOR = System.Drawing.ColorTranslator.FromHtml("#86A95A");
        readonly Color DEBUGCOLOR = System.Drawing.ColorTranslator.FromHtml("#DCDCAA");
        readonly Color ERRORCOLOR = System.Drawing.ColorTranslator.FromHtml("#B0572C");

        private static ManagementServer managementServer;
        private static readonly Guid IntegrationId = new Guid("67D9C3E8-11DD-4444-A5A2-6056FC5DD5B7");
        private const string IntegrationName = "Config Add Cameras";
        private const string Version = "1.0";
        private const string ManufacturerName = "Sample Manufacturer";

        public Form1()
        {
            VideoOS.Platform.SDK.Environment.Initialize();

            InitializeComponent();
            textBoxAllDomain.Text = ".";
            textBoxAllUser.Text = "Administrator";
            textBoxAllPass.Text = "Milestone1$";

            textBoxMSAddress.Text = "172.28.237.190";
            textBoxMSDomain.Text = ".";
            textBoxMSUser.Text = "Administrator";
            textBoxMSPass.Text = "Milestone1$";


            /*            textBoxMSAddress.Text = "10.1.0.192";
                        textBoxMSDomain.Text = "MEX-LAB";
                        textBoxMSUser.Text = "SGIU";
                        textBoxMSPass.Text = "Milestone1$";
              */
        }

        /// <summary>
        /// Login routine 
        /// </summary>
        /// <returns></returns> True if successfully logged in
        private bool Login()
        {
            var checkedButton = groupBoxManagementServer.Controls.OfType<RadioButton>()
                           .FirstOrDefault(r => r.Checked);

            Authorizationmodes _auth;

            if (checkedButton == radioButtonWindowsUser)
                _auth = Authorizationmodes.Windows;
            else if (checkedButton == radioButtonCurrentUser)
                _auth = Authorizationmodes.DefaultWindows;
            else _auth = Authorizationmodes.Basic;

            Uri uri = new UriBuilder(textBoxMSAddress.Text).Uri;
            NetworkCredential nc;
            switch (_auth)
            {
                case Authorizationmodes.DefaultWindows:
                    nc = CredentialCache.DefaultNetworkCredentials;
                    VideoOS.Platform.SDK.Environment.AddServer(false, uri, nc);
                    break;
                case Authorizationmodes.Windows:
                    nc = new NetworkCredential(textBoxMSUser.Text, textBoxMSPass.Text, textBoxMSDomain.Text);
                    VideoOS.Platform.SDK.Environment.AddServer(false, uri, nc);
                    break;
                case Authorizationmodes.Basic:
                    CredentialCache cc = VideoOS.Platform.Login.Util.BuildCredentialCache(uri, textBoxMSUser.Text, textBoxMSPass.Text, "Basic");
                    VideoOS.Platform.SDK.Environment.AddServer(false, uri, cc);
                    break;
            }

            try
            {
                WriteInConsole("Connecting to " + uri + ".", LogType.message);
                VideoOS.Platform.SDK.Environment.Login(uri, IntegrationId, IntegrationName, Version, ManufacturerName);
            }
            catch (ServerNotFoundMIPException snfe)
            {
                WriteInConsole("Server not found: " + snfe.Message, LogType.error);
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                return false;
            }
            catch (InvalidCredentialsMIPException ice)
            {
                WriteInConsole("Invalid credentials for: " + ice.Message, LogType.error);
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                return false;
            }
            catch (Exception)
            {
                WriteInConsole("Internal error connecting to: " + uri.DnsSafeHost, LogType.error);
                VideoOS.Platform.SDK.Environment.RemoveServer(uri);
                return false;
            }

            managementServer = new ManagementServer(EnvironmentManager.Instance.MasterSite);
            WriteInConsole("Connecting to " + uri + "  succeeded.", LogType.message);
            return true;
        }


        private ServerInfo GetServerInfoFromDataGridRow(DataGridViewRow serverRow)
        {

            return new ServerInfo()
            {
                DisplayName = (string)serverRow.Cells["DisplayName"].Value,
                ServerType = (string)serverRow.Cells["ServerType"].Value,
                Address = (string)serverRow.Cells["Address"].Value,
                Domain = (string)serverRow.Cells["Domain"].Value,
                UserName = (string)serverRow.Cells["User"].Value,
                Password = (string)serverRow.Cells["Password"].Value,
            };

        }


        private void buttonAllCredentials_Click(object sender, EventArgs e)
        {

            Credentials credentials = GetCredentials();



            /// DO MS SERVER FIRST
            /// then RS concurrent 


            foreach (DataGridViewRow serverRow in serversDataGridView.Rows)             // find ms
            {
                ServerInfo serverInfo = GetServerInfoFromDataGridRow(serverRow);
                if (IsSameServer(serverInfo.Address, managementServer.ComputerName))
                {
                    DoTheUserChange(serverInfo, credentials);
                }

            }

            Thread.Sleep(5000); /// Just sit 5 sec until IDP starts 

            var listOfTasks = new List<Task>();
            buttonChangeCredentials.Enabled = false;

            WriteInConsole("Change credencials.", LogType.message);

            foreach (DataGridViewRow serverRow in serversDataGridView.Rows)
            {
                ServerInfo serverInfo = GetServerInfoFromDataGridRow(serverRow);

                if (!IsSameServer(serverInfo.Address, managementServer.ComputerName))

                    if (serverInfo.Address != managementServer.MasterSiteAddress)

                        listOfTasks.Add(new Task(() =>
                    {
                        DoTheUserChange(serverInfo, credentials);
                    }, new CancellationToken()));
            }

            int _maxDegreeOfParallelism = (int)numericUpDown_MaxDegreeOfParallelism.Value;

            Task tasks = StartAndWaitAllThrottledAsync(listOfTasks, _maxDegreeOfParallelism, -1).ContinueWith(result =>
            {
                WriteInConsole("Change credencials succeeded.", LogType.message);
                buttonChangeCredentials.Invoke((MethodInvoker)delegate
                {
                    buttonChangeCredentials.Enabled = true;
                });
            });
        }


        private void DoTheUserChange(ServerInfo serverInfo, Credentials credentials)
        {
            ManagementScope theScope = GetScope(serverInfo);
            foreach (DataGridViewRow serviceRow in servicesDataGridView.Rows)
            {
                if (serviceRow.Cells["ServiceServer"].Value.ToString() == serverInfo.Address)
                {
                    if ((bool)serviceRow.Cells["ServiceSelected"].Value)
                    {

                        Console.WriteLine(ChangeServiceAccountInfo(serverInfo, serviceRow.Cells["ServiceName"].Value.ToString(), credentials, theScope));
                    }
                }
            }
            WriteInConsole("Register Server.", LogType.info);
            string result = RegisterServer(serverInfo);
            WriteInConsole($"Register Server {serverInfo.DisplayName} {result}.", LogType.info);

        }

        private string RegisterServer(ServerInfo serverInfo, String newHostName = null)
        {
            string fullPath = @"C:\Program Files\Milestone\Server Configurator\ServerConfigurator.exe";

            ManagementScope theScope = GetScope(serverInfo);

            return ExecuteFile(theScope, fullPath, " /register /quiet");
        }

        private string ExecuteFile(ManagementScope theScope, string file, string args)
        {
            object[] theProcessToRun = { file + args, null, null, 0 };





            ManagementClass theClass = new ManagementClass(theScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());

            try
            {
                var output = theClass.InvokeMethod("Create", theProcessToRun);


                if ((uint)output == 0)
                {
                    string ProcID = theProcessToRun[3].ToString();

                    WriteInConsole("PID on server  " + ProcID, LogType.debug);

                    WqlEventQuery wQuery = new WqlEventQuery("Select * From __InstanceDeletionEvent Within 1 Where TargetInstance ISA 'Win32_Process'");

                    using (ManagementEventWatcher wWatcher = new ManagementEventWatcher(theScope, wQuery))
                    {
                        bool stopped = false;

                        while (stopped == false)
                        {
                            using (ManagementBaseObject MBOobj = wWatcher.WaitForNextEvent())  // ERROR MORE THAN 600 Secs?
                            {
                                if (((ManagementBaseObject)MBOobj["TargetInstance"])["ProcessID"].ToString() == ProcID)
                                {
                                    // the process has stopped
                                    stopped = true;
                                    //Console.WriteLine("Process stoped");
                                    WriteInConsole("Process stoped", LogType.debug);
                                }
                            }
                        }
                        wWatcher.Stop();
                    }
                }
                return ErrorCodeToString((uint)output);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        internal static String ErrorCodeToString(uint errorCode)
        {
            switch (errorCode)
            {
                case 0: return "Successful Completion";
                case 2: return "Access Denied";
                case 3: return "Insufficient Privilege";
                case 8: return "Unknown Failure";
                case 9: return "Path not found";
                case 21: return "Invalid parameter";
                default: return "ERROR:" + errorCode;
            }
        }

        private string ChangeServiceAccountInfo(ServerInfo remoteInfo, string serviceName, Credentials credentials, ManagementScope theScope)
        {
            WriteInConsole($"Change credencials: {remoteInfo.DisplayName}, {serviceName}  ", LogType.info);


            string mgmntPath = string.Format("Win32_Service.Name='{0}'", serviceName);

            using (ManagementObject service = new ManagementObject(theScope, new ManagementPath(mgmntPath), new ObjectGetOptions()))
            {
                object[] accountParams = new object[11];
                accountParams[6] = credentials.USERA;
                accountParams[7] = credentials.Password;
                uint returnCode = (uint)service.InvokeMethod("Change", accountParams);
                return ErrorCode(returnCode);
            }
        }

        private Credentials GetCredentials()
        {
            var checkedButton = groupBoxCredentials.Controls.OfType<RadioButton>()
                                   .FirstOrDefault(r => r.Checked);

            if (checkedButton == radioButtonSpecificUser)

                return new Credentials()
                {
                    Domain = textBoxAllDomain.Text,
                    UserName = textBoxAllUser.Text,
                    Password = textBoxAllPass.Text
                };

            else
                return new Credentials()
                {
                    Domain = "NT AUTHORITY",
                    UserName = "NetworkService",
                    Password = ""
                };
        }





        private bool IsLocalServer(string address)
        {
            IPHostEntry remoteHostEntry = Dns.GetHostEntry(address);
            IPHostEntry localHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            bool result = localHostEntry.HostName == remoteHostEntry.HostName;
            WriteInConsole("Running local: " + result, LogType.debug);
            return result;
        }



        private bool IsSameServer(string address1, string address2)
        {
            IPHostEntry remoteHostEntry = Dns.GetHostEntry(address1);
            IPHostEntry localHostEntry = Dns.GetHostEntry(address2);
            bool result = remoteHostEntry.AddressList.Contains(localHostEntry.AddressList.FirstOrDefault());
            WriteInConsole($"{address1} is the same server as {address2}: { result}", LogType.debug);
            return result;
        }

        private ManagementScope GetScope(ServerInfo remoteInfo)
        {

            if (IsLocalServer(remoteInfo.Address))
            {
                return new ManagementScope(@"\\LOCALHOST\root\cimv2");
            }
            else
            {
                ConnectionOptions theConnection = new ConnectionOptions();
                theConnection.Authority = "ntlmdomain:" + remoteInfo.Domain;
                theConnection.Username = remoteInfo.UserName;
                //theConnection.Password = remoteInfo.Password;
                theConnection.SecurePassword = new NetworkCredential("", remoteInfo.Password).SecurePassword;
                theConnection.Impersonation = ImpersonationLevel.Impersonate;
                theConnection.Authentication = AuthenticationLevel.PacketPrivacy;

                ManagementScope ms = new ManagementScope("\\\\" + remoteInfo.Address + "\\root\\cimv2", theConnection);
                ms.Connect();
                return ms;

            }
        }

        internal static string ResolveHostNametoIP(string host)
        {
            IPHostEntry hostEntry;
            hostEntry = Dns.GetHostEntry(host);
            return hostEntry.AddressList.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString();
        }

        class Credentials
        {
            public Credentials()
            {
            }

            public Credentials(string USERA)
            {

                string[] subs = USERA.Split('\\');
                Domain = subs[0];
                UserName = subs[1];

            }

            public string Domain { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }

            public string USERA
            {
                get
                {
                    return Domain + "\\" + UserName;
                }
            }
        }



        internal static string ErrorCode(uint returnCode)
        {
            string errorMessage = "";
            switch (returnCode)
            {
                case 0: errorMessage = "The request was accepted."; break;
                case 2: errorMessage = "The user did not have the necessary access."; break;
                case 3: errorMessage = "The service cannot be stopped because other services that are running are dependent on it."; break;
                case 4: errorMessage = "The requested control code is not valid, or it is unacceptable to the service."; break;
                case 5: errorMessage = "The requested control code cannot be sent to the service because the state of the service (Win32_BaseService.State property) is equal to 0, 1, or 2."; break;
                case 6: errorMessage = "The service has not been started."; break;
                case 7: errorMessage = "The service did not respond to the start request in a timely fashion."; break;
                case 8: errorMessage = "Unknown failure when starting the service."; break;
                case 9: errorMessage = "The directory path to the service executable file was not found."; break;
                case 10: errorMessage = "The service is already running."; break;
                case 11: errorMessage = "The database to add a new service is locked."; break;
                case 12: errorMessage = "A dependency this service relies on has been removed from the system."; break;
                case 13: errorMessage = "The service failed to find the service needed from a dependent service."; break;
                case 14: errorMessage = "The service has been disabled from the system."; break;
                case 15: errorMessage = "The service does not have the correct authentication to run on the system."; break;
                case 16: errorMessage = "This service is being removed from the system."; break;
                case 17: errorMessage = "The service has no execution thread."; break;
                case 18: errorMessage = "The service has circular dependencies when it starts."; break;
                case 19: errorMessage = "A service is running under the same name."; break;
                case 20: errorMessage = "The service name has invalid characters."; break;
                case 21: errorMessage = "Invalid parameters have been passed to the service."; break;
                case 22: errorMessage = "The account under which this service runs is either invalid or lacks the permissions to run the service."; break;
                case 23: errorMessage = "The service exists in the database of services available from the system."; break;
                case 24: errorMessage = "The service is currently paused in the system."; break;
                default: break;
            }
            return errorMessage;
        }

        class ServerInfo
        {
            public string Address { get; set; }
            public string Domain { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string ServerType { get; set; }
            public string DisplayName { get; set; }
        }

        private void Get_Servers_Click(object sender, EventArgs e)
        {
            Get_Servers.Enabled = false;
            serversDataGridView.Rows.Clear();
            if (Login())                                                                                                         // Login using the credential from Managment Server group 
            {
                WriteInConsole("Getting Recording Servers list from " + managementServer.DisplayName + ".", LogType.message);
                ICollection<RecordingServer> recordingServers = managementServer.RecordingServerFolder.RecordingServers;       // Get the recording server folder using Milestone SDK 
                List<ServerInfo> recordingServerList = new List<ServerInfo>();                                                  // Empty ServerInfo list 

                foreach (RecordingServer recordingServer in recordingServers)                                                   // For each recording server in the folder add it to the list 
                {
                    recordingServerList.Add(new ServerInfo()
                    {
                        Address = recordingServer.HostName,
                        Domain = textBoxMSDomain.Text,
                        UserName = textBoxMSUser.Text,
                        Password = textBoxMSPass.Text,
                        ServerType = recordingServer.ItemCategory,
                        DisplayName = recordingServer.DisplayName
                    });
                }
                PopulateServersDataGrid(recordingServerList);
                buttonGetServices.Enabled = true;
                WriteInConsole("Getting Recording Servers list from " + managementServer.DisplayName + " succeeded.", LogType.message);
            }
            else
            {
                WriteInConsole("Fail to login.", LogType.message);
            }
            Get_Servers.Enabled = true;
        }

        private void GetServices_Button_Click(object sender, EventArgs e)
        {
            servicesDataGridView.Rows.Clear();
            var listOfTasks = new List<Task>();

            WriteInConsole("Getting Milestone Services list.", LogType.message);
            foreach (DataGridViewRow serverRow in serversDataGridView.Rows)
            {
                ServerInfo serverInfo = new ServerInfo()
                {
                    DisplayName = serverRow.Cells["DisplayName"].Value.ToString(),
                    ServerType = serverRow.Cells["ServerType"].Value.ToString(),
                    Domain = serverRow.Cells["Domain"].Value.ToString(),
                    UserName = serverRow.Cells["User"].Value.ToString(),
                    Address = serverRow.Cells["Address"].Value.ToString(),
                    Password = serverRow.Cells["Password"].Value.ToString(),
                };


                listOfTasks.Add(new Task(() =>
                {
                    List<Service> services = EnumServices(serverInfo);
                    PopulateServicesDataGrid(serverInfo, services);
                }, new CancellationToken()));
            }

            int _maxDegreeOfParallelism = (int)numericUpDown_MaxDegreeOfParallelism.Value;

            Task tasks = StartAndWaitAllThrottledAsync(listOfTasks, _maxDegreeOfParallelism, -1).ContinueWith(result =>
            {
                WriteInConsole("Getting Milestone Services list succeeded.", LogType.message);
                buttonChangeCredentials.Invoke((MethodInvoker)delegate
                {
                    buttonChangeCredentials.Enabled = true;
                });
            });
        }

        private void PopulateServersDataGrid(List<ServerInfo> serverList)
        {
            foreach (ServerInfo server in serverList)
            {
                int n = serversDataGridView.Rows.Add();
                serversDataGridView.Rows[n].Cells["DisplayName"].Value = server.DisplayName;
                serversDataGridView.Rows[n].Cells["Address"].Value = server.Address;
                serversDataGridView.Rows[n].Cells["ServerType"].Value = server.ServerType;
                serversDataGridView.Rows[n].Cells["Domain"].Value = server.Domain;
                serversDataGridView.Rows[n].Cells["User"].Value = server.UserName;
                serversDataGridView.Rows[n].Cells["Password"].Value = server.Password;
                serversDataGridView.Rows[n].Cells["Selected"].Value = true;
            }
        }

        private void PopulateServicesDataGrid(ServerInfo server, List<Service> services)
        {
            servicesDataGridView.Invoke((MethodInvoker)delegate
            {
                foreach (Service service in services)
                {
                    int j = servicesDataGridView.Rows.Add();
                    servicesDataGridView.Rows[j].Cells["ServiceServer"].Value = server.Address;
                    servicesDataGridView.Rows[j].Cells["ServiceName"].Value = service.Name;
                    servicesDataGridView.Rows[j].Cells["ServiceUserName"].Value = service.Logon;
                    servicesDataGridView.Rows[j].Cells["ServiceState"].Value = service.State;
                    servicesDataGridView.Rows[j].Cells["ServiceSelected"].Value = true;
                };
            });
        }

        private List<Service> EnumServices(ServerInfo remoteInfo)
        {
            WriteInConsole("Getting Milestone Services list from " + remoteInfo.DisplayName + ".", LogType.info);

            List<Service> services = new List<Service>();

            ManagementScope theScope = GetScope(remoteInfo);

            const string SERVICENAMEPREFIX = "Milestone";

            SelectQuery sQuery = new System.Management.SelectQuery(string.Format("select name, startname, state from Win32_Service where name like '{0}'", "%" + SERVICENAMEPREFIX + "%"));
            using (ManagementObjectSearcher mgmtSearcher = new System.Management.ManagementObjectSearcher(theScope, sQuery))
            {
                foreach (ManagementObject service in mgmtSearcher.Get())
                {
                    services.Add(new Service()
                    {
                        Name = service["name"].ToString(),
                        Logon = service["startname"].ToString(),
                        State = service["state"].ToString(),
                    });
                }
            }
            WriteInConsole("Getting Milestone Services list from " + remoteInfo.DisplayName + " succeeded", LogType.info);

            return services;
        }

        class Service
        {
            public string Name { get; set; }
            public string State { get; set; }
            public string Logon { get; set; }

        }

        bool debug = true;
        private void WriteInConsole(string text, LogType type, string enl = "\n", bool showDate = true, bool scroll = true)
        {

            if (debug || type != LogType.debug)

            {

                textBox_Console.Invoke((MethodInvoker)delegate
                {
                    Color _color;
                    switch (type)
                    {
                        case LogType.debug:
                            _color = DEBUGCOLOR;
                            break;
                        case LogType.message:
                            _color = MESSAGECOLOR;
                            break;
                        case LogType.info:
                            _color = INFOCOLOR;
                            break;
                        case LogType.error:
                            _color = ERRORCOLOR;
                            break;
                        default:
                            _color = Color.White;
                            break;
                    }


                    if (enl == "\n") enl = Environment.NewLine;

                    textBox_Console.SelectionStart = textBox_Console.TextLength;
                    textBox_Console.SelectionLength = 0;

                    textBox_Console.SelectionColor = _color;
                    if (showDate) textBox_Console.AppendText(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ": ");
                    textBox_Console.AppendText(text + enl);
                    textBox_Console.SelectionColor = textBox_Console.ForeColor;

                    if (scroll)
                    {
                        textBox_Console.SelectionStart = textBox_Console.TextLength;
                        textBox_Console.ScrollToCaret();
                    }
                });
            }
        }

        enum LogType
        {
            debug,
            message,
            info,
            error,
        }

        /// <summary>
        /// Thread execution control, limit the parallelism 
        /// </summary>
        /// <param name="tasksToRun"></param>
        /// <param name="maxTasksToRunInParallel"></param>
        /// <param name="timeoutInMilliseconds"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task StartAndWaitAllThrottledAsync(IEnumerable<Task> tasksToRun, int maxTasksToRunInParallel, int timeoutInMilliseconds, CancellationToken cancellationToken = new CancellationToken())
        {
            List<Task> tasks = tasksToRun.ToList(); // Convert to a list of tasks so that we don't enumerate over it multiple times needlessly.
            using (var throttler = new SemaphoreSlim(maxTasksToRunInParallel))
            {
                var postTaskTasks = new List<Task>();

                // Have each task notify the throttler when it completes so that it decrements the number of tasks currently running.
                tasks.ForEach(t => postTaskTasks.Add(t.ContinueWith(tsk => throttler.Release())));

                // Start running each task.
                foreach (var task in tasks)
                {
                    // Increment the number of tasks currently running and wait if too many are running.
                    await throttler.WaitAsync(timeoutInMilliseconds, cancellationToken);

                    cancellationToken.ThrowIfCancellationRequested();
                    task.Start();
                }

                // Wait for all of the provided tasks to complete.
                // We wait on the list of "post" tasks instead of the original tasks, otherwise there is a potential race condition where the throttlers using block is exited before some Tasks have had their "post" action completed, which references the throttler, resulting in an exception due to accessing a disposed object.
                await Task.WhenAll(postTaskTasks.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerInfo serverInfo = new ServerInfo()
            {
                Domain = "mex-lab",
                UserName = "sgiu",
                Password = "Milestone1$",
                Address = "10.1.0.215"

            };

            string fullPath = @"C:\Temp\dummyApp.exe";

            ConnectionOptions theConnection = new ConnectionOptions();
            theConnection.Authority = "ntlmdomain:" + serverInfo.Domain;
            theConnection.Username = serverInfo.UserName;
            //theConnection.Password = remoteInfo.Password;
            theConnection.SecurePassword = new NetworkCredential("", serverInfo.Password).SecurePassword;
            theConnection.Impersonation = ImpersonationLevel.Impersonate;
            theConnection.Authentication = AuthenticationLevel.PacketPrivacy;

            if (theScope == null)
            {
                theScope = new ManagementScope("\\\\" + serverInfo.Address + "\\root\\cimv2", theConnection);
                theScope.Connect();
            }

            object[] theProcessToRun = { fullPath, null, null, 0 };

            ManagementClass theClass = new ManagementClass(theScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());

            var output = (uint)theClass.InvokeMethod("Create", theProcessToRun);

            WriteInConsole(ErrorCodeToString(output), LogType.debug);
            if ((uint)output == 0)
                WriteInConsole(theProcessToRun[3].ToString(), LogType.debug);



        }
        ManagementScope theScope;
        private void button2_Click(object sender, EventArgs e)
        {
            ServerInfo serverInfo = new ServerInfo()
            {
                Domain = "MEX-LAB",
                UserName = "SGIU",
                Password = "Milestone1$",
                Address = "10.1.0.215"

            };
            string fullPath = @"C:\Program Files\Milestone\Server Configurator\ServerConfigurator.exe /register";


            ConnectionOptions theConnection = new ConnectionOptions();
            theConnection.Authority = "ntlmdomain:" + serverInfo.Domain;
            theConnection.Username = serverInfo.UserName;
            //theConnection.Password = remoteInfo.Password;
            theConnection.SecurePassword = new NetworkCredential("", serverInfo.Password).SecurePassword;


            theConnection.Impersonation = ImpersonationLevel.Impersonate;
            theConnection.Authentication = AuthenticationLevel.PacketPrivacy;



            if (theScope == null)
            {
                theScope = new ManagementScope("\\\\" + serverInfo.Address + "\\root\\cimv2", theConnection);
                theScope.Connect();
            }

            object[] theProcessToRun = { fullPath, null, null, 0 };

            //            ManagementClass theClass = new ManagementClass(theScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());

            bool IsInteractive = true;

            uint mjob = 0;
            fullPath = "Notepad.exe";


            ManagementClass classInstance = new ManagementClass(theScope, new ManagementPath("Win32_ScheduledJob"), null);
            object[] arrParams = { fullPath, "20210823162500.030617-300", false, null, null, IsInteractive, mjob };
            var output = classInstance.InvokeMethod("Create", arrParams);


            //var output = (uint)theClass.InvokeMethod("Create", theProcessToRun);

            //            WriteInConsole(ErrorCodeToString(output), LogType.debug);
            if ((uint)output == 0)
                WriteInConsole(theProcessToRun[3].ToString() + " - " + mjob, LogType.debug);





            //I use Select LocalDateTime from Win32_OperatingSystem to get local time of remote machine
            //String strTime = Get_TimeZone(scope);
            //String extendedTime = (Convert.ToInt32(Microsoft.VisualBasic.Strings.Mid(strTime, 9, 4)) + 2).ToString();

            //if (Microsoft.VisualBasic.Strings.Mid(strTime, 9, 1).Equals("0")) { extendedTime = "0" + extendedTime; }
            //strTime = Microsoft.VisualBasic.Strings.Replace(strTime, (Microsoft.VisualBasic.Strings.Mid(strTime, 9, 4)), extendedTime, 1, -1, Microsoft.VisualBasic.CompareMethod.Text);

            //pFileName = @"C:\Program Files\QueUp\Que.exe"







        }
    }
}

