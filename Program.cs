foreach (string line in System.IO.File.ReadLines("test.txt"))
{
    System.Diagnostics.Process process = new System.Diagnostics.Process();
    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
    startInfo.FileName = "powershell.exe";
    startInfo.Arguments = "/C "+line;
    process.StartInfo = startInfo;
    process.Start();
    process.WaitForExit();
}
